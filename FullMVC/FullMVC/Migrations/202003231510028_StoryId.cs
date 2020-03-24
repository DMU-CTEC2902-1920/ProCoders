namespace FullMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StoryId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Authors", "Story_StoryId", "dbo.Stories");
            DropIndex("dbo.Authors", new[] { "Story_StoryId" });
            RenameColumn(table: "dbo.Authors", name: "Story_StoryId", newName: "StoryId");
            AlterColumn("dbo.Authors", "StoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Authors", "StoryId");
            AddForeignKey("dbo.Authors", "StoryId", "dbo.Stories", "StoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Authors", "StoryId", "dbo.Stories");
            DropIndex("dbo.Authors", new[] { "StoryId" });
            AlterColumn("dbo.Authors", "StoryId", c => c.Int());
            RenameColumn(table: "dbo.Authors", name: "StoryId", newName: "Story_StoryId");
            CreateIndex("dbo.Authors", "Story_StoryId");
            AddForeignKey("dbo.Authors", "Story_StoryId", "dbo.Stories", "StoryId");
        }
    }
}
