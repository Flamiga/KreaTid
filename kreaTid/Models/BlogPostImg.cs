using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kreaTid.Models
{
    public class BlogPostImg
    {
        //fields
        public int ImgId { get; set; }

        public string ImgFileUrl { get; set; }

        public string ImgAltText { get; set; }

        //type = cover, banner og blogpostimg
        public string ImgType { get; set; }

        public int BlogId { get; }


        //constructor
        public BlogPostImg() { }

        public BlogPostImg(int imgId, string imgfileUrl, string imgAltText, string imgType, int blogId)
        {
            ImgId = imgId;
            ImgFileUrl = imgfileUrl;
            ImgAltText = imgAltText;
            ImgType = imgType;
            BlogId = blogId;
        }

    }
}
