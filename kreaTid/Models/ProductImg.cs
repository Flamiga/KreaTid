﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace kreaTid.Models
{
    public class ProductImg
    {
        //fields
        public int ProductImgId { get; set; }
        public string ProductImgFileUrl { get; set; }

        public string ProductImgAltText { get; set; }

        public string ProductImgType { get; set; }

        public int BlogId { get; }

        // constructor

        public ProductImg() { }

        public ProductImg(int productImgId, string productImgFileUrl, string productImgAltText, string productImgType, int blogId)
        {
            ProductImgId = productImgId;
            ProductImgFileUrl = productImgFileUrl;
            ProductImgAltText = productImgAltText;
            ProductImgType = productImgType;
            BlogId = blogId;
        }
    }
}
