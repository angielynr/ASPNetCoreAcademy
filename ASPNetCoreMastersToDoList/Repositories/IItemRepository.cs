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
        public IQueryable<Item> All();
        //var items = new List<Item>();
        //items.Add(new DataContext()
        //{
        //    items = "adsdss"
        //});
        //return IQueryable<Item>;


        public void Save(Item item);

        public void Delete(int id);
    }
}
