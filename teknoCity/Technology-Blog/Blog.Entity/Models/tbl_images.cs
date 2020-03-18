using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Entity.Models
{
    [Table("tbl_images")]
    public class tbl_images
    {

        [Key, ForeignKey("tbl_article")]
        public int ArticleID { get; set; }


        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")
        , Display(Name = "Küçük Resim")
        , StringLength(40, ErrorMessage = "{0} Alanı {1} Karakterden Uzun Olamaz")
        , RegularExpression(@"^[a-zA-Z''-'\s]{2,20}$"
        , ErrorMessage = "Karakterlere izin verilmiyor.")]
        public string ImagesSmall { get; set; }


        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")
        , Display(Name = "Orta Resim")
        , StringLength(40, ErrorMessage = "{0} Alanı {1} Karakterden Uzun Olamaz")
        , RegularExpression(@"^[a-zA-Z''-'\s]{2,20}$"
        , ErrorMessage = "Karakterlere izin verilmiyor.")]
        public string ImagesMiddle { get; set; }


        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")
        , Display(Name = "Büyük Resim")
        , StringLength(40, ErrorMessage = "{0} Alanı {1} Karakterden Uzun Olamaz")
        , RegularExpression(@"^[a-zA-Z''-'\s]{2,20}$"
        , ErrorMessage = "Karakterlere izin verilmiyor.")]
        public string ImagesBig { get; set; }

        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")
        , Display(Name = "Büyük Resim")
        , StringLength(40, ErrorMessage = "{0} Alanı {1} Karakterden Uzun Olamaz")
        , RegularExpression(@"^[a-zA-Z''-'\s]{2,20}$"
        , ErrorMessage = "Karakterlere izin verilmiyor.")]
        public string ImagesVideo { get; set; }


        public virtual tbl_article tbl_article { get; set; }
    }
}
