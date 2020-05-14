using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kreaTid.Models
{
    public class Category
    {

        //fields
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        // constructor 

        public Category() { }

        public Category(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }
    }
}
