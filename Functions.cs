using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace AzureFunctionsDI
{
    public class Functions
    {
        private readonly IMyService _service;
        public Functions(IMyService service)
            => _service = service;

        [FunctionName("Get")]
        public IActionResult Get(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "functions")] HttpRequest req
            )
            => new OkObjectResult(_service.Get());
    }
}
