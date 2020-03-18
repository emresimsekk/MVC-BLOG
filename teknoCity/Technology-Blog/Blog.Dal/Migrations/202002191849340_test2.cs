namespace Blog.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tbl_user", "UserGroupID", "dbo.tbl_userGroup");
            DropIndex("dbo.tbl_user", new[] { "UserGroupID" });
            RenameColumn(table: "dbo.tbl_user", name: "UserGroupID", newName: "tbl_userGroup_UserGroupID");
            CreateTable(
                "dbo.userRole",
                c => new
                    {
                        UserRoleID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UserGroupID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.UserRoleID);
            
            CreateTable(
                "dbo.tbl_userRoletbl_userGroup",
                c => new
                    {
                        tbl_userRole_UserRoleID = c.Int(nullable: false),
                        tbl_userGroup_UserGroupID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => new { t.tbl_userRole_UserRoleID, t.tbl_userGroup_UserGroupID })
                .ForeignKey("dbo.userRole", t => t.tbl_userRole_UserRoleID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_userGroup", t => t.tbl_userGroup_UserGroupID, cascadeDelete: true)
                .Index(t => t.tbl_userRole_UserRoleID)
                .Index(t => t.tbl_userGroup_UserGroupID);
            
            AddColumn("dbo.tbl_user", "tbl_userRole_UserRoleID", c => c.Int());
            AlterColumn("dbo.tbl_user", "tbl_userGroup_UserGroupID", c => c.Byte());
            CreateIndex("dbo.tbl_user", "tbl_userRole_UserRoleID");
            CreateIndex("dbo.tbl_user", "tbl_userGroup_UserGroupID");
            AddForeignKey("dbo.tbl_user", "tbl_userRole_UserRoleID", "dbo.userRole", "UserRoleID");
            AddForeignKey("dbo.tbl_user", "tbl_userGroup_UserGroupID", "dbo.tbl_userGroup", "UserGroupID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_user", "tbl_userGroup_UserGroupID", "dbo.tbl_userGroup");
            DropForeignKey("dbo.tbl_user", "tbl_userRole_UserRoleID", "dbo.userRole");
            DropForeignKey("dbo.tbl_userRoletbl_userGroup", "tbl_userGroup_UserGroupID", "dbo.tbl_userGroup");
            DropForeignKey("dbo.tbl_userRoletbl_userGroup", "tbl_userRole_UserRoleID", "dbo.userRole");
            DropIndex("dbo.tbl_userRoletbl_userGroup", new[] { "tbl_userGroup_UserGroupID" });
            DropIndex("dbo.tbl_userRoletbl_userGroup", new[] { "tbl_userRole_UserRoleID" });
            DropIndex("dbo.tbl_user", new[] { "tbl_userGroup_UserGroupID" });
            DropIndex("dbo.tbl_user", new[] { "tbl_userRole_UserRoleID" });
            AlterColumn("dbo.tbl_user", "tbl_userGroup_UserGroupID", c => c.Byte(nullable: false));
            DropColumn("dbo.tbl_user", "tbl_userRole_UserRoleID");
            DropTable("dbo.tbl_userRoletbl_userGroup");
            DropTable("dbo.userRole");
            RenameColumn(table: "dbo.tbl_user", name: "tbl_userGroup_UserGroupID", newName: "UserGroupID");
            CreateIndex("dbo.tbl_user", "UserGroupID");
            AddForeignKey("dbo.tbl_user", "UserGroupID", "dbo.tbl_userGroup", "UserGroupID", cascadeDelete: true);
        }
    }
}
