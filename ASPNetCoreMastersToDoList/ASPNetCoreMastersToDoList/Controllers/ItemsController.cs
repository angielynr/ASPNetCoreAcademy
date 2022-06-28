using ASPNetCoreMastersToDoList.BindingModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DTO;

namespace ASPNetCoreMastersToDoList.Controllers
{
    public class ItemsController : ControllerBase
    {
        public int Get(int userId)
        {
            var itemService = new ItemService();
            itemService.GetAll();

            return userId;
        }

        public void Post(ItemCreateBindingModel itemCreateBindingModel)
        {
            var dto = new ItemDTO();
            dto.Text = itemCreateBindingModel.Text;
        }
    }
}
