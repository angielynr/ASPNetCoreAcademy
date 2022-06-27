using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ASPNetCoreMastersToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private static int userId;

        [HttpGet]
        public IEnumerable<string> Get(int userId)
        {
            return new List<string>(userId);
        }

        public static void GetAll()
        {
            ItemService.GetAll(userId);
        }


    }
}
