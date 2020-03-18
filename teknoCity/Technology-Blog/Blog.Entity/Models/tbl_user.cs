using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Entity.Models
{
    [Table("tbl_user")]
    public class tbl_user
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Display(Name = "Kullanıcı ID")]
        public int UserID { get; set; }


        [Required(ErrorMessage = "Bu alan boş geçilemez.")
        , Display(Name = "Kullanıcı Adı")
        , StringLength(20, ErrorMessage = "Bu alan {1} ve {3}  karakter arası oluşmalıdır.")
        , MaxLength(20, ErrorMessage = "En fazla {1} harften oluşmalıdır.")
        , MinLength(12, ErrorMessage = "En az {1} harften oluşmalıdır.")
        , RegularExpression(@"^[a-zA-Z''-'\s]{12,20}$"
        , ErrorMessage = "12-20 arası karakterlere izin verilir.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez.")
       , Display(Name = "Kullanıcı Şifre")
       , StringLength(16, ErrorMessage = "Kurallara uygun bir şifre oluşturun.")
       , MaxLength(16, ErrorMessage = "En fazla {1} harften oluşmalıdır.")
       , MinLength(8, ErrorMessage = "En az {1} harften oluşmalıdır.")
        , RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$"
       , ErrorMessage = "Karakterlere izin verilmiyor.")]
        public string UserPassword { get; set; }
     


        public virtual tbl_userInfo tbl_userInfo { get; set; }


        public virtual ICollection<tbl_userRole> tbl_userRoles { get; set; }

        public virtual ICollection<tbl_userLog> tbl_userLogs { get; set; }

        public virtual ICollection<tbl_article> tbl_articles { get; set; }


        public tbl_user()
        {
            // null referance exception
            tbl_userRoles = new HashSet<tbl_userRole>();
            tbl_userLogs = new HashSet<tbl_userLog>();
            tbl_articles = new HashSet<tbl_article>();
        }
    }

}
