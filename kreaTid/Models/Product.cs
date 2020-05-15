using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace kreaTid.Models
{
    public class Product
    {
        //fields
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public int CategoryId { get; set; }
        public string ProductDescription { get; set; }

        public List<ProductImg> ProductImgs { get; set; }

        public List<ProductComment> ProductComments { get; set; }

        public Category Category { get; set; }


        //constructor

        public Product() { }

        public Product(int productId, string productName, decimal productPrice, int categoryId, string productDescription)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            CategoryId = categoryId;
            ProductDescription = productDescription;

        }

        //add comment with a method
        public void AddComment(ProductComment productComment)
        {
            ProductComments.Add(productComment);
        }
        //add an image with a method
        public void AddImg(ProductImg productImg)
        {
            ProductImgs.Add(productImg);
        }


    }
}
