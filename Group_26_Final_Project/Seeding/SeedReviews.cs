using System;
using Group_26_Final_Project.DAL;
using Group_26_Final_Project.Models;
using Microsoft.SqlServer.Server;
using static System.Reflection.Metadata.BlobBuilder;

namespace Group_26_Final_Project.Seeding
{
    public static class SeedReviews
    {
        public async static void SeedOneReview(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intReviewsAdded = 0;
            String strReview = "Begin";

            // create movie list and instance of movie
            List<Review> Reviews = new List<Review>();

            Review r0 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 5,
                ReviewText = "Best movie I've ever seen.",
                ReviewStatus = ReviewStatus.Approved,

            };
            r0.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");
            r0.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Michelle" && u.LastName == "Banks");

            Reviews.Add(r0);

            Review r1 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 4,
                ReviewText = "Not bad.",
                ReviewStatus = ReviewStatus.Approved,

            };
            r1.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");
            r1.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Christopher" && u.LastName == "Baker");

            Reviews.Add(r1);

            Review r2 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 5,
                ReviewText = "Changed my life",
                ReviewStatus = ReviewStatus.Approved,

            };
            r2.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");
            r2.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");

            Reviews.Add(r2);

            Review r3 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 5,
                ReviewText = "Great family adventure movie",
                ReviewStatus = ReviewStatus.Approved,

            };
            r3.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");
            r3.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Franco" && u.LastName == "Broccolo");

            Reviews.Add(r3);

            Review r4 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 4,
                ReviewText = "Good movie",
                ReviewStatus = ReviewStatus.Approved,

            };
            r4.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");
            r4.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Wendy" && u.LastName == "Chang");

            Reviews.Add(r4);

            Review r5 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 1,
                ReviewText = "Worst thing I've ever seen",
                ReviewStatus = ReviewStatus.Approved,

            };
            r5.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");
            r5.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Lim" && u.LastName == "Chou");

            Reviews.Add(r5);

            Review r6 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 5,
                ReviewText = "Reminded me of my summers in the NW",
                ReviewStatus = ReviewStatus.Approved,

            };
            r6.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");
            r6.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");

            Reviews.Add(r6);

            Review r7 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 5,
                ReviewText = "I love a good treasure hunt!",
                ReviewStatus = ReviewStatus.NeedsReview,

            };
            r7.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");
            r7.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Shan" && u.LastName == "Dixon");

            Reviews.Add(r7);

            Review r8 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 3,
                ReviewText = "Meh",
                ReviewStatus = ReviewStatus.Approved,

            };
            r8.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");
            r8.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Jim" && u.LastName == "Bob");

            Reviews.Add(r8);

            Review r9 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 4,
                ReviewText = "nan",
                ReviewStatus = ReviewStatus.Approved,

            };
            r9.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies");
            r9.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Christopher" && u.LastName == "Baker");

            Reviews.Add(r9);

            Review r10 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 4,
                ReviewText = "nan",
                ReviewStatus = ReviewStatus.Approved,

            };
            r10.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies");
            r10.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");

            Reviews.Add(r10);

            Review r11 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 5,
                ReviewText = "nan",
                ReviewStatus = ReviewStatus.Approved,

            };
            r11.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies");
            r11.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Michelle" && u.LastName == "Banks");

            Reviews.Add(r11);

            Review r12 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 5,
                ReviewText = "nan",
                ReviewStatus = ReviewStatus.Approved,

            };
            r12.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies");
            r12.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Franco" && u.LastName == "Broccolo");

            Reviews.Add(r12);

            Review r13 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 1,
                ReviewText = "Too long",
                ReviewStatus = ReviewStatus.NeedsReview,

            };
            r13.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies");
            r13.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Wendy" && u.LastName == "Chang");

            Reviews.Add(r13);

            Review r14 = new Review()
            {
                ReviewID = intReviewsAdded,
                Rating = 2,
                ReviewText = "Did they really need to drag this out into its own movie?",
                ReviewStatus = ReviewStatus.NeedsReview,

            };
            r14.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies");
            r14.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Lim" && u.LastName == "Chou");

            Reviews.Add(r14);


            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (Review reviewToAdd in Reviews)
                {
                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    Review dbReview = db.Reviews.FirstOrDefault(s => s.ReviewID == reviewToAdd.ReviewID);

                    //if the dbBook is null, this title is not in the database
                    if (dbReview == null)
                    {
                        //add the book to the database and save changes
                        db.Reviews.Add(reviewToAdd);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intReviewsAdded += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties
                        dbReview.Rating = reviewToAdd.Rating;
                        dbReview.ReviewText = reviewToAdd.ReviewText;
                        dbReview.ReviewStatus = reviewToAdd.ReviewStatus;

                        //since we found the correct genre object in a previous step,
                        //this update is easy - both dbBook and bookToAdd have a Genre 
                        //object for this property
                        dbReview.Movie = reviewToAdd.Movie;
                        dbReview.Customer = reviewToAdd.Customer;

                        //update the database and save the changes
                        db.Update(dbReview);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intReviewsAdded += 1;
                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                //Build a messsage using the flags we created
                String msg = "  Repositories added:" + intReviewsAdded + "; Error on " + strReview;

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }

    }
}



