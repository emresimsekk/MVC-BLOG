namespace Blog.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _190220208 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tbl_userRole", "UserGroupID", "dbo.tbl_userGroup");
            DropIndex("dbo.tbl_userRole", new[] { "UserGroupID" });
            DropPrimaryKey("dbo.tbl_userRole");
            DropPrimaryKey("dbo.tbl_userGroup");
            AlterColumn("dbo.tbl_userRole", "UserGroupID", c => c.Int(nullable: false));
            AlterColumn("dbo.tbl_userGroup", "UserGroupID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.tbl_userRole", new[] { "UserID", "UserGroupID" });
            AddPrimaryKey("dbo.tbl_userGroup", "UserGroupID");
            CreateIndex("dbo.tbl_userRole", "UserGroupID");
            AddForeignKey("dbo.tbl_userRole", "UserGroupID", "dbo.tbl_userGroup", "UserGroupID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_userRole", "UserGroupID", "dbo.tbl_userGroup");
            DropIndex("dbo.tbl_userRole", new[] { "UserGroupID" });
            DropPrimaryKey("dbo.tbl_userGroup");
            DropPrimaryKey("dbo.tbl_userRole");
            AlterColumn("dbo.tbl_userGroup", "UserGroupID", c => c.Byte(nullable: false, identity: true));
            AlterColumn("dbo.tbl_userRole", "UserGroupID", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.tbl_userGroup", "UserGroupID");
            AddPrimaryKey("dbo.tbl_userRole", new[] { "UserID", "UserGroupID" });
            CreateIndex("dbo.tbl_userRole", "UserGroupID");
            AddForeignKey("dbo.tbl_userRole", "UserGroupID", "dbo.tbl_userGroup", "UserGroupID", cascadeDelete: true);
        }
    }
}
