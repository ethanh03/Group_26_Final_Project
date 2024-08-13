using System;
using Group_26_Final_Project.DAL;
using Group_26_Final_Project.Models;
using Microsoft.SqlServer.Server;
using static System.Reflection.Metadata.BlobBuilder;

namespace Group_26_Final_Project.Seeding
{
    public static class SeedGenres
    {
        public async static void SeedAllGenres(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intGenresAdded = 0;
            String strGenreTitle = "Begin";

            // create movie list and instance of movie
            List<Genre> Genres = new List<Genre>();
            Genre g1 = new Genre()
            {
                GenreName = "Drama",

            };
            Genres.Add(g1);

            Genre g2 = new Genre()
            {
                GenreName = "Children And Family",

            };
            Genres.Add(g2);

            Genre g3 = new Genre()
            {
                GenreName = "Action",

            };
            Genres.Add(g3);

            Genre g4 = new Genre()
            {
                GenreName = "Romance",

            };
            Genres.Add(g4);

            Genre g5 = new Genre()
            {
                GenreName = "Comedy",

            };
            Genres.Add(g5);

            Genre g6 = new Genre()
            {
                GenreName = "Musical",

            };
            Genres.Add(g6);

            Genre g7 = new Genre()
            {
                GenreName = "Horror",

            };
            Genres.Add(g7);

            Genre g8 = new Genre()
            {
                GenreName = "Science Fiction",

            };
            Genres.Add(g8);

            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (Genre genreToAdd in Genres)
                {
                    //set the flag to the current title to help with debugging
                    strGenreTitle = genreToAdd.GenreName;
                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    Genre dbGenre = db.Genres.FirstOrDefault(g => g.GenreName == genreToAdd.GenreName);

                    //if the dbBook is null, this title is not in the database
                    if (dbGenre == null)
                    {
                        //add the book to the database and save changes
                        db.Genres.Add(genreToAdd);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intGenresAdded += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties
                        dbGenre.GenreName = genreToAdd.GenreName;
                        
                        //update the database and save the changes
                        db.Update(dbGenre);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intGenresAdded += 1;
                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                //Build a messsage using the flags we created
                String msg = "  Repositories added:" + intGenresAdded + "; Error on " + strGenreTitle;

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}



