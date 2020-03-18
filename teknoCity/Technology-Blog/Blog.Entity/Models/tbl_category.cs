using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Entity.Models
{
    [Table("tbl_category")]
    public class tbl_category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Display(Name = "Kullanıcı Grup ID")]
        public byte CategoryID { get; set; }


        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez"),
         Display(Name = "Kategori Adı"),
         StringLength(20, ErrorMessage = "{0} Alanı {1} Karakterden Uzun Olamaz")]
        public string CategoryName { get; set; }


        public virtual ICollection<tbl_article> tbl_articles { get; set; }


        public tbl_category()
        {
            tbl_articles = new HashSet<tbl_article>();
        }
    }
}
