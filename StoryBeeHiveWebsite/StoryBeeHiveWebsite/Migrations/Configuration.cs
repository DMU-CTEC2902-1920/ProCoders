namespace StoryBeeHiveWebsite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using StoryBeeHiveWebsite.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<StoryBeeHiveWebsite.Models.StoryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "StoryBeeHiveWebsite.Models.StoryContext";
        }

        protected override void Seed(StoryBeeHiveWebsite.Models.StoryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var authors = new List<Author>
            {
                new Author{AuthorId=1, FirstName="Jakeer", LastName="Gulati"},
                new Author{AuthorId=2, FirstName="Hugo", LastName="Austin"},
                new Author{AuthorId=3, FirstName="Qin", LastName="Juang"}
            };

            authors.ForEach(author => context.Authors.AddOrUpdate(p => p.AuthorId, author));
            context.SaveChanges();

            var categories = new List<Category>
            {
                new Category{CategoryId=1, Name="Horror"},
                new Category{CategoryId=2, Name="Sci-Fi"},
                new Category{CategoryId=3, Name="Comedy"}
            };

            categories.ForEach(category => context.Categories.AddOrUpdate(p => p.CategoryId, category));
            context.SaveChanges();
        }
    }
}
