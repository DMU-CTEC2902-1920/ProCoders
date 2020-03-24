namespace FullMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryAuthor : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Authors", "StoryId", "dbo.Stories");
            DropIndex("dbo.Authors", new[] { "StoryId" });
            AddColumn("dbo.Stories", "Author_AuthorId", c => c.Int());
            AddColumn("dbo.Stories", "Category_CategoryId", c => c.Int());
            AddColumn("dbo.Authors", "Story_StoryId", c => c.Int());
            CreateIndex("dbo.Stories", "Author_AuthorId");
            CreateIndex("dbo.Stories", "Category_CategoryId");
            CreateIndex("dbo.Authors", "Story_StoryId");
            AddForeignKey("dbo.Stories", "Author_AuthorId", "dbo.Authors", "AuthorId");
            AddForeignKey("dbo.Stories", "Category_CategoryId", "dbo.Categories", "CategoryId");
            AddForeignKey("dbo.Authors", "Story_StoryId", "dbo.Stories", "StoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Authors", "Story_StoryId", "dbo.Stories");
            DropForeignKey("dbo.Stories", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Stories", "Author_AuthorId", "dbo.Authors");
            DropIndex("dbo.Authors", new[] { "Story_StoryId" });
            DropIndex("dbo.Stories", new[] { "Category_CategoryId" });
            DropIndex("dbo.Stories", new[] { "Author_AuthorId" });
            DropColumn("dbo.Authors", "Story_StoryId");
            DropColumn("dbo.Stories", "Category_CategoryId");
            DropColumn("dbo.Stories", "Author_AuthorId");
            CreateIndex("dbo.Authors", "StoryId");
            AddForeignKey("dbo.Authors", "StoryId", "dbo.Stories", "StoryId", cascadeDelete: true);
        }
    }
}
