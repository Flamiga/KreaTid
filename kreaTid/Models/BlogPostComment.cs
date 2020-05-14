using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kreaTid.Models
{
    public class BlogPostComment
    {
        //fields 

        public int BlogPostCommentId { get; set; }

        public string BlogPostCommentUser { get; set; }

        public string BlogPostCommentText { get; set; }

        public DateTime BlogPostCommentPublishDate { get; set; }

        public DateTime BlogPostCommentLastUpdated { get; set; }

        public int BlogId { get; }

        //constructor 

        public BlogPostComment() { }

        public BlogPostComment(int blogPostCommentId, string blogPostCommentUser, string blogPostCommentText, DateTime blogPostCommentPublishDate, DateTime blogPostCommentLastUpdated, int blogId)
        {
            BlogPostCommentId = blogPostCommentId;
            BlogPostCommentUser = blogPostCommentUser;
            BlogPostCommentText = blogPostCommentText;
            BlogPostCommentPublishDate = blogPostCommentPublishDate;
            BlogPostCommentLastUpdated = blogPostCommentLastUpdated;
            BlogId = blogId;
        }

    }
}
