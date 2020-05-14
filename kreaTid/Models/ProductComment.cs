using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kreaTid.Models
{
    public class ProductComment
    {
        //´fields
        public int ProductCommentId { get; set; }

        public string ProductCommentUser { get; set; }

        public string ProductCommentText { get; set; }

        public DateTime ProductCommentDate { get; set; }

        public DateTime ProductCommentLastUpdated { get; set; }

        public int ProductId { get; }

        //constructor 

        public ProductComment() { }

        public ProductComment(int productCommentId, string productCommentUser, string productCommentText, DateTime productCommentDate, DateTime productCommentLastUpdated, int productId)
        {
            ProductCommentId = productCommentId;
            ProductCommentUser = productCommentUser;
            ProductCommentText = productCommentText;
            ProductCommentDate = productCommentDate;
            ProductCommentLastUpdated = productCommentLastUpdated;
            ProductId = productId;
        }
    }
}
