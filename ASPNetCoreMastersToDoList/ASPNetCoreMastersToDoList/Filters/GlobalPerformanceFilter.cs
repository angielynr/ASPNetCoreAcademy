using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace ASPNetCoreMastersToDoList.Filters
{
    public class GlobalPerformanceFilter : Attribute, IResourceFilter
    {
        private Stopwatch _stopWatch;

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            _stopWatch.Stop();

            Console.WriteLine($"Elapsed time: {_stopWatch.Elapsed}");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            _stopWatch = Stopwatch.StartNew();
        }
    }
}
