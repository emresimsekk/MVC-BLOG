using Blog.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Models
{
    [Table("tbl_articleTags")]
    public class tbl_articleTags
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleTagsID { get; set; }

        public int ArticleID { get; set; }

        public byte TagID { get; set; }


        [ForeignKey("ArticleID")]
        public virtual tbl_article tbl_article { get; set; }

        [ForeignKey("TagID")]
        public virtual tbl_tags tbl_tags { get; set; }

       
    }
}
