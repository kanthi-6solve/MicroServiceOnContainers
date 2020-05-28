using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResourceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ResourceAPI.DBContext
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
