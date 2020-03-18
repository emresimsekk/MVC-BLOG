using Blog.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Entity.Models
{
    [Table("tbl_article")]
    public class tbl_article 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleID { get; set; }


        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        public byte CategoryID { get; set; }



        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        public int UserID { get; set; }



        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        public string ArticleTitle { get; set; }


        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        public string ArticleContent { get; set; }

        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        public string Preamble   { get; set; }


        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        public DateTime ArticleCreateDate { get; set; }


        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        public int ArticleViews { get; set; }


        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        public int ArticleLike { get; set; }

        public Boolean State { get; set; }

        public virtual tbl_category tbl_category { get; set; }

        public virtual tbl_images tbl_images { get; set; }

        public virtual ICollection<tbl_comment> tbl_comments { get; set; }

        public virtual ICollection<tbl_articleTags> tbl_articleTags { get; set; }

        public virtual tbl_user tbl_user { get; set; }



        public tbl_article()
        {
            tbl_comments = new HashSet<tbl_comment>();
            tbl_articleTags = new HashSet<tbl_articleTags>();
        }


    }
}
