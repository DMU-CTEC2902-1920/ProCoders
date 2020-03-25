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

            var stories = new List<Story>
            {
                new Story{StoryId=1, CategoryId=1, AuthorId=1, Title="Jumanji", Description="Jumanji is a 1995 American fantasy adventure film directed by Joe Johnston. It's a loose adaptation of the 1981 children's book of the same name by Chris Van Allsburg and the first installment of the Jumanji franchise. The film was written by Van Allsburg, Greg Taylor, Jonathan Hensleigh, and Jim Strain and stars Robin Williams, Kirsten Dunst, David Alan Grier, Bonnie Hunt, Bradley Pierce, Jonathan Hyde, and Bebe Neuwirth.The story centers on a supernatural board game that releases jungle-based hazards upon its players with every turn they take. As a boy in 1969, Alan Parrish became trapped inside the game itself while playing with his best friend Sarah Whittle. Twenty - six years later, siblings Judy and Peter Shepherd find the game, begin playing and then unwittingly release the now-adult Alan.After tracking down Sarah, the quartet resolves to finish the game in order to reverse all of the destruction it has caused and return back to normal."},
                new Story{StoryId=2, CategoryId=2, AuthorId=2, Title="Folk metal", Description="Folk metal is a fusion genre of heavy metal music and traditional folk music that developed in Europe during the 1990s. It is characterised by the widespread use of folk instruments and, to a lesser extent, traditional singing styles (for example, Dutch Heidevolk, Danish Sylvatica and Spanish Stone of Erech). It also sometimes features soft instrumentation influenced by folk rock.The earliest folk metal bands were Skyclad from England and Cruachan from Ireland. Skyclad's debut album The Wayward Sons of Mother Earth was released in 1991 and would be considered a thrash metal album with some folk influences, unlike Cruachan’s early work which embraced the folk element as a defining part of their sound. It was not until 1994 and 1995 that other early contributors in the genre began to emerge from different regions of Europe and beyond. Among these early groups, the German band Subway to Sally spearheaded a different regional variation that over time became known as medieval metal. Despite their contributions, folk metal remained little known with few representatives during the 1990s. It was not until the early 2000s when the genre exploded into prominence, particularly in Finland with the efforts of such groups as Finntroll, Ensiferum, Korpiklaani, Turisas, and Moonsorrow."},
                new Story{StoryId=3, CategoryId=3, AuthorId=3, Title="Death-Doom", Description="The first signs of the death/doom genre originated in the mid-1980s when early progenitors like Dream Death began to mix traditional doom metal with the sounds of the nascent death metal scene.[4] Early records in 1990s by such bands as Autopsy, Winter, Paradise Lost, My Dying Bride and Anathema combined the doom sound of mid-1980s Celtic Frost and Candlemass with the use of growling vocals, female vocals,[5] keyboards and, in the case of My Dying Bride, violins. The influence of these bands has been acknowledged by the likes of gothic metal bands Within Temptation, Lacuna Coil, The Gathering, Celestial Season and Saturnus.[2][6] The tag of death/doom seemed to become less popular towards the end of the decade as many of the scene progenitors abandoned their early sound to embrace a more accessible or palatable direction.[2]"}
            };

            stories.ForEach(story => context.Stories.AddOrUpdate(p => p.StoryId, story));
            context.SaveChanges();

            var comments = new List<Comment>
            {
                new Comment{CommentId=1, Description="Very good story well done", StoryId=1},
                new Comment{CommentId=2, Description="I would have preferred a much simpler story", StoryId=1},
                new Comment{CommentId=3, Description="Life is relaxing while reading this story", StoryId=1}
            };

            comments.ForEach(comment => context.Comments.AddOrUpdate(p => p.CommentId, comment));
            context.SaveChanges();
        }
    }
}
