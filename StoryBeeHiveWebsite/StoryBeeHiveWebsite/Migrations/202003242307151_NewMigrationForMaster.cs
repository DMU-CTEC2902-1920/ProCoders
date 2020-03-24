namespace StoryBeeHiveWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigrationForMaster : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        StoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Stories", t => t.StoryId, cascadeDelete: true)
                .Index(t => t.StoryId);
            
            CreateTable(
                "dbo.Stories",
                c => new
                    {
                        StoryId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StoryId)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.AuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "StoryId", "dbo.Stories");
            DropForeignKey("dbo.Stories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Stories", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Stories", new[] { "AuthorId" });
            DropIndex("dbo.Stories", new[] { "CategoryId" });
            DropIndex("dbo.Comments", new[] { "StoryId" });
            DropTable("dbo.Stories");
            DropTable("dbo.Comments");
            DropTable("dbo.Categories");
            DropTable("dbo.Authors");
        }
    }
}
