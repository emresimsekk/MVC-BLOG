using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Dto
{
    public class tbl_articleDTO
    {
      
        public int ArticleID { get; set; }


       
        public byte CategoryID { get; set; }



        public int UserID { get; set; }



        public string ArticleTitle { get; set; }


  
        public string ArticleContent { get; set; }


        public DateTime ArticleCreateDate { get; set; }


       
        public int ArticleViews { get; set; }


       
        public int ArticleLike { get; set; }

        public Boolean State { get; set; }
    }
}
