namespace StoryBeeHiveWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedStoryModel : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "StoryId", "dbo.Stories");
            DropIndex("dbo.Comments", new[] { "StoryId" });
            DropTable("dbo.Comments");
        }
    }
}
