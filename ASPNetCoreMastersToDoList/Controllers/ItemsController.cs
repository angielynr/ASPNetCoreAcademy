using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ASPNetCoreMastersToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> Get(int userId)
        {
            return new List<string>(userId);
        }

        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            //ItemService.GetAll(userId);
            var itemService = new ItemService();
            return itemService.GetAll(2);
        }
    }
}
