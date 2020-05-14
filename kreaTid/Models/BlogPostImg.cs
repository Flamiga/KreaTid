using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kreaTid.Models
{
    public class BlogPostImg
    {
        //fields
        public int BlogPostImgId { get; set; }

        public string ImgFileUrl { get; set; }

        public string ImgAltText { get; set; }

        //type = cover, banner og blogpostimg
        public string ImgType { get; set; }

        public int BlogPostId { get; set; }


        //constructor
        public BlogPostImg() { }

        public BlogPostImg(int imgId, string imgfileUrl, string imgAltText, string imgType, int blogPostId)
        {
            BlogPostImgId = imgId;
            ImgFileUrl = imgfileUrl;
            ImgAltText = imgAltText;
            ImgType = imgType;
            BlogPostId = blogPostId;
        }

    }
}
