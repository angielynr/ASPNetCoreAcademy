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

        public ItemRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public IQueryable<Item> All()
        {
            return this._dataContext.Items.AsQueryable();
        }

        public void Delete(int id)
        {
            var itemToBeDeleted = this._dataContext.Items.FirstOrDefault(x => x.Id == id);

            if (itemToBeDeleted != null)
            {
                this._dataContext.Items.Remove(itemToBeDeleted);
            }
        }

        public void Save(Item item)
        {
            if (item.Id == default)
            {
                this._dataContext.Items.Add(item);
            }
            else
            {
                var itemtoBeUpdated = this._dataContext.Items.FirstOrDefault(x => x.Id == item.Id);
                if (itemtoBeUpdated == null)
                {
                    this._dataContext.Items.Add(item);
                }
                else
                {
                    itemtoBeUpdated.Text = item.Text;
                }
            }
        }
    }
}
