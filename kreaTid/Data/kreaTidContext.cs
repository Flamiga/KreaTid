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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Products
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<ProductComment>().ToTable("ProductComment");
            modelBuilder.Entity<ProductImg>().ToTable("ProductImg");
            modelBuilder.Entity<Product>().ToTable("Product");

            //Blog Post
            modelBuilder.Entity<BlogPostComment>().ToTable("BlogPostComment");
            modelBuilder.Entity<BlogPost>().ToTable("BlogPost");
            modelBuilder.Entity<BlogPostImg>().ToTable("BlogPostImg");

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Papir" },
                new Category { CategoryId = 2, CategoryName = "xx" },
                new Category { CategoryId = 3, CategoryName = "xx" },
                new Category { CategoryId = 4, CategoryName = "xx" }
                );


            //mangler vores lister fra product img og productcomments
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Maling", ProductPrice = 23.00m, ProductDescription = "bla bla bla", CategoryId = 1 });

            //ændre DateTime til New datetime se side 15 fra exercises L09
            modelBuilder.Entity<ProductComment>().HasData(
                new ProductComment { ProductCommentId = 1, ProductCommentDate = DateTime.Now, ProductCommentUser = "xx", ProductCommentText = "xxx", ProductCommentLastUpdated = DateTime.Now, ProductId = 1 });

            modelBuilder.Entity<ProductImg>().HasData(
            new ProductImg { ProductImgId = 1, ProductImgAltText = "test", ProductImgType = "productImg", ProductImgFileUrl = "~/img/Logo.png", ProductId = 1 });

            //mangler vores lister fra vores billeder og comments.
            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost { BlogPostId = 1, BlogPostTitle = "maling er godt", BlogPostContent = "what th", BlogPostDate = DateTime.Now });

            modelBuilder.Entity<BlogPostComment>().HasData(
                new BlogPostComment { BlogPostCommentId = 1, BlogPostCommentUser = "who", BlogPostCommentText = "what", BlogPostCommentPublishDate = DateTime.Now, BlogPostCommentLastUpdated = DateTime.Now, BlogPostId = 1 });


            modelBuilder.Entity<BlogPostImg>().HasData(
               new BlogPostImg { BlogPostImgId = 1, ImgAltText = "ddd", ImgFileUrl = "~/img/header.jpg", ImgType = "blogbillede", BlogPostId = 1 }
                );

        }

    }

}

