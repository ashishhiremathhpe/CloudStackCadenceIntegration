using CloudStack.Net;
using Neon.Cadence;

namespace CloudStackCadenceIntegration
{
    [WorkflowInterface(TaskList = "my-tasks")]
    public interface IHelloWorkflow : IWorkflow
    {
        [WorkflowMethod]
        Task<string> HelloAsync(string serviceUrl, string apiKey, string secretKey);
    }

    public class HelloWorkflow : WorkflowBase, IHelloWorkflow
    {
        public async Task<string> HelloAsync(string serviceUrl, string apiKey, string secretKey)
        {
            var activityStub = Workflow.NewActivityStub<ISendHelloActivity>();
            return await activityStub.SendHelloAsync(serviceUrl, apiKey, secretKey);
        }
    }

    [ActivityInterface(TaskList = "my-tasks")]
    public interface ISendHelloActivity : IActivity
    {
        [ActivityMethod]
        Task<string> SendHelloAsync(string serviceUrl, string apiKey, string secretKey);
    }

    public class SendHelloActivity : ActivityBase, ISendHelloActivity
    {
        public async Task<string> SendHelloAsync(string serviceUrl, string apiKey, string secretKey)
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
                Servers = new List<string>() { "cadence://localhost:7933" }
            };

            using (var client = await CadenceClient.ConnectAsync(settings))
            {
                // Register your workflow implementation to let Cadence
                // know we're open for business.

                await client.RegisterWorkflowAsync<HelloWorkflow>();
                await client.RegisterActivityAsync<SendHelloActivity>();
                await client.StartWorkerAsync("my-tasks");

                // Invoke your workflow.

                var stub = client.NewWorkflowStub<IHelloWorkflow>();

                Console.WriteLine(await stub.HelloAsync("https://qa.cloudstack.cloud/client/api/",
                    "8y--Jfz6BpGLR94eZiKi_1OQhHAQg43ApL_3EJesv8RmDvFpv8TSDTdYDQKT3fIdueb3mCUP9YZgrRuoUaiZmQ",
                    "UKnRfBaAy8mm2SHaLUAYGKHUcKDWp1Ez9-QItMOfdDeK_JMaPXv4mG8_kabVfOwxMQ9pe7y1LSVh_Ff0ggd_jQ"));
            }
        }
    }
}