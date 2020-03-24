namespace FullMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using FullMVC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FullMVC.Models.StoryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FullMVC.Models.StoryContext";
        }

        protected override void Seed(FullMVC.Models.StoryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var authors = new List<Author>
{
new Author {AuthorId = 1, FirstName="Lego", SurName="Master", StoryId=1},
new Author {AuthorId = 2, FirstName="Jack", SurName="Austin", StoryId=1}

};
            //authors.ForEach(author => context.Author.AddOrUpdate(p => p.AuthorId, author));
            authors.ForEach(author => context.Authors.AddOrUpdate(p => p.AuthorId, author));
            context.SaveChanges();

            Story story = new Story 
            {
                StoryId = 1,
                Authors = new List<Author>
                {
                    new Author{AuthorId=1, FirstName="Jack", SurName="Cullin"},
                    new Author{AuthorId=2, FirstName="Mark", SurName="Spencer"}
                },
                Categories = new List<Category>
                {
                    new Category{CategoryId=1, Name="Relax"},
                    new Category{CategoryId=2, Name="Time Space"}
                }
            };
        }
    }
}
