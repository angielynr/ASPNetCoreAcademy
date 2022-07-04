using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Services;
using Services.DTO;

namespace ASPNetCoreMastersToDoList.Filters
{
    public class ControllerItemExistFilter : Attribute, IActionFilter
    {
        private readonly IItemService _itemService;
        private int itemId;

        public ControllerItemExistFilter(IItemService itemService)
        {
            this._itemService = itemService;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var item = (int)context.HttpContext.Items["itemService"];

            if (item is 0)
            {
                //Console.WriteLine("This is executing");
                context.Result = new NotFoundResult();
            };
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Items["itemService"] = _itemService.Get(itemId);
        }
    }
}
