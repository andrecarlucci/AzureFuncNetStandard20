using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;

namespace SuperTestFunction {
    public class HttpTrigger {
        public static IActionResult Run(HttpRequest req, TraceWriter log) {
            log.Info("YESSSSSSSSSSSS!");

            if (req.Query.TryGetValue("name", out StringValues value)) {
                return new OkObjectResult($"Hello, {value.First()}");
            }

            return new BadRequestObjectResult("YESSSSSSSSSS!");
        }
    }
}
