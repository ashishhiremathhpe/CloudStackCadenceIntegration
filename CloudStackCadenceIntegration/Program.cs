using CloudStack.Net;
using CloudStackCadenceIntegration.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Neon.Cadence;

namespace CloudStackCadenceIntegration
{
    [WorkflowInterface(TaskList = "my-tasks")]
    public interface IListVMWorkflow : IWorkflow
    {
        [WorkflowMethod]
        Task<string> ListVMAsync(string serviceUrl, string apiKey, string secretKey);
    }

    public class ListVmWorkflow : WorkflowBase, IListVMWorkflow
    {
        public async Task<string> ListVMAsync(string serviceUrl, string apiKey, string secretKey)
        {
            var activityStub = Workflow.NewActivityStub<IListVMActivity>();
            return await activityStub.ListVMAsync(serviceUrl, apiKey, secretKey);
        }
    }

    [ActivityInterface(TaskList = "my-tasks")]
    public interface IListVMActivity : IActivity
    {
        [ActivityMethod]
        Task<string> ListVMAsync(string serviceUrl, string apiKey, string secretKey);
    }

    public class ListVMActivity : ActivityBase, IListVMActivity
    {
        public async Task<string> ListVMAsync(string serviceUrl, string apiKey, string secretKey)
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
                return response.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return "";
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
        public static async Task Main(string[] args)
        {
            ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger1 = factory.CreateLogger("Program");
            logger1.LogInformation("Starting Cadence worker...");

            // Connect to Cadence
            var settings = new CadenceSettings()
            {
                DefaultDomain = "test-domain",
                CreateDomain = true,
                Servers = new List<string>() { "cadence://cadence.default.svc.cluster.local:7933" },
                HeartbeatIntervalSeconds = 300
            };

            using (var client = await CadenceClient.ConnectAsync(settings))
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

                logger1.LogInformation("Starting web server...");
                var app = builder.Build();
                {
                    app.UseExceptionHandler("/error");
                    app.MapControllers();
                    app.Run();
                }
            }
        }
    }
}