namespace Blog.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tbl_userPassword", "UserID", "dbo.tbl_user");
            DropIndex("dbo.tbl_userPassword", new[] { "UserID" });
            AddColumn("dbo.tbl_user", "UserPassword", c => c.String(nullable: false, maxLength: 16));
            DropTable("dbo.tbl_userPassword");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tbl_userPassword",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserPassword = c.String(nullable: false, maxLength: 16),
                    })
                .PrimaryKey(t => t.UserID);
            
            DropColumn("dbo.tbl_user", "UserPassword");
            CreateIndex("dbo.tbl_userPassword", "UserID");
            AddForeignKey("dbo.tbl_userPassword", "UserID", "dbo.tbl_user", "UserID");
        }
    }
}
