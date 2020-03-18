using Blog.Entity.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Entity.Models
{
    [Table("tbl_userInfo")]
    public class tbl_userInfo 
    {
        [Key, ForeignKey("tbl_user")]
        public int UserID { get; set; }


        [Required(ErrorMessage = "Bu alan boş geçilemez.")
        , Display(Name = "Kullanıcı İsim")
        , StringLength(25, ErrorMessage = "Bu alan {1} ve {3}  karakter arası oluşmalıdır.")
        , MaxLength(25, ErrorMessage = "En fazla {1} harften oluşmalıdır.")
        , MinLength(2, ErrorMessage = "En az {1} harften oluşmalıdır.")
        , RegularExpression(@"^[a-zA-Z''-'\s]{2,25}$"
        , ErrorMessage = "Karakterlere izin verilmiyor.")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Bu alan boş geçilemez.")
        , Display(Name = "Kullanıcı Soyisim")
        , StringLength(25, ErrorMessage = "Bu alan {1} ve {3}  karakter arası oluşmalıdır.")
        , MaxLength(25, ErrorMessage = "En fazla {1} harften oluşmalıdır.")
        , MinLength(2, ErrorMessage = "En az {1} harften oluşmalıdır.")
        , RegularExpression(@"^[a-zA-Z''-'\s]{2,25}$"
        , ErrorMessage = "Karakterlere izin verilmiyor.")]
        public string UserSurname { get; set; }


        [Display(Name = "Kullanıcı Kayıt Tarihi")
        , Column(TypeName = "smalldatetime")]
        public DateTime UserCreateDate { get; set; }


        [Required(ErrorMessage = "Bu alan boş geçilemez.")
        , Display(Name = "Kullanıcı Email")
        , StringLength(50, ErrorMessage = "Bu alan {1} ve {3}  karakter arası oluşmalıdır.")
        , MaxLength(50, ErrorMessage = "En fazla {1} harften oluşmalıdır.")
        , MinLength(12, ErrorMessage = "En az {1} harften oluşmalıdır.")
        , RegularExpression(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$"
        , ErrorMessage = "Karakterlere izin verilmiyor.")]
        public string UserEmail { get; set; }

        public Boolean State { get; set; }


        public virtual tbl_user tbl_user { get; set; }
    }
}
