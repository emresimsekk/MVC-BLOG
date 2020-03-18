using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Entity.Models
{
    [Table("tbl_comment")]
    public class tbl_comment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)
        , Display(Name = "Yorum ID")]
        public int CommentID { get; set; }


        [Display(Name = "Makale ID")]
        public int ArticleID { get; set; }


        [Display(Name = "Yorum Kayıt Tarihi")]
        public DateTime CommentCreateDate { get; set; }


        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")
        , Display(Name = "Yorum Adı")
        , StringLength(25, ErrorMessage = "{0} Alanı {1} Karakterden Uzun Olamaz")
        , RegularExpression(@"^[a-zA-Z''-'\s]{2,25}$"
        , ErrorMessage = "Karakterlere izin verilmiyor.")]
        public string CommentName { get; set; }


        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")
        , Display(Name = "Yorum Soyadı")
        , StringLength(25, ErrorMessage = "{0} Alanı {1} Karakterden Uzun Olamaz")
        , RegularExpression(@"^[a-zA-Z''-'\s]{2,25}$"
        , ErrorMessage = "Karakterlere izin verilmiyor.")]
        public string CommentSurname { get; set; }


        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")
        , Display(Name = "Yorum Email")
        , StringLength(25, ErrorMessage = "{0} Alanı {1} Karakterden Uzun Olamaz")
        , RegularExpression(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$"
        , ErrorMessage = "Karakterlere izin verilmiyor.")]
        public string CommentEmail { get; set; }


        [Display(Name = "Yorum Beğeni")]
        public int CommentLike { get; set; }



        [ForeignKey("ArticleID")]
        public virtual tbl_article tbl_article { get; set; }


    }
}
