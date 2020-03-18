namespace Blog.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _19022020 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tbl_userRoletbl_userGroup", "tbl_userRole_UserRoleID", "dbo.userRole");
            DropForeignKey("dbo.tbl_userRoletbl_userGroup", "tbl_userGroup_UserGroupID", "dbo.tbl_userGroup");
            DropForeignKey("dbo.tbl_user", "tbl_userRole_UserRoleID", "dbo.userRole");
            DropIndex("dbo.tbl_user", new[] { "tbl_userRole_UserRoleID" });
            DropIndex("dbo.tbl_userRoletbl_userGroup", new[] { "tbl_userRole_UserRoleID" });
            DropIndex("dbo.tbl_userRoletbl_userGroup", new[] { "tbl_userGroup_UserGroupID" });
            DropColumn("dbo.tbl_user", "tbl_userRole_UserRoleID");
            DropTable("dbo.userRole");
            DropTable("dbo.tbl_userRoletbl_userGroup");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tbl_userRoletbl_userGroup",
                c => new
                    {
                        tbl_userRole_UserRoleID = c.Int(nullable: false),
                        tbl_userGroup_UserGroupID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => new { t.tbl_userRole_UserRoleID, t.tbl_userGroup_UserGroupID });
            
            CreateTable(
                "dbo.userRole",
                c => new
                    {
                        UserRoleID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UserGroupID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.UserRoleID);
            
            AddColumn("dbo.tbl_user", "tbl_userRole_UserRoleID", c => c.Int());
            CreateIndex("dbo.tbl_userRoletbl_userGroup", "tbl_userGroup_UserGroupID");
            CreateIndex("dbo.tbl_userRoletbl_userGroup", "tbl_userRole_UserRoleID");
            CreateIndex("dbo.tbl_user", "tbl_userRole_UserRoleID");
            AddForeignKey("dbo.tbl_user", "tbl_userRole_UserRoleID", "dbo.userRole", "UserRoleID");
            AddForeignKey("dbo.tbl_userRoletbl_userGroup", "tbl_userGroup_UserGroupID", "dbo.tbl_userGroup", "UserGroupID", cascadeDelete: true);
            AddForeignKey("dbo.tbl_userRoletbl_userGroup", "tbl_userRole_UserRoleID", "dbo.userRole", "UserRoleID", cascadeDelete: true);
        }
    }
}
