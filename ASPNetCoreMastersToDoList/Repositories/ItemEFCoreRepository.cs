using Repositories.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ItemEFCoreRepository : IItemRepository
    {
        private readonly AppDbContext _dbContext;
        public ItemEFCoreRepository(AppDbContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IQueryable<Item> All()
        {
            return _dbContext.Items.AsQueryable();
        }

        public void Delete(int id)
        {
            var itemToBeDeleted = this._dbContext.Items.FirstOrDefault(x => x.Id == id);

            if (itemToBeDeleted != null)
            {
                this._dbContext.Items.Remove(itemToBeDeleted);
            }

            _dbContext.SaveChanges();
        }

        public void Save(Item item)
        {
            if (item.Id == default)
            {
                this._dbContext.Items.Add(item);
            }
            else
            {
                var itemtoBeUpdated = this._dbContext.Items.FirstOrDefault(x => x.Id == item.Id);
                if (itemtoBeUpdated == null)
                {
                    this._dbContext.Items.Add(item);
                }
                else
                {
                    itemtoBeUpdated.Text = item.Text;
                }
            }

            _dbContext.SaveChanges();
        }
    }
}
