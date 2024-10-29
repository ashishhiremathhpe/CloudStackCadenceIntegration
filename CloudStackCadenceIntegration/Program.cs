using CloudStack.Net;
using CloudStackCadenceIntegration.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Neon.Cadence;
using Npgsql;

namespace CloudStackCadenceIntegration
{
    [WorkflowInterface(TaskList = "my-tasks")]
    public interface IListVMWorkflow : IWorkflow
    {
        [WorkflowMethod]
        Task<ListResponse<UserVmResponse>> ListVMAsync(string serviceUrl, string apiKey, string secretKey);
    }

    public class ListVmWorkflow : WorkflowBase, IListVMWorkflow
    {
        public async Task<ListResponse<UserVmResponse>> ListVMAsync(string serviceUrl, string apiKey, string secretKey)
        {
            var activityStub = Workflow.NewActivityStub<IListVMActivity>();
            return await activityStub.ListVMAsync(serviceUrl, apiKey, secretKey);
        }
    }

    [ActivityInterface(TaskList = "my-tasks")]
    public interface IListVMActivity : IActivity
    {
        [ActivityMethod]
        Task<ListResponse<UserVmResponse>> ListVMAsync(string serviceUrl, string apiKey, string secretKey);
    }

    public class ListVMActivity : ActivityBase, IListVMActivity
    {
        public async Task<ListResponse<UserVmResponse>> ListVMAsync(string serviceUrl, string apiKey, string secretKey)
        {
            var client = new CloudStackAPIClient(
                new CloudStackAPIProxy(serviceUrl, apiKey, secretKey)
            );

            // Create a request object for listing virtual machines
            ListVirtualMachinesRequest request = new ListVirtualMachinesRequest();

            try
            {
                // Send the request and get the response
                var response = client.ListVirtualMachines(request);
                Console.WriteLine($"Total VMs found: {response.Count}");
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return new ListResponse<UserVmResponse>();
        }
    }

    [WorkflowInterface(TaskList = "my-tasks")]
    public interface IDeployVMWorkflow : IWorkflow
    {
        [WorkflowMethod]
        Task<string> DeployVMAsync(string serviceUrl, string apiKey, string secretKey, Guid serviceOfferingId,
            Guid templateId, Guid zoneId);
    }

    public class DeployVmWorkflow : WorkflowBase, IDeployVMWorkflow
    {
        public async Task<string> DeployVMAsync(string serviceUrl, string apiKey, string secretKey,
            Guid serviceOfferingId, Guid templateId, Guid zoneId)
        {
            var activityStub = Workflow.NewActivityStub<IDeployVMActivity>();
            return await activityStub.DeployVMAsync(serviceUrl, apiKey, secretKey, serviceOfferingId, templateId,
                zoneId);
        }
    }

    [ActivityInterface(TaskList = "my-tasks")]
    public interface IDeployVMActivity : IActivity
    {
        [ActivityMethod]
        Task<string> DeployVMAsync(string serviceUrl, string apiKey, string secretKey, Guid serviceOfferingId,
            Guid templateId, Guid zoneId);
    }

    public class DeployVMActivity : ActivityBase, IDeployVMActivity
    {
        public async Task<string> DeployVMAsync(string serviceUrl, string apiKey, string secretKey,
            Guid serviceOfferingId, Guid templateId, Guid zoneId)
        {
            var client = new CloudStackAPIClient(
                new CloudStackAPIProxy(serviceUrl, apiKey, secretKey)
            );

            DeployVirtualMachineRequest request = new DeployVirtualMachineRequest()
            {
                ServiceOfferingId = serviceOfferingId,
                TemplateId = templateId,
                ZoneId = zoneId,
            };

            try
            {
                var result = client.DeployVirtualMachine(request);
                return result.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
    }

    public class Program
    {
        private static CadenceClient client;
        private static Timer _timer;

        public static async Task Main(string[] args)
        {
            ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = factory.CreateLogger("Program");
            logger.LogInformation("Starting Cadence worker...");

            // Connect to Cadence
            var settings = new CadenceSettings()
            {
                DefaultDomain = "test-domain",
                CreateDomain = true,
                Servers = new List<string>() { "cadence://cadence.default.svc.cluster.local:7933" },
                HeartbeatIntervalSeconds = 300
            };

            using (client = await CadenceClient.ConnectAsync(settings))
            {
                // Register your workflow implementation to let Cadence
                // know we're open for business.

                await client.RegisterWorkflowAsync<ListVmWorkflow>();
                await client.RegisterWorkflowAsync<DeployVmWorkflow>();
                await client.RegisterActivityAsync<ListVMActivity>();
                await client.RegisterActivityAsync<DeployVMActivity>();
                await client.StartWorkerAsync("my-tasks");

                // Start the web server
                var builder = WebApplication.CreateBuilder(args);
                {
                    builder.Services.AddLogging();
                    builder.Services.AddSingleton(client);
                    builder.Services.AddControllers();
                    builder.Services.AddScoped<IVMService, VMService>();
                }

                if (args.Length > 0 && args[0].Equals("reflection"))
                {
                    var connString = "Host=localhost:5432;Username=user;Password=password;Database=reflection_db";

                    var dataSourceBuilder = new NpgsqlDataSourceBuilder(connString);
                    var dataSource = dataSourceBuilder.Build();

                    var conn = await dataSource.OpenConnectionAsync();

                    // Set up a timer to run the ListVMs method every minute
                    Timer timer = new Timer(_ => ListVMs(client, logger, conn), null, TimeSpan.Zero,
                        TimeSpan.FromMinutes(1));

                    // Keep the application running
                    await Task.Delay(Timeout.Infinite);
                }
                else
                {
                    logger.LogInformation("Starting web server...");
                    var app = builder.Build();
                    {
                        app.UseExceptionHandler("/error");
                        app.MapControllers();
                        app.Run();
                    }
                }
            }
        }

        private static async void ListVMs(CadenceClient client, ILogger logger, NpgsqlConnection conn)
        {
            logger.LogInformation("Calling Cadence Workflow to list VMs");
            var stub = client.NewWorkflowStub<IListVMWorkflow>();

            var msg = stub.ListVMAsync("http://localhost:8080/client/api/",
                    "ZzNGj3F_J0EOcuT1ZNgbviATBcW9jY7ykbLMac_v6qCXZBPlAlL31qDieGl-q9ojfY0V_S-lRth84oUjVxCBng",
                    "lMgesGM2xufrzPuaGbA7cNK4CCLNKmSCEuNL-Af7ScXwOfl0990ya2iqDedV84sS_i55U9V2tbGX0YMF05CqAw")
                .Result;

            logger.LogInformation("Inserting VMs into database...");
            
            foreach (var vm in msg.Results)
            {
                
                await using (var cmd = new NpgsqlCommand(@"
            INSERT INTO vm (id, account, created, name, state) 
            VALUES (@id, @account, @created, @name, @state)
            ON CONFLICT (id) 
            DO UPDATE SET 
                account = EXCLUDED.account,
                created = EXCLUDED.created,
                name = EXCLUDED.name,
                state = EXCLUDED.state;", conn))
                {
                    cmd.Parameters.AddWithValue("id", Guid.Parse(vm.Id)); // Replace with actual id
                    cmd.Parameters.AddWithValue("account", vm.Account);
                    cmd.Parameters.AddWithValue("created", vm.Created); // Replace with actual created date
                    cmd.Parameters.AddWithValue("name", vm.Name);
                    cmd.Parameters.AddWithValue("state", vm.State);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}