using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly DataContext _dataContext;
        public IQueryable<Item> All()
        {
            return (IQueryable<Item>)(_dataContext);
        }

        public void Delete(int id)
        {

        }

        public void Save(Item item)
        {

        }
    }
}
