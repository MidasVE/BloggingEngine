using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace BloggingEngine.Controllers
{
    public class PokeActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ILogger<PokeActionFilter> log = (ILogger<PokeActionFilter>)context.HttpContext.RequestServices.GetService(typeof(ILogger<PokeActionFilter>));
            log.LogInformation($"{context.Controller.GetType().Name} - {context.ActionDescriptor.DisplayName}");

            System.Console.WriteLine($"TEST 123 {context.Controller.GetType().Name} - {context.ActionDescriptor.DisplayName}");
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ILogger<PokeActionFilter> log = (ILogger<PokeActionFilter>)context.HttpContext.RequestServices.GetService(typeof(ILogger<PokeActionFilter>));
            log.LogInformation($"{context.Controller.GetType().Name} - {context.ActionDescriptor.DisplayName}");
            
            System.Console.WriteLine($"TEST 456 {context.Controller.GetType().Name} - {context.ActionDescriptor.DisplayName}");
        }
    }
}

