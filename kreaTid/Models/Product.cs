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

        public int CategoryId { get; }
        public string ProductDescription { get; set; }

        public ProductImg ProductImg { get; set; }

        public ProductComment ProductComments { get; set; }


        //constructor

        public Product() { }

        public Product(int productId, string productName, decimal productPrice, int categoryId, string productDescription, ProductImg productImg, ProductComment productComments)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            CategoryId = categoryId;
            ProductDescription = productDescription;
            ProductImg = productImg;
            ProductComments = productComments;
        }

    }
}
