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
        private readonly DataContext dataContext;

        public ItemRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IQueryable<Item> All()
        {
            return this.dataContext.Items.AsQueryable();
        }

        public void Delete(int id)
        {
            var itemToBeDeleted = this.dataContext.Items.FirstOrDefault(x => x.Id == id);

            if (itemToBeDeleted != null)
            {
                this.dataContext.Items.Remove(itemToBeDeleted);
            }
        }

        public void Save(Item item)
        {
            this.dataContext.Items.Add(item);

            //if (item.Id == 0)
            //{
            //    this.dataContext.Items.Add(item);
            //}
            //else
            //{
            //    var itemtoBeUpdated = this.dataContext.Items.FirstOrDefault(x => x.Id == item.Id);
            //    itemtoBeUpdated.Text = item.Text;
            //}
        }
    }
}
