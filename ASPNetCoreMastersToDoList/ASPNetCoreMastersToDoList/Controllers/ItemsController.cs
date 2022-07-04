using ASPNetCoreMastersToDoList.BindingModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services;
using Services.DTO;

namespace ASPNetCoreMastersToDoList.Controllers
{
    [Route("items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _itemService.GetAll();

            return Ok(items);
        }

        [HttpGet("{itemId}")]
        public IActionResult Get(int itemId)
        {
            var item = this._itemService.Get(itemId);

            return Ok(item);
        }

        //[HttpGet("filterBy")]
        //public IActionResult GetByFilters([FromQuery] Dictionary<string, string> filters)
        //{
        //    var itemFiltered = _itemService.GetAllByFilters(filters);

        //    return Ok(itemFiltered);
        //}

        [HttpPost]
        public IActionResult Post([FromBody] ItemCreateBindingModel itemCreateBindingModel)
        {
            var itemDTO = new ItemDTO();

            itemDTO.Text = itemCreateBindingModel.Text;

            this._itemService.Add(itemDTO);

            return Ok();
        }

        [HttpPut("{itemId}")]
        public IActionResult Put(int Id, [FromBody] ItemUpdateBindingModel itemUpdateBinding)
        {
            var itemDTO = new ItemDTO();

            itemDTO.Text = itemUpdateBinding.Text;
            itemDTO.Id = itemUpdateBinding.Id;

            this._itemService.Update(itemDTO);

            return Ok();
        }

        [HttpDelete("{itemId}")]
        public IActionResult Delete(int itemId)
        {
            this._itemService.Delete(itemId);

            return Ok();
        }

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
    }
}
