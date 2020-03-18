using Blog.Entity.Models;
using System.Data.Entity;

namespace Blog.Dal
{
    public class DatabaseContext : DbContext
    {
        public DbSet<tbl_article> _Articles { get; set; }

        public DbSet<tbl_category> _Categories { get; set; }

        public DbSet<tbl_comment> _Comments { get; set; }

        public DbSet<tbl_images> _Images { get; set; }

        public DbSet<tbl_user> _Users { get; set; }

        public DbSet<tbl_userGroup> _UserGroups { get; set; }

        public DbSet<tbl_userInfo> _UserInfos { get; set; }

        public DbSet<tbl_userLog> _UserLogs { get; set; }

        public DbSet<tbl_userRole> tbl_userRoles { get; set; }


    }
}
