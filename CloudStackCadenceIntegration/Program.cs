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
            var activityStub = Workflow.NewActivityStub<IListVMActivity>(new ActivityOptions
            {
                RetryOptions = new RetryOptions
                {
                    MaximumAttempts = 6,
                    InitialInterval = TimeSpan.FromSeconds(10),
                }
            });
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
                if (response == null )
                {
                    throw new Exception(" Failed to retrieve VMs or no VMs found.");
                }
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw ex;
            }
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
            var activityStub = Workflow.NewActivityStub<IDeployVMActivity>(new ActivityOptions
            {
                RetryOptions = new RetryOptions
                {
                    MaximumAttempts = 6,
                    InitialInterval = TimeSpan.FromSeconds(10),
                }
            });
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
                Name = "vra-vm",
                DisplayName = "vra-vm"
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
                DefaultDomain = "zvm-core",
                CreateDomain = true,
                Servers = new List<string>() { "cadence://cadence.default.svc.cluster.local:7933" },
                HeartbeatIntervalSeconds = 300,
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

                logger.LogInformation("Cadence worker started.");

                if (args.Length > 0 && args[0].Equals("reflection"))
                {
                    var connString =
                        "Host=postgres.default.svc.cluster.local:5432;Username=user;Password=password;Database=reflection_db;Timeout=300;CommandTimeout=300";

                    var dataSourceBuilder = new NpgsqlDataSourceBuilder(connString);
                    var dataSource = dataSourceBuilder.Build();
                    
                    for (int i = 0; i < 15; i++)
                    {
                        ListVMs(client, logger, dataSource);
                        Thread.Sleep(60000);
                    }
                }
                else
                {
                    // Start the web server
                    var builder = WebApplication.CreateBuilder(args);
                    {
                        builder.Services.AddLogging();
                        builder.Services.AddSingleton(client);
                        builder.Services.AddControllers();
                        builder.Services.AddScoped<IVMService, VMService>();
                    }

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

        private static void ListVMs(CadenceClient client, ILogger logger, NpgsqlDataSource dataSource)
        {
            logger.LogInformation("Calling Cadence Workflow to list VMs");
            var stub = client.NewWorkflowStub<IListVMWorkflow>();

            var msg =  stub.ListVMAsync("http://192.168.111.100:8080/client/api/",
                    "obY9W9UwjJ3XWsagshTgJrvqR2H7SBkcFiTvRslkmSN0niHZLmiZ_MbG7TJw4Kb32SDi-O9-AS6EtJiVWImFRQ",
                    "g-xxlJxSjxHgtn4uTdRp1iMVd9WVrNH4yN-8-FKavIpaGNTkM0R0xC8req64MvAZ3Xus9lOHaNEvTZnxR6ZJbQ").Result;


            if (msg == null || msg.Results == null)
            {
                logger.LogError("Failed to retrieve VMs or no VMs found.");
                return;
            }
            
            logger.LogInformation("Total VMs found: {0}", msg.Count);
            
            logger.LogInformation("DB insertion completed.");
        }
    }
}