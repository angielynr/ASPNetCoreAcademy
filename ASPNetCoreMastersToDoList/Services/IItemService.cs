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

        IEnumerable<ItemDTO> GetByFilters(Dictionary<string, string> dictionary);

        ItemDTO Get(int id);

        void Add(ItemDTO itemDTO);

        void Delete(int id);
    }

}
