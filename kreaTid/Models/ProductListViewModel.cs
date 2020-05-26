using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kreaTid.Models
{
    public class ProductListViewModel
    {
            public IEnumerable<Product> Products { get; set; }
            public string CurrentCategory { get; set; }
        

    }
}