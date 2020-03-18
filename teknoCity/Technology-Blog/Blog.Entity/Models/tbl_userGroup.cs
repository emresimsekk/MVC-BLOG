using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Entity.Models
{
    [Table("tbl_userGroup")]
    public class tbl_userGroup
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Display(Name = "Kullanıcı Grup ID")]
        public int UserGroupID { get; set; }


        [Required(ErrorMessage = "Bu alan boş geçilemez.")
        , Display(Name = "Kullanıcı Gurup")
        , StringLength(10, ErrorMessage = "Kurallara uygun bir kullanıcı grubu oluşturun.")
        , MaxLength(50, ErrorMessage = "En fazla {1} harften oluşmalıdır.")
        , MinLength(5, ErrorMessage = "En az {1} harften oluşmalıdır.")]
        public string UserGroupName { get; set; }

        public virtual ICollection<tbl_userRole> tbl_userRoles { get; set; }
        public tbl_userGroup()
        {
            // null referance exception
            tbl_userRoles = new HashSet<tbl_userRole>();

        }
    }
}
