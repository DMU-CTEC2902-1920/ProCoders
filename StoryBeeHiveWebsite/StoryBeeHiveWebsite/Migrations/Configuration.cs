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
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StoryBeeHiveWebsite.Models.StoryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var authors = new List<Author>
            {
                new Author{AuthorId=1, FirstName="Jakeer", LastName="Gulati", About="I am a active guy. I like to write stories on my free time. My job is to teach as a English Techer in DMU.", Hobbies="Reading books, Playing Sports."},
                new Author{AuthorId=2, FirstName="Hugo", LastName="Austin", About="Trusting people has been an issue for me. It is not always easy for me to make friends but if I do trust someone I am really attached with them", Hobbies="Hunting, Hiking, Playing games"},
                new Author{AuthorId=3, FirstName="Qin", LastName="Juang", About="My main interest is to design architecture. My target is to build an architect to be favoured by all", Hobbies="Fishing, Playing soccer, Boxing"},
                new Author{AuthorId=4, FirstName="Guy", LastName="Gunaratne", About="I like to receive and deal with challenging tasks. I am a very enthusiastic student and I think this is a strong point of mine. My friends say that I am a very funny and an interesting girl with a good sense of humor. As soon as I meet new people who are happy to meet me, I feel extremely comfortable with them.", Hobbies="Eating, Playing games, Gardening"},
                new Author{AuthorId=5, FirstName="David", LastName="Chariandy", About="David Chariandy is a Canadian writer. His parents immigrated to Canada from Trinidad in the 1960s. He was born in Scarborough, Ontario. Chariandy has a MA from Carleton and a PhD from York University. He lives in Vancouver and teaches in the department of English at Simon Fraser University.", Hobbies="Marketing, Chess, Cooking, Coin collecting"},
                new Author{AuthorId=6, FirstName="Eley", LastName="Williams", About="Eley Williams is a British writer. Her debut collection of prose, Attrib. and Other Stories (Influx Press, 2017), was awarded the Republic of Consciousness Prize", Hobbies="Football, Hiking, Drawing"},
                new Author{AuthorId=7, FirstName="Mark", LastName="O'Connell", About="Mark O'Connell is a writer based in Dublin. His book, To Be a Machine: Encounters With a Post-Human Future, will be published by Granta (UK & Commonwealth) and Doubleday (US & Canada) in 2017.", Hobbies="Singing, Cooking, Baseball"}
                
            };



            authors.ForEach(author => context.Authors.AddOrUpdate(p => p.AuthorId, author));
            context.SaveChanges();

            var categories = new List<Category>
            {
                new Category{CategoryId=1, Name="Horror"},
                new Category{CategoryId=2, Name="Sci-Fi"},
                new Category{CategoryId=3, Name="Comedy"},
                new Category{CategoryId=4, Name="Science"},
                new Category{CategoryId=5, Name="Technology"},
                new Category{CategoryId=6, Name="Business"},
                new Category{CategoryId=7, Name="Food"},
                new Category{CategoryId=8, Name="Culture"}
            };

            categories.ForEach(category => context.Categories.AddOrUpdate(p => p.CategoryId, category));
            context.SaveChanges();

            var stories = new List<Story>
            {
                new Story{StoryId=1, CategoryId=1, AuthorId=1, Title="Jumanji", Description="Jumanji is a 1995 American fantasy adventure film directed by Joe Johnston. It's a loose adaptation of the 1981 children's book of the same name by Chris Van Allsburg and the first installment of the Jumanji franchise. The film was written by Van Allsburg, Greg Taylor, Jonathan Hensleigh, and Jim Strain and stars Robin Williams, Kirsten Dunst, David Alan Grier, Bonnie Hunt, Bradley Pierce, Jonathan Hyde, and Bebe Neuwirth.The story centers on a supernatural board game that releases jungle-based hazards upon its players with every turn they take. As a boy in 1969, Alan Parrish became trapped inside the game itself while playing with his best friend Sarah Whittle. Twenty - six years later, siblings Judy and Peter Shepherd find the game, begin playing and then unwittingly release the now-adult Alan.After tracking down Sarah, the quartet resolves to finish the game in order to reverse all of the destruction it has caused and return back to normal."},
                new Story{StoryId=2, CategoryId=2, AuthorId=2, Title="Folk metal", Description="Folk metal is a fusion genre of heavy metal music and traditional folk music that developed in Europe during the 1990s. It is characterised by the widespread use of folk instruments and, to a lesser extent, traditional singing styles (for example, Dutch Heidevolk, Danish Sylvatica and Spanish Stone of Erech). It also sometimes features soft instrumentation influenced by folk rock.The earliest folk metal bands were Skyclad from England and Cruachan from Ireland. Skyclad's debut album The Wayward Sons of Mother Earth was released in 1991 and would be considered a thrash metal album with some folk influences, unlike Cruachan’s early work which embraced the folk element as a defining part of their sound. It was not until 1994 and 1995 that other early contributors in the genre began to emerge from different regions of Europe and beyond. Among these early groups, the German band Subway to Sally spearheaded a different regional variation that over time became known as medieval metal. Despite their contributions, folk metal remained little known with few representatives during the 1990s. It was not until the early 2000s when the genre exploded into prominence, particularly in Finland with the efforts of such groups as Finntroll, Ensiferum, Korpiklaani, Turisas, and Moonsorrow."},
                new Story{StoryId=3, CategoryId=3, AuthorId=3, Title="Death-Doom", Description="The first signs of the death/doom genre originated in the mid-1980s when early progenitors like Dream Death began to mix traditional doom metal with the sounds of the nascent death metal scene.[4] Early records in 1990s by such bands as Autopsy, Winter, Paradise Lost, My Dying Bride and Anathema combined the doom sound of mid-1980s Celtic Frost and Candlemass with the use of growling vocals, female vocals,[5] keyboards and, in the case of My Dying Bride, violins. The influence of these bands has been acknowledged by the likes of gothic metal bands Within Temptation, Lacuna Coil, The Gathering, Celestial Season and Saturnus.[2][6] The tag of death/doom seemed to become less popular towards the end of the decade as many of the scene progenitors abandoned their early sound to embrace a more accessible or palatable direction.[2]"},
                new Story{StoryId=4, CategoryId=4, AuthorId=4, Title="Forest Walk", Description="A forest is a large area dominated by trees.[1] Hundreds of more precise definitions of forest are used throughout the world, incorporating factors such as tree density, tree height, land use, legal standing and ecological function.[2][3][4] According to the widely used[5][6] Food and Agriculture Organization definition, forests covered 4 billion hectares (9.9×109 acres) (15 million square miles) or approximately 30 percent of the world's land area in 2006.[4]Forests are the dominant terrestrial ecosystem of Earth, and are distributed around the globe.[7] Forests account for 75 % of the gross primary production of the Earth's biosphere, and contain 80% of the Earth's plant biomass.Net primary production is estimated at 21.9 gigatonnes carbon per year for tropical forests, 8.1 for temperate forests, and 2.6 for boreal forests.[7]"},
                new Story{StoryId=5, CategoryId=5, AuthorId=5, Title="Sunshine", Description="Sunlight is a portion of the electromagnetic radiation given off by the Sun, in particular infrared, visible, and ultraviolet light. On Earth, sunlight is filtered through Earth's atmosphere, and is obvious as daylight when the Sun is above the horizon. When the direct solar radiation is not blocked by clouds, it is experienced as sunshine, a combination of bright light and radiant heat. When it is blocked by clouds or reflects off other objects, it is experienced as diffused light. The World Meteorological Organization uses the term sunshine duration to mean the cumulative time during which an area receives direct irradiance from the Sun of at least 120 watts per square meter.[1] Other sources indicate an Average over the entire earth of 164 Watts per square meter over a 24 hour day"},
                new Story{StoryId=6, CategoryId=6, AuthorId=6, Title="Doctor Pepper", Description="The name Dr. Pepper was first used commercially in 1885.[2] It was introduced nationally in the United States at the 1904 Louisiana Purchase Exposition as a new kind of soda pop, made with 23 flavors. Its introduction in 1885 preceded the introduction of Coca-Cola by one year. It was formulated by Brooklyn-born pharmacist Charles Alderton in Morrison's Old Corner Drug Store in Waco, Texas.[1] To test his new drink, he first offered it to store owner Wade Morrison, who also found it to his liking. Patrons at Morrison's soda fountain soon learned of Alderton's new drink and began ordering a 'Waco'.[3] Alderton gave the formula to Morrison, who named it Dr. Pepper (later stylized as Dr Pepper).Early advertisements for this soft drink made medical claims, stating that it aids digestion and restores vim, vigor, and vitality."},
                new Story{StoryId=7, CategoryId=7, AuthorId=7, Title="Chilli Garden", Description="Capsicum fruits have been a part of human diets since about 7,500 BC, and are one of the oldest cultivated crops in the Americas,[8] as origins of cultivating chili peppers are traced to northeastern Mexico some 6,000 years ago.[9][10] They were one of the first self-pollinating crops cultivated in Mexico, Central America, and parts of South America.[8] Peru is considered the country with the highest cultivated Capsicum diversity because it is a center of diversification where varieties of all five domesticates were introduced, grown, and consumed in pre-Columbian times.[11] Bolivia is considered to be the country where the largest diversity of wild Capsicum peppers is consumed. Bolivian consumers distinguish two basic forms: ulupicas, species with small round fruits including C.eximium, C.cardenasii, C.eshbaughii, and C. caballeroi landraces; and arivivis with small elongated fruits including C. baccatum var. baccatum and C.chacoense varieties.[11]"},
                new Story{StoryId=8, CategoryId=8, AuthorId=5, Title="Love Between War", Description="Love and War is an anthology of fantasy stories published by TSR, Inc. in 1987. It was published under the Dragonlance brand name and is set in that brand's fictional world of Krynn. It is the ninth Dragonlance novel to be published, and the third book in the 'Dragonlance Tales' series, all three books of which are anthologies of stories set in the Dragonlance milieu. The other two books in this series are The Magic of Krynn and Kender, Gully Dwarves, and Gnomes. Unlike the Dragonlance novels published up until that point, the Tales books do not exclusively follow one group of characters, but instead range across the entire scope of the setting."},
                new Story{StoryId=9, CategoryId=4, AuthorId=6, Title="Two Bridges & Two Birds", Description="'Two Birds' is the twelfth episode of the American television police procedural fantasy drama Awake. The episode premiered on NBC on May 17, 2012. In the episode, Michael learns more about the truth of the accident. He tries to get evidence that Ed Hawkins (Kevin Weisman) tried to kill him, and finds out that Hawkins' commanding officer Carl Kessel (Mark Harelik) was also in on this setup. The story and concept of the episode was written by Evan Katz, with teleplay by Howard Gordon and Davey Holmes. It was directed by Milan Cheylov. 'Two Birds' was well received by critics, who praised its storylines. Commentators noted that the script was well written. Upon airing, 'Two Birds' obtained 2.1 million viewers in the United States and a 0.7 rating in the 18–49 demographic, according to Nielsen ratings."},
                new Story{StoryId=10, CategoryId=5, AuthorId=5, Title="Mystery of Life", Description="The Mystery of Life is the 77th album by country singer Johnny Cash, released in 1991, and his last for Mercury Records. The songs featured are culled from both recent sessions and from leftovers from Cash's first Mercury session in 1986 for the album Johnny Cash is Coming to Town. It includes new recordings of two songs already associated with him from his Sun and Columbia days, 'Hey Porter' and 'Wanted Man'. 'I'll Go Somewhere and Sing My Songs Again' is a duet with Tom T. Hall. The album's poor performance on the charts (it peaked at #70) and that of 'Goin' by the Book', the only single to chart (at #69), coupled with Cash's unsteady relationship with Mercury, ensured his departure from the label following the album's release. In 2003, the album was re-released with 'The Wanderer' from U2's 1993 Island Records album Zooropa as a bonus track. In 2006, 'I'm an Easy Rider' and 'Beans for Breakfast' were used in the soundtrack to the video game Scarface: The World Is Yours. According to Cash's 1997 biography, Mercury only pressed 500 copies of the album, biographer Robert Hilburn in Johnny Cash: The Life (2013) dismisses this as an exaggeration on Cash's part.[1] This was the final new studio album release to feature drummer W.S. 'Fluke' Holland, who had been a member of Cash's backing group and featured on almost all of his recordings since the 1950s, as Holland would not participate in the recording sessions for the Johnny Cash Country Christmas or the recordings made for American Recordings, though he would continue to perform with Cash in concert."}
            };

            stories.ForEach(story => context.Stories.AddOrUpdate(p => p.StoryId, story));
            context.SaveChanges();


            var comments = new List<Comment>
            {
                new Comment{CommentId=1, Description="Very good story well done", StoryId=1},
                new Comment{CommentId=2, Description="I would have preferred a much simpler story", StoryId=1},
                new Comment{CommentId=3, Description="It is really nice story", StoryId=1},
                new Comment{CommentId=4, Description="Story makes anyone happy, but this story makes me more happy", StoryId=2},
                new Comment{CommentId=5, Description="This story really nice", StoryId=2},
                new Comment{CommentId=6, Description="The Author most of the story is really meaningful", StoryId=3},
                new Comment{CommentId=7, Description="StoryHive always post the wonderful stories", StoryId=3},
                new Comment{CommentId=8, Description="People feel relax when read this story as like mine", StoryId=4},
                new Comment{CommentId=9, Description="Story is not meaning to read it, it also means to feel the story", StoryId=4},
                new Comment{CommentId=10, Description="People make more happy after read story", StoryId=4},
                new Comment{CommentId=11, Description="You feels better makes happy when read any Awsome story", StoryId=4},

                new Comment{CommentId=12, Description="This story really nice", StoryId=5},
                new Comment{CommentId=13, Description="Life is relaxing while reading this story", StoryId=5},
                new Comment{CommentId=14, Description="Story makes anyone happy, but this story makes me more happy", StoryId=6},
                new Comment{CommentId=15, Description="Life is relaxing while reading this story", StoryId=6},
                new Comment{CommentId=16, Description="StoryHive always post the wonderful stories", StoryId=7},
                new Comment{CommentId=17, Description="You feels better makes happy when read any Awsome story", StoryId=8},
                new Comment{CommentId=18, Description="Life is relaxing while reading this story", StoryId=9},
                new Comment{CommentId=19, Description="It is really nice story", StoryId=9},
                new Comment{CommentId=20, Description="People make more happy after read story", StoryId=9},
                new Comment{CommentId=21, Description="Life is relaxing while reading this story", StoryId=9},
                new Comment{CommentId=22, Description="Life is relaxing while reading this story", StoryId=10},
                new Comment{CommentId=23, Description="StoryHive always post the wonderful stories", StoryId=10},
                new Comment{CommentId=24, Description="Life is relaxing while reading this story", StoryId=10},
                new Comment{CommentId=25, Description="People make more happy after read story", StoryId=10},
                new Comment{CommentId=26, Description="The Author most of the story is really meaningful", StoryId=1}
            };

            comments.ForEach(comment => context.Comments.AddOrUpdate(p => p.CommentId, comment));
            context.SaveChanges();

        }
    }
}
