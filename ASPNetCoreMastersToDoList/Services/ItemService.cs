using DomainModels;
using Repositories;
using Services.DTO;

namespace Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _ItemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            this._ItemRepository = itemRepository;
        }

        public IEnumerable<ItemDTO> GetAll()
        {
            var items = this._ItemRepository.All();
            List<ItemDTO> itemsDTO = new List<ItemDTO>();

            foreach (var item in items)
            {
                itemsDTO.Add(new ItemDTO()
                {
                    Id = item.Id,
                    Text = item.Text
                });
            }
            return itemsDTO;
        }

        public ItemDTO Get(int id)
        {
            var displayText = this._ItemRepository.All().Where(x => x.Id == id).FirstOrDefault();
            var result = new ItemDTO();
            result.Id = id;
            result.Text = displayText.Text;
            return result;
        }

        public void Add(ItemDTO itemDTO)
        {
            var item = new Item();
            var getLastIdValue = _ItemRepository.All().Last();
            item.Id = getLastIdValue.Id++;
            item.Text = itemDTO.Text;
            this._ItemRepository.Save(item);
        }

        public void Delete(int id)
        {
            this._ItemRepository.Delete(id);
        }

        public void Update(ItemDTO itemDTO)
        {
            var item = new Item();
            item.Id = itemDTO.Id;
            item.Text = itemDTO.Text;
            this._ItemRepository.Save(item);
        }

        public IEnumerable<ItemDTO> GetAllByFilters(ItemByFilterDTO filters)
        {
            throw new NotImplementedException();
        }
    }
}