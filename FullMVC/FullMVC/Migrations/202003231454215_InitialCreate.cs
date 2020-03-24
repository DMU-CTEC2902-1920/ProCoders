namespace FullMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stories",
                c => new
                    {
                        StoryId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.StoryId);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        SurName = c.String(),
                        Story_StoryId = c.Int(),
                    })
                .PrimaryKey(t => t.AuthorId)
                .ForeignKey("dbo.Stories", t => t.Story_StoryId)
                .Index(t => t.Story_StoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Story_StoryId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.Stories", t => t.Story_StoryId)
                .Index(t => t.Story_StoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Story_StoryId", "dbo.Stories");
            DropForeignKey("dbo.Authors", "Story_StoryId", "dbo.Stories");
            DropIndex("dbo.Categories", new[] { "Story_StoryId" });
            DropIndex("dbo.Authors", new[] { "Story_StoryId" });
            DropTable("dbo.Categories");
            DropTable("dbo.Authors");
            DropTable("dbo.Stories");
        }
    }
}
