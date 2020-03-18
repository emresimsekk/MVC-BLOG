namespace Blog.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _190220203 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_userGroup", "tbl_userRole_UserRoleID", c => c.Int());
            CreateIndex("dbo.tbl_userGroup", "tbl_userRole_UserRoleID");
            AddForeignKey("dbo.tbl_userGroup", "tbl_userRole_UserRoleID", "dbo.tbl_userRole", "UserRoleID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_userGroup", "tbl_userRole_UserRoleID", "dbo.tbl_userRole");
            DropIndex("dbo.tbl_userGroup", new[] { "tbl_userRole_UserRoleID" });
            DropColumn("dbo.tbl_userGroup", "tbl_userRole_UserRoleID");
        }
    }
}
