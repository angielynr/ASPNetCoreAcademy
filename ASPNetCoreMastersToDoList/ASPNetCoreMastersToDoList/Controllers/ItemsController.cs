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

        public void Post(ItemCreateBindingModel item)
        {
            var itemService = new ItemService();

            var itemDTO = new ItemDTO();
            itemDTO.Text = item.Text;

            itemService.Save(itemDTO);
        }
    }
}
