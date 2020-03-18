namespace Blog.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_article",
                c => new
                    {
                        ArticleID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Byte(nullable: false),
                        UserID = c.Int(nullable: false),
                        ArticleTitle = c.String(nullable: false),
                        ArticleContent = c.String(nullable: false),
                        ArticleCreateDate = c.DateTime(nullable: false),
                        ArticleViews = c.Int(nullable: false),
                        ArticleLike = c.Int(nullable: false),
                        State = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleID)
                .ForeignKey("dbo.tbl_category", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_user", t => t.UserID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.tbl_articleTags",
                c => new
                    {
                        ArticleTagsID = c.Int(nullable: false, identity: true),
                        ArticleID = c.Int(nullable: false),
                        TagID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleTagsID)
                .ForeignKey("dbo.tbl_article", t => t.ArticleID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.ArticleID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.tbl_tags",
                c => new
                    {
                        TagID = c.Byte(nullable: false, identity: true),
                        TagName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TagID);
            
            CreateTable(
                "dbo.tbl_category",
                c => new
                    {
                        CategoryID = c.Byte(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.tbl_comment",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        ArticleID = c.Int(nullable: false),
                        CommentCreateDate = c.DateTime(nullable: false),
                        CommentName = c.String(nullable: false, maxLength: 25),
                        CommentSurname = c.String(nullable: false, maxLength: 25),
                        CommentEmail = c.String(nullable: false, maxLength: 25),
                        CommentLike = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.tbl_article", t => t.ArticleID, cascadeDelete: true)
                .Index(t => t.ArticleID);
            
            CreateTable(
                "dbo.tbl_images",
                c => new
                    {
                        ArticleID = c.Int(nullable: false),
                        ImagesSmall = c.String(nullable: false, maxLength: 20),
                        ImagesMiddle = c.String(nullable: false, maxLength: 20),
                        ImagesBig = c.String(nullable: false, maxLength: 20),
                        ImagesVideo = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ArticleID)
                .ForeignKey("dbo.tbl_article", t => t.ArticleID)
                .Index(t => t.ArticleID);
            
            CreateTable(
                "dbo.tbl_user",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserGroupID = c.Byte(nullable: false),
                        Username = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.tbl_userGroup", t => t.UserGroupID, cascadeDelete: true)
                .Index(t => t.UserGroupID);
            
            CreateTable(
                "dbo.tbl_userGroup",
                c => new
                    {
                        UserGroupID = c.Byte(nullable: false, identity: true),
                        UserGroupName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.UserGroupID);
            
            CreateTable(
                "dbo.tbl_userInfo",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 25),
                        UserSurname = c.String(nullable: false, maxLength: 25),
                        UserCreateDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        UserEmail = c.String(nullable: false, maxLength: 50),
                        State = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.tbl_user", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.tbl_userLog",
                c => new
                    {
                        UserLogID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UserLogDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.UserLogID)
                .ForeignKey("dbo.tbl_user", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.tbl_userPassword",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserPassword = c.String(nullable: false, maxLength: 16),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.tbl_user", t => t.UserID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_userPassword", "UserID", "dbo.tbl_user");
            DropForeignKey("dbo.tbl_userLog", "UserID", "dbo.tbl_user");
            DropForeignKey("dbo.tbl_userInfo", "UserID", "dbo.tbl_user");
            DropForeignKey("dbo.tbl_user", "UserGroupID", "dbo.tbl_userGroup");
            DropForeignKey("dbo.tbl_article", "UserID", "dbo.tbl_user");
            DropForeignKey("dbo.tbl_images", "ArticleID", "dbo.tbl_article");
            DropForeignKey("dbo.tbl_comment", "ArticleID", "dbo.tbl_article");
            DropForeignKey("dbo.tbl_article", "CategoryID", "dbo.tbl_category");
            DropForeignKey("dbo.tbl_articleTags", "TagID", "dbo.tbl_tags");
            DropForeignKey("dbo.tbl_articleTags", "ArticleID", "dbo.tbl_article");
            DropIndex("dbo.tbl_userPassword", new[] { "UserID" });
            DropIndex("dbo.tbl_userLog", new[] { "UserID" });
            DropIndex("dbo.tbl_userInfo", new[] { "UserID" });
            DropIndex("dbo.tbl_user", new[] { "UserGroupID" });
            DropIndex("dbo.tbl_images", new[] { "ArticleID" });
            DropIndex("dbo.tbl_comment", new[] { "ArticleID" });
            DropIndex("dbo.tbl_articleTags", new[] { "TagID" });
            DropIndex("dbo.tbl_articleTags", new[] { "ArticleID" });
            DropIndex("dbo.tbl_article", new[] { "UserID" });
            DropIndex("dbo.tbl_article", new[] { "CategoryID" });
            DropTable("dbo.tbl_userPassword");
            DropTable("dbo.tbl_userLog");
            DropTable("dbo.tbl_userInfo");
            DropTable("dbo.tbl_userGroup");
            DropTable("dbo.tbl_user");
            DropTable("dbo.tbl_images");
            DropTable("dbo.tbl_comment");
            DropTable("dbo.tbl_category");
            DropTable("dbo.tbl_tags");
            DropTable("dbo.tbl_articleTags");
            DropTable("dbo.tbl_article");
        }
    }
}
