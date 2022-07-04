using Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IItemService
    {
        IEnumerable<ItemDTO> GetAll();

        IEnumerable<ItemDTO> GetAllByFilters(ItemByFilterDTO filters);

        ItemDTO Get(int itemId);

        void Add(ItemDTO itemDTO);

        void Update(ItemDTO itemDTO);

        void Delete(int id);
    }

}
