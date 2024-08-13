using System;
using Group_26_Final_Project.DAL;
using Group_26_Final_Project.Models;
using Microsoft.SqlServer.Server;
using static System.Reflection.Metadata.BlobBuilder;

namespace Group_26_Final_Project.Seeding
{
    public static class SeedPrices
    {
        public async static void SeedAllPrices(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intPricesAdded = 0;
            TicketType strPriceType = TicketType.DiscountTuesday;

            // create movie list and instance of movie
            List<Price> Prices = new List<Price>();
            Price p1 = new Price()
            {
                TicketType = TicketType.DiscountTuesday,
                TicketPrice = 8,

            };
            Prices.Add(p1);

            Price p2 = new Price()
            {
                TicketType = TicketType.Matinee,
                TicketPrice = 5,

            };
            Prices.Add(p2);

            Price p3 = new Price()
            {
                TicketType = TicketType.SpecialEvent,
                TicketPrice = 15,

            };
            Prices.Add(p3);

            Price p4 = new Price()
            {
                TicketType = TicketType.Weekday,
                TicketPrice = 10,

            };
            Prices.Add(p4);

            Price p5 = new Price()
            {
                TicketType = TicketType.Weekend,
                TicketPrice = 12,

            };
            Prices.Add(p5);

            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (Price priceToAdd in Prices)
                {
                    //set the flag to the current title to help with debugging
                    strPriceType = priceToAdd.TicketType;
                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    Price dbPrice = db.Prices.FirstOrDefault(p => p.TicketType == priceToAdd.TicketType);

                    //if the dbBook is null, this title is not in the database
                    if (dbPrice == null)
                    {
                        //add the book to the database and save changes
                        db.Prices.Add(priceToAdd);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intPricesAdded += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties
                        dbPrice.TicketType = priceToAdd.TicketType;
                        dbPrice.TicketPrice = priceToAdd.TicketPrice;

                        //update the database and save the changes
                        db.Update(dbPrice);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intPricesAdded += 1;
                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                //Build a messsage using the flags we created
                String msg = "  Repositories added:" + intPricesAdded + "; Error on " + strPriceType;

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}



