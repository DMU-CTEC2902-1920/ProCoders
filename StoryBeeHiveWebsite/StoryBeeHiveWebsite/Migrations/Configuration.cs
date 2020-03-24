namespace StoryBeeHiveWebsite.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StoryBeeHiveWebsite.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<StoryBeeHiveWebsite.Models.StoryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
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

            var comments = new List<Comment>
            {
                new Comment{CommentId=1, Description="Very good story well done", StoryId=5},
                new Comment{CommentId=2, Description="I would have preferred a much simpler story", StoryId=5},
                new Comment{CommentId=3, Description="Life is relaxing while reading this story", StoryId=5}
            };

            comments.ForEach(comment => context.Comments.AddOrUpdate(p => p.CommentId, comment));
            context.SaveChanges();
        }
    }
}
