namespace Blog.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _190220206 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.tbl_userRole");
            AlterColumn("dbo.tbl_userRole", "UserRoleID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.tbl_userRole", new[] { "UserID", "UserGroupID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.tbl_userRole");
            AlterColumn("dbo.tbl_userRole", "UserRoleID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.tbl_userRole", "UserRoleID");
        }
    }
}
