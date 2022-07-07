using Microsoft.EntityFrameworkCore;
using Repositories.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
