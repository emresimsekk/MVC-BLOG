namespace Blog.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _190220204 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tbl_userGroup", "tbl_userRole_UserRoleID", "dbo.tbl_userRole");
            DropIndex("dbo.tbl_userGroup", new[] { "tbl_userRole_UserRoleID" });
            CreateIndex("dbo.tbl_userRole", "UserGroupID");
            AddForeignKey("dbo.tbl_userRole", "UserGroupID", "dbo.tbl_userGroup", "UserGroupID", cascadeDelete: true);
            DropColumn("dbo.tbl_userGroup", "tbl_userRole_UserRoleID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_userGroup", "tbl_userRole_UserRoleID", c => c.Int());
            DropForeignKey("dbo.tbl_userRole", "UserGroupID", "dbo.tbl_userGroup");
            DropIndex("dbo.tbl_userRole", new[] { "UserGroupID" });
            CreateIndex("dbo.tbl_userGroup", "tbl_userRole_UserRoleID");
            AddForeignKey("dbo.tbl_userGroup", "tbl_userRole_UserRoleID", "dbo.tbl_userRole", "UserRoleID");
        }
    }
}
