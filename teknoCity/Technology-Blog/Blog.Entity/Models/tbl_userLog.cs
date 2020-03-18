using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Entity.Models
{
    [Table("tbl_userLog")]
    public class tbl_userLog
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)
        , Display(Name = "Kullanıcı Log ID")]
        public int UserLogID { get; set; }


        [Display(Name = "Kullanıcı ID")]
        public int UserID { get; set; }


        [Display(Name = "Kullanıcı Log Tarihi")
        , Column(TypeName = "smalldatetime")]
        public DateTime UserLogDate { get; set; }


        [ForeignKey("UserID")]
        public virtual tbl_user tbl_user { get; set; }


    }
}
