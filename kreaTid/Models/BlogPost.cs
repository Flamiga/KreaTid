using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kreaTid.Models
{
    public class BlogPost
    {
        public int BlogPostId { get; set; }

        public string BlogPostTitle { get; set; }

        public DateTime BlogPostDate { get; set; }

        public string BlogPostContent { get; set; }

        public BlogPostImg BlogPostImg { get; }

        public BlogPostComment BlogPostComment { get; }


        //constructor

        public BlogPost() { }

        public BlogPost(int blogPostId, string blogPostTitle, DateTime blogPostDate, string blogPostcontent, BlogPostImg blogPostImg)
        {
            BlogPostId = blogPostId;
            BlogPostTitle = blogPostTitle;
            BlogPostDate = blogPostDate;
            BlogPostContent = blogPostcontent;
            BlogPostImg = blogPostImg;

        }
    }
}
