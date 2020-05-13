using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kreaTid.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; } //Read only? 

        public string ImageFile { get; set; }

        //constructor

        public Blog() { }

        public Blog(int blogId, string title, DateTime date, string content, string ImageFile)
        {
            BlogId = blogId;
            Title = title;
            Date = date;
            Content = content;
            ImageFile = ImageFile;


        }
    }
}
