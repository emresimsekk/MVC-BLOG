namespace Blog.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _190220201 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tbl_user", "tbl_userGroup_UserGroupID", "dbo.tbl_userGroup");
            DropIndex("dbo.tbl_user", new[] { "tbl_userGroup_UserGroupID" });
            DropColumn("dbo.tbl_user", "tbl_userGroup_UserGroupID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_user", "tbl_userGroup_UserGroupID", c => c.Byte());
            CreateIndex("dbo.tbl_user", "tbl_userGroup_UserGroupID");
            AddForeignKey("dbo.tbl_user", "tbl_userGroup_UserGroupID", "dbo.tbl_userGroup", "UserGroupID");
        }
    }
}
