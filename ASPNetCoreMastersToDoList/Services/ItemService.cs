using DomainModels;
using Services.DTO;

namespace Services
{
    public class ItemService
    {
        public void GetAll()
        {

        }
        public void Save(ItemDTO itemDTO)
        {
            var item = new Item();
            item.Text = itemDTO.Text;
        }
    }
}