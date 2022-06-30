using ASPNetCoreMastersToDoList.BindingModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DTO;

namespace ASPNetCoreMastersToDoList.Controllers
{
    [Route("items")]
    [ApiController]
    public class ItemsController : ControllerBase, IItemService
    {
        //public int Get(int userId)
        //{
        //    var itemService = new ItemService();
        //    itemService.GetAll();

        //    return userId;
        //}

        //public void Post(ItemCreateBindingModel item)
        //{
        //    var itemService = new ItemService();

        //    var itemDTO = new ItemDTO();
        //    itemDTO.Text = item.Text;

        //    itemService.Save(itemDTO);
        //}

        [HttpGet]
        public IActionResult GetAll()
        {
            var itemService = new ItemService();
            var items = itemService.GetAll();

            return Ok(items);
        }

        [HttpGet("{itemId}")]
        public IActionResult Get(int itemId)
        {
            return Get(itemId);
        }

        [HttpGet("filterBy")]
        public IActionResult GetByFilters([FromQuery] Dictionary<string, string> filters)
        {
            var itemService = new ItemService();
            return Ok(itemService.GetByFilters(filters));
        }

        [HttpPost]
        public IActionResult Post([FromBody] ItemCreateBindingModel itemCreateBindingModel)
        {
            var itemService = new ItemService();
            var itemDTO = new ItemDTO();

            itemDTO.Text = itemCreateBindingModel.Text;
            itemService.Save(itemDTO);
            return Ok();
        }

        [HttpPut("{itemId}")]
        public IActionResult Put(int Id, [FromBody] ItemUpdateBindingModel itemUpdateBinding)
        {
            var itemService = new ItemService();
            var itemDTO = new ItemDTO();

            itemDTO.id = itemUpdateBinding.Id;
            itemDTO.Text = itemUpdateBinding.Text;

            itemService.Update(itemDTO);
            return Ok();
        }

        [HttpDelete("{itemId}")]
        public IActionResult Delete(int itemId)
        {
            return Delete(itemId);
        }

        IEnumerable<ItemDTO> IItemService.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<ItemDTO> IItemService.GetByFilters(Dictionary<string, string> dictionary)
        {
            throw new NotImplementedException();
        }

        ItemDTO IItemService.Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(ItemDTO itemDTO)
        {
            throw new NotImplementedException();
        }

        void IItemService.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
