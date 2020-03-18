namespace Blog.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _190220202 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_userRole",
                c => new
                    {
                        UserRoleID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UserGroupID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.UserRoleID)
                .ForeignKey("dbo.tbl_user", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_userRole", "UserID", "dbo.tbl_user");
            DropIndex("dbo.tbl_userRole", new[] { "UserID" });
            DropTable("dbo.tbl_userRole");
        }
    }
}
