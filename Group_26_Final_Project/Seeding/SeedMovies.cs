using System;
using Group_26_Final_Project.DAL;
using Group_26_Final_Project.Models;
using Microsoft.SqlServer.Server;
using static System.Reflection.Metadata.BlobBuilder;

namespace Group_26_Final_Project.Seeding
{
	public static class SeedMovies
	{
        public async static void SeedOneMovie(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intMoviesAdded = 0;
            String strMovieTitle = "Begin";

            // create movie list and instance of movie
            List<Movie> Movies = new List<Movie>();


            Movie m0 = new Movie()
            {
                Title = "Jurassic Park",
                Description = "A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose.",
                Tagline = "Welcome to Jurassic Park",
                Runtime = 90,
                Actors = "Sam Neill, Laura Dern, Jeff Goldblum",
                ReleaseYear = 1993,
                MPAARating = MPAARating.PG13,
                MovieNumber = 3001,
                AverageRating = 0m,

            };
            m0.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama");
            Movies.Add(m0);



            Movie m1 = new Movie()
            {
                Title = "Toy Story 7",
                Description = "Woody and Buzz team up once again to lead the resistance in the Toy Revolt.",
                Tagline = "Play, pretend, and protect",
                Runtime = 90,
                Actors = "Tom Hanks, Tim Allen",
                ReleaseYear = 2023,
                MPAARating = MPAARating.G,
                MovieNumber = 3002,
                AverageRating = 0m,
            };
            m1.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Children and Family");
            Movies.Add(m1);



            Movie m2 = new Movie()
            {
                Title = "Fast and Furious 18: Anger Management",
                Description = "They may be riding mechanical scooters, but they are as furious as ever as they attend court-ordered therapy.",
                Tagline = "I drink your milkshake",
                Runtime = 120,
                Actors = "The Rock, Vin Diesel",
                ReleaseYear = 2023,
                MPAARating = MPAARating.R,
                MovieNumber = 3003,
                AverageRating = 0m,
            };
            m2.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action");
            Movies.Add(m2);



            Movie m3 = new Movie()
            {
                Title = "Titanic",
                Description = "An epic, action-packed romance set against the ill-fated maiden voyage of the R.M.S. Titanic.",
                Tagline = "Nothing On Earth Could Come Between Them. Collide With Destiny.",
                Runtime = 150,
                Actors = "Leonardo DiCaprio, Kate Winslet",
                ReleaseYear = 1999,
                MPAARating = MPAARating.PG13,
                MovieNumber = 3004,
                AverageRating = 0m,
            };
            m3.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
            Movies.Add(m3);



            Movie m4 = new Movie()
            {
                Title = "The Secret Life of Walter Mitty",
                Description = "When both he and a colleague are about to lose their job, Walter takes action by embarking on an adventure more extraordinary than anything he ever imagined.",
                Tagline = "Stop dreaming. Start Living.",
                Runtime = 120,
                Actors = "Ben Stiller",
                ReleaseYear = 2013,
                MPAARating = MPAARating.PG,
                MovieNumber = 3005,
                AverageRating = 0m,
            };
            m4.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy");
            Movies.Add(m4);



            Movie m5 = new Movie()
            {
                Title = "The Goonies",
                Description = "A group of young misfits called The Goonies discover an ancient map and set out on an adventure to find a legendary pirate's long-lost treasure.",
                Tagline = "The treacherous traps. The hidden treasure. And Sloth... Join the adventure.",
                Runtime = 90,
                Actors = "Sean Astin, Josh Brolin, Corey Feldman",
                ReleaseYear = 1985,
                MPAARating = MPAARating.PG,
                MovieNumber = 3006,
                AverageRating = 0m,
            };
            m5.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Children and Family");
            Movies.Add(m5);



            Movie m6 = new Movie()
            {
                Title = "The Sandlot",
                Description = "When Scottie Smalls moves to a new neighborhood, he manages to make friends with a group of kids who play baseball at the sandlot.",
                Tagline = "The adventure of a lifetime, the summer of their dreams...the dog of their nightmares.",
                Runtime = 90,
                Actors = "Mike Vitar, Patrick Renna, James Earl Jones",
                ReleaseYear = 1993,
                MPAARating = MPAARating.PG,
                MovieNumber = 3007,
                AverageRating = 0m,

            };
            m6.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Children and Family");
            Movies.Add(m6);



            Movie m7 = new Movie()
            {
                Title = "Rocky Horror Picture Show",
                Description = "A newly-engaged couple have a breakdown in an isolated area and must seek shelter at the bizarre residence of Dr. Frank-n-Furter",
                Tagline = "Don't Dream it, Be It!",
                Runtime = 90,
                Actors = "Tim Curry, Susan Sarandon",
                ReleaseYear = 1975,
                MPAARating = MPAARating.R,
                MovieNumber = 3008,
                AverageRating = 0m,

            };
            m7.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Musical");
            Movies.Add(m7);



            Movie m8 = new Movie()
            {
                Title = "Titanic: Jack's Revenge",
                Description = "Emerging from the deep with revenge on his mind, Jack Dawson will stop at nothing to find Rose.",
                Tagline = "She let me go, now I'll never let her forget it.",
                Runtime = 150,
                Actors = "Leonardo DiCaprio, Kate Winslet",
                ReleaseYear = 2023,
                MPAARating = MPAARating.R,
                MovieNumber = 3009,
                AverageRating = 0m,

            };
            m8.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror");
            Movies.Add(m8);



            Movie m9 = new Movie()
            {
                Title = "The Hobbit: An Unexpected Journey",
                Description = "An Unexpected Journey tells the tale of Bilbo Baggins, who is convinced by the wizard Gandalf to accompany thirteen Dwarves, led by Thorin Oakenshield, on a quest to reclaim the Lonely Mountain from the dragon Smaug.",
                Tagline = "From the smallest beginnings come the greatest legends. One journey started it all.",
                Runtime = 150,
                Actors = "Martin Freeman, Ian McKellan, Richard Armitage",
                ReleaseYear = 2012,
                MPAARating = MPAARating.PG13,
                MovieNumber = 3010,
                AverageRating = 0m,

            };
            m9.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
            Movies.Add(m9);



            Movie m10 = new Movie()
            {
                Title = "The Hobbit: The Battle of Five Armies",
                Description = "Bilbo and company are forced to engage in a war against an array of combatants and keep the Lonely Mountain from falling into the hands of a rising darkness.",
                Tagline = "The defining chapter.",
                Runtime = 150,
                Actors = "Martin Freeman, Ian McKellan, Richard Armitage",
                ReleaseYear = 2014,
                MPAARating = MPAARating.PG13,
                MovieNumber = 3011,
                AverageRating = 0m,

            };
            m10.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
            Movies.Add(m10);



            Movie m11 = new Movie()
            {
                Title = "The Hobbit: The Desolation of Smaug",
                Description = "The dwarves, along with Bilbo Baggins and Gandalf the Grey, continue their quest to reclaim Erebor, their homeland, from Smaug.",
                Tagline = "It's a really big dragon",
                Runtime = 150,
                Actors = "Martin Freeman, Ian McKellan, Richard Armitage",
                ReleaseYear = 2013,
                MPAARating = MPAARating.PG13,
                MovieNumber = 3012,
                AverageRating = 0m,

            };
            m11.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
            Movies.Add(m11);



            Movie m12 = new Movie()
            {
                Title = "Lord of the Rings: Fellowship of the Ring",
                Description = "The future of civilization rests in the fate of the One Ring, which has been lost for centuries. Powerful forces are unrelenting in their search for it. But fate has placed it in the hands of a young Hobbit named Frodo Baggins, who inherits the Ring and steps into legend.",
                Tagline = "One Ring To Rule Them All. Fate Has Chosen Him. A Fellowship Will Protect Him. Evil Will Hunt Them.",
                Runtime = 150,
                Actors = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                ReleaseYear = 2001,
                MPAARating = MPAARating.PG13,
                MovieNumber = 3013,
                AverageRating = 0m,

            };
            m12.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
            Movies.Add(m12);



            Movie m13 = new Movie()
            {
                Title = "Lord of the Rings: Two Towers",
                Description = "Frodo and Sam discover they are being followed by the mysterious Gollum.",
                Tagline = "A New Power Is Rising. The Battle for Middle-earth Begins!",
                Runtime = 150,
                Actors = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                ReleaseYear = 2002,
                MPAARating = MPAARating.PG13,
                MovieNumber = 3014,
                AverageRating = 0m,

            };
            m13.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
            Movies.Add(m13);



            Movie m14 = new Movie()
            {
                Title = "Lord of the Rings: The Return of the King",
                Description = "Continuing the plot of the previous film, Frodo, Sam and Gollum are making their final way toward Mount Doom to destroy the One Ring, unaware of Gollum's true intentions, while Merry, Pippin, Gandalf, Aragorn, Legolas, Gimli and the others join forces together against Sauron and his legions in Minas Tirith.",
                Tagline = "No victory without suffering. No freedom without sacrifice.",
                Runtime = 180,
                Actors = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                ReleaseYear = 2003,
                MPAARating = MPAARating.PG13,
                MovieNumber = 3015,
                AverageRating = 0m,

            };
            m14.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
            Movies.Add(m14);



            Movie m15 = new Movie()
            {
                Title = "Barbie",
                Description = "Stereotypical Barbie experiences a full on existential crisis and embarks on a journey of self discovery. Along for the ride is her beau Ken.",
                Tagline = "She can do everything. He's just Ken.",
                Runtime = 120,
                Actors = "Ryan Gosling, Margot Robbie",
                ReleaseYear = 2023,
                MPAARating = MPAARating.PG13,
                MovieNumber = 3016,
                AverageRating = 0m,

            };
            m15.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy");
            Movies.Add(m15);



            Movie m16 = new Movie()
            {
                Title = "Spider-Man: Into the Spider-Verse",
                Description = "Teen Miles Morales becomes the Spider-Man of his universe and must join with five spider-powered individuals from other dimensions to stop a threat for all realities.",
                Tagline = "Enter a universe where more than one wears the mask.",
                Runtime = 120,
                Actors = "Shameik Moore, Jake Johnson, Hailee Steinfeld, Stan Lee, Oscar Isaac, Nicolas Cage, Mahershala Ali",
                ReleaseYear = 2018,
                MPAARating = MPAARating.PG,
                MovieNumber = 3017,
                AverageRating = 0m,

            };
            m16.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action");
            Movies.Add(m16);



            Movie m17 = new Movie()
            {
                Title = "Spider-Man: Across the Spider-Verse",
                Description = "Miles Morales catapults across the Multiverse, where he encounters a team of Spider-People charged with protecting its very existence.",
                Tagline = "With great power comes great responsibility.",
                Runtime = 150,
                Actors = "Shameik Moore, Hailee Steinfeld, Oscar Isaac, Karan Soni, Andy Samberg, Daniel Kaluuya",
                ReleaseYear = 2023,
                MPAARating = MPAARating.PG,
                MovieNumber = 3018,
                AverageRating = 0m,

            };
            m17.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action");
            Movies.Add(m17);



            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (Movie movieToAdd in Movies)
                {
                    //set the flag to the current title to help with debugging
                    strMovieTitle = movieToAdd.Title;
                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    Movie dbMovie = db.Movies.FirstOrDefault(m => m.Title == movieToAdd.Title);

                    //if the dbBook is null, this title is not in the database
                    if (dbMovie == null)
                    {
                        //add the book to the database and save changes
                        db.Movies.Add(movieToAdd);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intMoviesAdded += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties
                        dbMovie.Title = movieToAdd.Title;
                        dbMovie.Description = movieToAdd.Description;
                        dbMovie.Tagline = movieToAdd.Tagline;
                        dbMovie.Runtime = movieToAdd.Runtime;
                        dbMovie.Actors = movieToAdd.Actors;
                        dbMovie.ReleaseYear = movieToAdd.ReleaseYear;
                        dbMovie.MPAARating = movieToAdd.MPAARating;

                        //since we found the correct genre object in a previous step,
                        //this update is easy - both dbBook and bookToAdd have a Genre 
                        //object for this property
                        dbMovie.Genre = movieToAdd.Genre;

                        //update the database and save the changes
                        db.Update(dbMovie);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intMoviesAdded += 1;
                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                //Build a messsage using the flags we created
                String msg = "  Repositories added:" + intMoviesAdded + "; Error on " + strMovieTitle;

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}



