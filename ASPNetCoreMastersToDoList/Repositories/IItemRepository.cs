using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IItemRepository
    {
        IQueryable<Item> All();

        void Save(Item item);

        void Delete(int id);
    }
}
