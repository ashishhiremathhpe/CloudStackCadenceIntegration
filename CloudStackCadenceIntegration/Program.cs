using CloudStack.Net;
using CloudStackCadenceIntegration.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
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

    public static class Program
    {
        public static async Task Main(string[] args)
        {
            // Connect to Cadence
            var settings = new CadenceSettings()
            {
                DefaultDomain = "test-domain",
                CreateDomain = true,
                Servers = new List<string>() { "cadence://cadence:7933" }
            };

            using (var client = await CadenceClient.ConnectAsync(settings))
            {
                // Register your workflow implementation to let Cadence
                // know we're open for business.

                await client.RegisterWorkflowAsync<ListVmWorkflow>();
                await client.RegisterActivityAsync<ListVMActivity>();
                await client.StartWorkerAsync("my-tasks");
                
                // Start the web server
                var builder = WebApplication.CreateBuilder(args);
                {
                    builder.Services.AddSingleton(client);
                    builder.Services.AddControllers();
                    builder.Services.AddScoped<IVMService, VMService>();
                }

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