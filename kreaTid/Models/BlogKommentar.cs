using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kreaTid.Models
{
    public class BlogKommentar
    {
        // fields
        public int BlogKomId { get; set; }

        public string BlogKomUser { get; set; }

        public string BlogKomText { get; set; }

        public DateTime BlogKomPublishDate { get; set; }

        public DateTime BlogKomLastUpdated { get; set; }


        // constructor 

        public BlogKommentar() { }

        public BlogKommentar(int blogKomId, string blogKomUser, string blogKomText, DateTime blogKomPublishDate, DateTime blogKomLastUpdated)
        {
            BlogKomId = blogKomId;
            BlogKomUser = blogKomUser;
            BlogKomText = blogKomText;
            BlogKomPublishDate = blogKomPublishDate;
            BlogKomLastUpdated = blogKomLastUpdated;
        }

    }
}
