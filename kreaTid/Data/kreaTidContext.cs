using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kreaTid.Models;

namespace kreaTid.Data
{
    public class kreaTidContext : DbContext
    {
        public kreaTidContext(DbContextOptions<kreaTidContext> options)
            : base(options)
        {
        }

        public DbSet<BlogPost> BlogPost { get; set; }

        public DbSet<BlogPostComment> BlogPostComment { get; set; }

        public DbSet<Product> Product { get; set; }


        public DbSet<BlogPostImg> BlogPostImg { get; set; }


        public DbSet<Category> Category { get; set; }


        public DbSet<ProductComment> ProductComment { get; set; }


        public DbSet<ProductImg> ProductImg { get; set; }

    }
}
