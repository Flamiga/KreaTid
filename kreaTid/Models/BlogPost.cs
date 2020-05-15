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

        public List<BlogPostImg> BlogPostImgs { get; }

        public List<BlogPostComment> BlogPostComments { get; }


        //constructor

        public BlogPost() { }

        public BlogPost(int blogPostId, string blogPostTitle, DateTime blogPostDate, string blogPostcontent)
        {
            BlogPostId = blogPostId;
            BlogPostTitle = blogPostTitle;
            BlogPostDate = blogPostDate;
            BlogPostContent = blogPostcontent;

        }

        public void AddPostComment(BlogPostComment blogPostComment)
        {
            BlogPostComments.Add(blogPostComment);
        }

        public void AddPostImg(BlogPostImg blogPostImg)
        {
            BlogPostImgs.Add(blogPostImg);
        }
    }
}
