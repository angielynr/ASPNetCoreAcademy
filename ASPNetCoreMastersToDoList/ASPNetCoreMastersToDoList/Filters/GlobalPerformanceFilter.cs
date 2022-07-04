using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace ASPNetCoreMastersToDoList.Filters
{
    public class GlobalPerformanceFilter : Attribute, IActionFilter
    {
        private Stopwatch _stopWatch;

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopWatch.Stop();
            Console.WriteLine($"Elapsed time: {_stopWatch.Elapsed}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopWatch = Stopwatch.StartNew();

            Console.WriteLine("Time started");
        }
    }
}
