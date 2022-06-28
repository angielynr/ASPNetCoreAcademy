using ASPNetCoreMastersToDoList.BindingModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ASPNetCoreMastersToDoList.Controllers
{
    public class ItemsController : ControllerBase
    {
        public int Get(int userId)
        {
            ItemService.GetAll();
            return userId;
        }

        public void Post(ItemCreateBindingModel createModel)
        {
            //mapped to an itemDTO for the iteam service save method to consume
        }
    }
}
