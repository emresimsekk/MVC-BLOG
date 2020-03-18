using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Models
{
    [Table("tbl_userRole")]
    public class tbl_userRole
    {
       
        public int UserRoleID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int UserGroupID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int UserID { get; set; }
       

    

      
    }
}
