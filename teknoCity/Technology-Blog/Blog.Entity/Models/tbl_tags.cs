using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Models

{
    [Table("tbl_tags")]
    public class tbl_tags
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte TagID { get; set; }

        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        public string TagName { get; set; }

        public virtual ICollection<tbl_articleTags> tbl_articleTags { get; set; }

        public tbl_tags()
        {
            tbl_articleTags = new HashSet<tbl_articleTags>();
        }
      
    }
}
