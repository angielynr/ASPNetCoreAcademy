using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DataContext
    {
        public List<Item> Items;

        public DataContext()
        {
            this.Items = new List<Item>();

            var rnd = new Random();
            Items.Add(new Item()
            {
                Id = 1,
                Text = "One",

            });
            Items.Add(new Item()
            {
                Id = 2,
                Text = "Two",

            });
            Items.Add(new Item()
            {
                Id = 3,
                Text = "Three",

            });
        }
    }
}
