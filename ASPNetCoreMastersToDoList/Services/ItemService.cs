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
            _ItemRepository = itemRepository;
        }

        public IEnumerable<ItemDTO> GetAll()
        {
            List<ItemDTO> itemsDTO = new List<ItemDTO>();

            var items = _ItemRepository.All();
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
        public void Save(ItemDTO itemDTO)
        {
            var item = new Item();
            item.Text = itemDTO.Text;
        }

        public IEnumerable<ItemDTO> GetByFilters(Dictionary<string, string> dictionary)
        {
            return this.GetAll();
        }

        public void Update(ItemDTO itemDTO)
        {
            var toBeUpdatedItemDTO = this.GetAll().FirstOrDefault(x => x.Id == itemDTO.Id);
            toBeUpdatedItemDTO.Text = itemDTO.Text;
        }

        public ItemDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(ItemDTO itemDTO)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}