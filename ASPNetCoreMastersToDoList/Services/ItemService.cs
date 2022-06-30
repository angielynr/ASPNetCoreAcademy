using DomainModels;
using Services.DTO;

namespace Services
{
    public class ItemService : IItemService
    {
        public IEnumerable<ItemDTO> GetAll()
        {
            List<ItemDTO> items = new List<ItemDTO>();
            items.Add(new ItemDTO()
            {
                id = 2,
                Text = "Two"
            });
            items.Add(new ItemDTO()
            {
                id = 3,
                Text = "Twodfds"
            });
            items.Add(new ItemDTO()
            {
                id = 4,
                Text = "Twdsfsdo"
            });

            return items;
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
            var toBeUpdatedItemDTO = this.GetAll().FirstOrDefault(x => x.id == itemDTO.id);
            toBeUpdatedItemDTO.Text = itemDTO.Text;
        }

        public void Delete(int itemId)
        {

        }

        public ItemDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(ItemDTO itemDTO)
        {
            throw new NotImplementedException();
        }
    }
}