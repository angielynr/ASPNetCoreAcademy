using DomainModels;
using Repositories;
using Services.DTO;

namespace Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            this._itemRepository = itemRepository;
        }

        public IEnumerable<ItemDTO> GetAll()
        {
            var items = this._itemRepository.All();

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
            var item = this._itemRepository.All().Where(x => x.Id == id).FirstOrDefault();

            var result = new ItemDTO();

            result.Id = id;
            result.Text = item.Text;

            return result;
        }

        public void Add(ItemDTO itemDTO)
        {
            var item = new Item();

            var getLastIdValue = _itemRepository.All().Last();

            item.Id = getLastIdValue.Id++;
            item.Text = itemDTO.Text;

            this._itemRepository.Save(item);
        }

        public void Delete(int id)
        {
            this._itemRepository.Delete(id);
        }

        public void Update(ItemDTO itemDTO)
        {
            var item = new Item();

            item.Id = itemDTO.Id;
            item.Text = itemDTO.Text;

            this._itemRepository.Save(item);
        }

        public IEnumerable<ItemDTO> GetAllByFilters(ItemByFilterDTO filters)
        {
            var items = _itemRepository.All();

            if (!string.IsNullOrEmpty(filters.Text))
            {
                items = items.Where(r => r.Text.ToLower().Contains(filters.Text.ToLower()));
            }

            var itemDTOs = items.AsEnumerable().Select(r => new ItemDTO() { Id = r.Id, Text = r.Text });

            return itemDTOs;
        }
    }
}