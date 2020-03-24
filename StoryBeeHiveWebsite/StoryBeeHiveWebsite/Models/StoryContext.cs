using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StoryBeeHiveWebsite.Models
{
    public class StoryContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public StoryContext() : base("name=StoryContext")
        {
        }

        public System.Data.Entity.DbSet<StoryBeeHiveWebsite.Models.Story> Stories { get; set; }

        public System.Data.Entity.DbSet<StoryBeeHiveWebsite.Models.Author> Authors { get; set; }

        public System.Data.Entity.DbSet<StoryBeeHiveWebsite.Models.Category> Categories { get; set; }
        public System.Data.Entity.DbSet<StoryBeeHiveWebsite.Models.Comment> Comments { get; set; }
    }
}
