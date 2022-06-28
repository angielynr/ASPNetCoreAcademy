using Services.DTO;

namespace Services
{
    public class ItemService
    {
        public void GetAll()
        {

        }
        public void Save()
        {
            //var itemsController = new ItemsController();
            var itemDTO = new ItemDTO();
            itemDTO.MapDomainModel();
        }
    }
}