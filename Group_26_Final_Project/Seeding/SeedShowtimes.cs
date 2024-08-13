using System;
using Group_26_Final_Project.DAL;
using Group_26_Final_Project.Models;
using Microsoft.SqlServer.Server;
using static System.Reflection.Metadata.BlobBuilder;

namespace Group_26_Final_Project.Seeding
{
    public static class SeedShowtimes
    {

        public async static void SeedOneShowtime(AppDbContext db)
        { 
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intShowtimesAdded = 0;

            // create movie list and instance of movie
            List<Showtime> Showtimes = new List<Showtime>();



            Showtime s0 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 23, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 23, 9, 0, 0),
                Approved = true

            };

            s0.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s0.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            Int32 hour = s0.Movie.Runtime / 60;
            Int32 minute = s0.Movie.Runtime % 60;
            s0.EndTime = new DateTime(2023, 11, 23, s0.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s0);


            Showtime s1 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 23, 11, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 23, 11, 0, 0),
                Approved = true

            };

            s1.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s1.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s1.Movie.Runtime / 60;
            minute = s1.Movie.Runtime % 60;
            s1.EndTime = new DateTime(2023, 11, 23, s1.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s1);


            Showtime s2 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 23, 13, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 23, 13, 30, 0),
                Approved = true

            };

            s2.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s2.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic");

            hour = s2.Movie.Runtime / 60;
            minute = s2.Movie.Runtime % 60;
            s2.EndTime = new DateTime(2023, 11, 23, s2.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s2);


            Showtime s3 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 23, 16, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 23, 16, 30, 0),
                Approved = true

            };

            s3.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s3.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s3.Movie.Runtime / 60;
            minute = s3.Movie.Runtime % 60;
            s3.EndTime = new DateTime(2023, 11, 23, s3.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s3);


            Showtime s4 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 23, 19, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 23, 19, 0, 0),
                Approved = true

            };

            s4.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s4.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s4.Movie.Runtime / 60;
            minute = s4.Movie.Runtime % 60;
            s4.EndTime = new DateTime(2023, 11, 23, s4.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s4);


            Showtime s5 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 23, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 23, 21, 0, 0),
                Approved = true

            };

            s5.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s5.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s5.Movie.Runtime / 60;
            minute = s5.Movie.Runtime % 60;
            s5.EndTime = new DateTime(2023, 11, 23, s5.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s5);


            Showtime s6 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 23, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 23, 9, 0, 0),
                Approved = true

            };

            s6.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s6.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s6.Movie.Runtime / 60;
            minute = s6.Movie.Runtime % 60;
            s6.EndTime = new DateTime(2023, 11, 23, s6.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s6);


            Showtime s7 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 23, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 23, 11, 0, 0),
                Approved = true

            };

            s7.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s7.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s7.Movie.Runtime / 60;
            minute = s7.Movie.Runtime % 60;
            s7.EndTime = new DateTime(2023, 11, 23, s7.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s7);


            Showtime s8 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 23, 13, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 23, 13, 0, 0),
                Approved = true

            };

            s8.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s8.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s8.Movie.Runtime / 60;
            minute = s8.Movie.Runtime % 60;
            s8.EndTime = new DateTime(2023, 11, 23, s8.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s8);


            Showtime s9 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 23, 15, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 23, 15, 30, 0),
                Approved = true

            };

            s9.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s9.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s9.Movie.Runtime / 60;
            minute = s9.Movie.Runtime % 60;
            s9.EndTime = new DateTime(2023, 11, 23, s9.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s9);


            Showtime s10 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 23, 18, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 23, 18, 0, 0),
                Approved = true

            };

            s10.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s10.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s10.Movie.Runtime / 60;
            minute = s10.Movie.Runtime % 60;
            s10.EndTime = new DateTime(2023, 11, 23, s10.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s10);


            Showtime s11 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 23, 20, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 23, 20, 0, 0),
                Approved = true

            };

            s11.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s11.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot");

            hour = s11.Movie.Runtime / 60;
            minute = s11.Movie.Runtime % 60;
            s11.EndTime = new DateTime(2023, 11, 23, s11.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s11);


            Showtime s12 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 23, 22, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 23, 22, 0, 0),
                Approved = true

            };

            s12.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s12.Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show");

            hour = s12.Movie.Runtime / 60;
            minute = s12.Movie.Runtime % 60;
            s12.EndTime = new DateTime(2023, 11, 23, s12.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s12);


            Showtime s13 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 24, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 24, 9, 0, 0),
                Approved = true

            };

            s13.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s13.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s13.Movie.Runtime / 60;
            minute = s13.Movie.Runtime % 60;
            s13.EndTime = new DateTime(2023, 11, 24, s13.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s13);


            Showtime s14 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 24, 11, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 24, 11, 0, 0),
                Approved = true

            };

            s14.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s14.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s14.Movie.Runtime / 60;
            minute = s14.Movie.Runtime % 60;
            s14.EndTime = new DateTime(2023, 11, 24, s14.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s14);


            Showtime s15 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 24, 13, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 24, 13, 30, 0),
                Approved = true

            };

            s15.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s15.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge");

            hour = s15.Movie.Runtime / 60;
            minute = s15.Movie.Runtime % 60;
            s15.EndTime = new DateTime(2023, 11, 24, s15.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s15);


            Showtime s16 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 24, 16, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 24, 16, 30, 0),
                Approved = true

            };

            s16.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s16.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s16.Movie.Runtime / 60;
            minute = s16.Movie.Runtime % 60;
            s16.EndTime = new DateTime(2023, 11, 24, s16.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s16);


            Showtime s17 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 24, 19, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 24, 19, 0, 0),
                Approved = true

            };

            s17.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s17.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s17.Movie.Runtime / 60;
            minute = s17.Movie.Runtime % 60;
            s17.EndTime = new DateTime(2023, 11, 24, s17.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s17);


            Showtime s18 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 24, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 24, 21, 0, 0),
                Approved = true

            };

            s18.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s18.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s18.Movie.Runtime / 60;
            minute = s18.Movie.Runtime % 60;
            s18.EndTime = new DateTime(2023, 11, 24, s18.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s18);


            Showtime s19 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 24, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 24, 9, 0, 0),
                Approved = true

            };

            s19.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s19.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s19.Movie.Runtime / 60;
            minute = s19.Movie.Runtime % 60;
            s19.EndTime = new DateTime(2023, 11, 24, s19.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s19);


            Showtime s20 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 24, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 24, 11, 0, 0),
                Approved = true

            };

            s20.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s20.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s20.Movie.Runtime / 60;
            minute = s20.Movie.Runtime % 60;
            s20.EndTime = new DateTime(2023, 11, 24, s20.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s20);


            Showtime s21 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 24, 13, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 24, 13, 0, 0),
                Approved = true

            };

            s21.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s21.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s21.Movie.Runtime / 60;
            minute = s21.Movie.Runtime % 60;
            s21.EndTime = new DateTime(2023, 11, 24, s21.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s21);


            Showtime s22 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 24, 15, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 24, 15, 30, 0),
                Approved = true

            };

            s22.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s22.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s22.Movie.Runtime / 60;
            minute = s22.Movie.Runtime % 60;
            s22.EndTime = new DateTime(2023, 11, 24, s22.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s22);


            Showtime s23 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 24, 18, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 24, 18, 0, 0),
                Approved = true

            };

            s23.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s23.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s23.Movie.Runtime / 60;
            minute = s23.Movie.Runtime % 60;
            s23.EndTime = new DateTime(2023, 11, 24, s23.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s23);


            Showtime s24 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 24, 20, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 24, 20, 0, 0),
                Approved = true

            };

            s24.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s24.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot");

            hour = s24.Movie.Runtime / 60;
            minute = s24.Movie.Runtime % 60;
            s24.EndTime = new DateTime(2023, 11, 24, s24.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s24);


            Showtime s25 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 24, 22, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 24, 22, 0, 0),
                Approved = true

            };

            s25.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s25.Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show");

            hour = s25.Movie.Runtime / 60;
            minute = s25.Movie.Runtime % 60;
            s25.EndTime = new DateTime(2023, 11, 24, s25.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s25);


            Showtime s26 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 25, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 25, 9, 0, 0),
                Approved = true

            };

            s26.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s26.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic");

            hour = s26.Movie.Runtime / 60;
            minute = s26.Movie.Runtime % 60;
            s26.EndTime = new DateTime(2023, 11, 25, s26.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s26);


            Showtime s27 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 25, 12, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 25, 12, 0, 0),
                Approved = true

            };

            s27.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s27.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge");

            hour = s27.Movie.Runtime / 60;
            minute = s27.Movie.Runtime % 60;
            s27.EndTime = new DateTime(2023, 11, 25, s27.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s27);


            Showtime s28 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 25, 15, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 25, 15, 0, 0),
                Approved = true

            };

            s28.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s28.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey");

            hour = s28.Movie.Runtime / 60;
            minute = s28.Movie.Runtime % 60;
            s28.EndTime = new DateTime(2023, 11, 25, s28.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s28);


            Showtime s29 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 25, 18, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 25, 18, 0, 0),
                Approved = true

            };

            s29.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s29.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug");

            hour = s29.Movie.Runtime / 60;
            minute = s29.Movie.Runtime % 60;
            s29.EndTime = new DateTime(2023, 11, 25, s29.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s29);


            Showtime s30 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 25, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = true,
                StartTime = new DateTime(2023, 11, 25, 21, 0, 0),
                Approved = true

            };

            s30.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.SpecialEvent);
            s30.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies");

            hour = s30.Movie.Runtime / 60;
            minute = s30.Movie.Runtime % 60;
            s30.EndTime = new DateTime(2023, 11, 25, s30.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s30);


            Showtime s31 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 25, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 25, 9, 0, 0),
                Approved = true

            };

            s31.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s31.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s31.Movie.Runtime / 60;
            minute = s31.Movie.Runtime % 60;
            s31.EndTime = new DateTime(2023, 11, 25, s31.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s31);


            Showtime s32 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 25, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 25, 11, 0, 0),
                Approved = true

            };

            s32.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s32.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s32.Movie.Runtime / 60;
            minute = s32.Movie.Runtime % 60;
            s32.EndTime = new DateTime(2023, 11, 25, s32.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s32);


            Showtime s33 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 25, 13, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 25, 13, 30, 0),
                Approved = true

            };

            s33.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s33.Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Fellowship of the Ring");

            hour = s33.Movie.Runtime / 60;
            minute = s33.Movie.Runtime % 60;
            s33.EndTime = new DateTime(2023, 11, 25, s33.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s33);


            Showtime s34 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 25, 16, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 25, 16, 30, 0),
                Approved = true

            };

            s34.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s34.Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers");

            hour = s34.Movie.Runtime / 60;
            minute = s34.Movie.Runtime % 60;
            s34.EndTime = new DateTime(2023, 11, 25, s34.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s34);


            Showtime s35 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 25, 19, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = true,
                StartTime = new DateTime(2023, 11, 25, 19, 30, 0),
                Approved = true

            };

            s35.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.SpecialEvent);
            s35.Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King");

            hour = s35.Movie.Runtime / 60;
            minute = s35.Movie.Runtime % 60;
            s35.EndTime = new DateTime(2023, 11, 25, s35.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s35);


            Showtime s36 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 26, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 26, 9, 0, 0),
                Approved = true

            };

            s36.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s36.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic");

            hour = s36.Movie.Runtime / 60;
            minute = s36.Movie.Runtime % 60;
            s36.EndTime = new DateTime(2023, 11, 26, s36.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s36);


            Showtime s37 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 26, 12, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 26, 12, 0, 0),
                Approved = true

            };

            s37.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s37.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge");

            hour = s37.Movie.Runtime / 60;
            minute = s37.Movie.Runtime % 60;
            s37.EndTime = new DateTime(2023, 11, 26, s37.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s37);


            Showtime s38 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 26, 15, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 26, 15, 0, 0),
                Approved = true

            };

            s38.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s38.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey");

            hour = s38.Movie.Runtime / 60;
            minute = s38.Movie.Runtime % 60;
            s38.EndTime = new DateTime(2023, 11, 26, s38.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s38);


            Showtime s39 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 26, 18, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 26, 18, 0, 0),
                Approved = true

            };

            s39.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s39.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug");

            hour = s39.Movie.Runtime / 60;
            minute = s39.Movie.Runtime % 60;
            s39.EndTime = new DateTime(2023, 11, 26, s39.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s39);


            Showtime s40 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 26, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = true,
                StartTime = new DateTime(2023, 11, 26, 21, 0, 0),
                Approved = true

            };

            s40.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.SpecialEvent);
            s40.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies");

            hour = s40.Movie.Runtime / 60;
            minute = s40.Movie.Runtime % 60;
            s40.EndTime = new DateTime(2023, 11, 26, s40.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s40);


            Showtime s41 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 26, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 26, 9, 0, 0),
                Approved = true

            };

            s41.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s41.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s41.Movie.Runtime / 60;
            minute = s41.Movie.Runtime % 60;
            s41.EndTime = new DateTime(2023, 11, 26, s41.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s41);


            Showtime s42 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 26, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 26, 11, 0, 0),
                Approved = true

            };

            s42.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s42.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s42.Movie.Runtime / 60;
            minute = s42.Movie.Runtime % 60;
            s42.EndTime = new DateTime(2023, 11, 26, s42.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s42);


            Showtime s43 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 26, 13, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 26, 13, 30, 0),
                Approved = true

            };

            s43.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s43.Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Fellowship of the Ring");

            hour = s43.Movie.Runtime / 60;
            minute = s43.Movie.Runtime % 60;
            s43.EndTime = new DateTime(2023, 11, 26, s43.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s43);


            Showtime s44 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 26, 16, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 26, 16, 30, 0),
                Approved = true

            };

            s44.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s44.Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers");

            hour = s44.Movie.Runtime / 60;
            minute = s44.Movie.Runtime % 60;
            s44.EndTime = new DateTime(2023, 11, 26, s44.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s44);


            Showtime s45 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 26, 19, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = true,
                StartTime = new DateTime(2023, 11, 26, 19, 30, 0),
                Approved = true

            };

            s45.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.SpecialEvent);
            s45.Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King");

            hour = s45.Movie.Runtime / 60;
            minute = s45.Movie.Runtime % 60;
            s45.EndTime = new DateTime(2023, 11, 26, s45.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s45);


            Showtime s46 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 27, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 27, 9, 0, 0),
                Approved = true

            };

            s46.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s46.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s46.Movie.Runtime / 60;
            minute = s46.Movie.Runtime % 60;
            s46.EndTime = new DateTime(2023, 11, 27, s46.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s46);


            Showtime s47 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 27, 11, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 27, 11, 0, 0),
                Approved = true

            };

            s47.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s47.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s47.Movie.Runtime / 60;
            minute = s47.Movie.Runtime % 60;
            s47.EndTime = new DateTime(2023, 11, 27, s47.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s47);


            Showtime s48 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 27, 13, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 27, 13, 30, 0),
                Approved = true

            };

            s48.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s48.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic");

            hour = s48.Movie.Runtime / 60;
            minute = s48.Movie.Runtime % 60;
            s48.EndTime = new DateTime(2023, 11, 27, s48.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s48);


            Showtime s49 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 27, 16, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 27, 16, 30, 0),
                Approved = true

            };

            s49.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s49.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s49.Movie.Runtime / 60;
            minute = s49.Movie.Runtime % 60;
            s49.EndTime = new DateTime(2023, 11, 27, s49.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s49);


            Showtime s50 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 27, 19, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 27, 19, 0, 0),
                Approved = true

            };

            s50.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s50.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s50.Movie.Runtime / 60;
            minute = s50.Movie.Runtime % 60;
            s50.EndTime = new DateTime(2023, 11, 27, s50.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s50);


            Showtime s51 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 27, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 27, 21, 0, 0),
                Approved = true

            };

            s51.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s51.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s51.Movie.Runtime / 60;
            minute = s51.Movie.Runtime % 60;
            s51.EndTime = new DateTime(2023, 11, 27, s51.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s51);


            Showtime s52 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 27, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 27, 9, 0, 0),
                Approved = true

            };

            s52.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s52.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s52.Movie.Runtime / 60;
            minute = s52.Movie.Runtime % 60;
            s52.EndTime = new DateTime(2023, 11, 27, s52.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s52);


            Showtime s53 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 27, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 27, 11, 0, 0),
                Approved = true

            };

            s53.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s53.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s53.Movie.Runtime / 60;
            minute = s53.Movie.Runtime % 60;
            s53.EndTime = new DateTime(2023, 11, 27, s53.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s53);


            Showtime s54 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 27, 13, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 27, 13, 0, 0),
                Approved = true

            };

            s54.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s54.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s54.Movie.Runtime / 60;
            minute = s54.Movie.Runtime % 60;
            s54.EndTime = new DateTime(2023, 11, 27, s54.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s54);


            Showtime s55 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 27, 15, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 27, 15, 30, 0),
                Approved = true

            };

            s55.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s55.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s55.Movie.Runtime / 60;
            minute = s55.Movie.Runtime % 60;
            s55.EndTime = new DateTime(2023, 11, 27, s55.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s55);


            Showtime s56 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 27, 18, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 27, 18, 0, 0),
                Approved = true

            };

            s56.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s56.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s56.Movie.Runtime / 60;
            minute = s56.Movie.Runtime % 60;
            s56.EndTime = new DateTime(2023, 11, 27, s56.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s56);


            Showtime s57 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 27, 20, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 27, 20, 0, 0),
                Approved = true

            };

            s57.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s57.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot");

            hour = s57.Movie.Runtime / 60;
            minute = s57.Movie.Runtime % 60;
            s57.EndTime = new DateTime(2023, 11, 27, s57.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s57);


            Showtime s58 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 27, 22, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 27, 22, 0, 0),
                Approved = true

            };

            s58.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s58.Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show");

            hour = s58.Movie.Runtime / 60;
            minute = s58.Movie.Runtime % 60;
            s58.EndTime = new DateTime(2023, 11, 27, s58.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s58);


            Showtime s59 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 28, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 28, 9, 0, 0),
                Approved = true

            };

            s59.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s59.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s59.Movie.Runtime / 60;
            minute = s59.Movie.Runtime % 60;
            s59.EndTime = new DateTime(2023, 11, 28, s59.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s59);


            Showtime s60 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 28, 11, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 28, 11, 0, 0),
                Approved = true

            };

            s60.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s60.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s60.Movie.Runtime / 60;
            minute = s60.Movie.Runtime % 60;
            s60.EndTime = new DateTime(2023, 11, 28, s60.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s60);


            Showtime s61 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 28, 13, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 28, 13, 30, 0),
                Approved = true

            };

            s61.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.DiscountTuesday);
            s61.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic");

            hour = s61.Movie.Runtime / 60;
            minute = s61.Movie.Runtime % 60;
            s61.EndTime = new DateTime(2023, 11, 28, s61.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s61);


            Showtime s62 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 28, 16, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 28, 16, 30, 0),
                Approved = true

            };

            s62.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.DiscountTuesday);
            s62.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s62.Movie.Runtime / 60;
            minute = s62.Movie.Runtime % 60;
            s62.EndTime = new DateTime(2023, 11, 28, s62.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s62);


            Showtime s63 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 28, 19, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 28, 19, 0, 0),
                Approved = true

            };

            s63.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s63.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s63.Movie.Runtime / 60;
            minute = s63.Movie.Runtime % 60;
            s63.EndTime = new DateTime(2023, 11, 28, s63.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s63);


            Showtime s64 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 28, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 28, 21, 0, 0),
                Approved = true

            };

            s64.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s64.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s64.Movie.Runtime / 60;
            minute = s64.Movie.Runtime % 60;
            s64.EndTime = new DateTime(2023, 11, 28, s64.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s64);


            Showtime s65 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 28, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 28, 9, 0, 0),
                Approved = true

            };

            s65.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s65.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s65.Movie.Runtime / 60;
            minute = s65.Movie.Runtime % 60;
            s65.EndTime = new DateTime(2023, 11, 28, s65.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s65);


            Showtime s66 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 28, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 28, 11, 0, 0),
                Approved = true

            };

            s66.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s66.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s66.Movie.Runtime / 60;
            minute = s66.Movie.Runtime % 60;
            s66.EndTime = new DateTime(2023, 11, 28, s66.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s66);


            Showtime s67 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 28, 13, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 28, 13, 0, 0),
                Approved = true

            };

            s67.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.DiscountTuesday);
            s67.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s67.Movie.Runtime / 60;
            minute = s67.Movie.Runtime % 60;
            s67.EndTime = new DateTime(2023, 11, 28, s67.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s67);


            Showtime s68 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 28, 15, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 28, 15, 30, 0),
                Approved = true

            };

            s68.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.DiscountTuesday);
            s68.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s68.Movie.Runtime / 60;
            minute = s68.Movie.Runtime % 60;
            s68.EndTime = new DateTime(2023, 11, 28, s68.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s68);


            Showtime s69 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 28, 18, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 28, 18, 0, 0),
                Approved = true

            };

            s69.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s69.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s69.Movie.Runtime / 60;
            minute = s69.Movie.Runtime % 60;
            s69.EndTime = new DateTime(2023, 11, 28, s69.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s69);


            Showtime s70 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 28, 20, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 28, 20, 0, 0),
                Approved = true

            };

            s70.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s70.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot");

            hour = s70.Movie.Runtime / 60;
            minute = s70.Movie.Runtime % 60;
            s70.EndTime = new DateTime(2023, 11, 28, s70.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s70);


            Showtime s71 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 28, 22, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 28, 22, 0, 0),
                Approved = true

            };

            s71.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s71.Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show");

            hour = s71.Movie.Runtime / 60;
            minute = s71.Movie.Runtime % 60;
            s71.EndTime = new DateTime(2023, 11, 28, s71.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s71);


            Showtime s72 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 29, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 29, 9, 0, 0),
                Approved = true

            };

            s72.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s72.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s72.Movie.Runtime / 60;
            minute = s72.Movie.Runtime % 60;
            s72.EndTime = new DateTime(2023, 11, 29, s72.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s72);


            Showtime s73 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 29, 11, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 29, 11, 0, 0),
                Approved = true

            };

            s73.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s73.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s73.Movie.Runtime / 60;
            minute = s73.Movie.Runtime % 60;
            s73.EndTime = new DateTime(2023, 11, 29, s73.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s73);


            Showtime s74 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 29, 13, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 29, 13, 30, 0),
                Approved = true

            };

            s74.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s74.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic");

            hour = s74.Movie.Runtime / 60;
            minute = s74.Movie.Runtime % 60;
            s74.EndTime = new DateTime(2023, 11, 29, s74.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s74);


            Showtime s75 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 29, 16, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 29, 16, 30, 0),
                Approved = true

            };

            s75.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s75.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s75.Movie.Runtime / 60;
            minute = s75.Movie.Runtime % 60;
            s75.EndTime = new DateTime(2023, 11, 29, s75.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s75);


            Showtime s76 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 29, 19, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 29, 19, 0, 0),
                Approved = true

            };

            s76.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s76.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s76.Movie.Runtime / 60;
            minute = s76.Movie.Runtime % 60;
            s76.EndTime = new DateTime(2023, 11, 29, s76.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s76);


            Showtime s77 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 29, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 29, 21, 0, 0),
                Approved = true

            };

            s77.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s77.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s77.Movie.Runtime / 60;
            minute = s77.Movie.Runtime % 60;
            s77.EndTime = new DateTime(2023, 11, 29, s77.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s77);


            Showtime s78 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 29, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 29, 9, 0, 0),
                Approved = true

            };

            s78.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s78.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s78.Movie.Runtime / 60;
            minute = s78.Movie.Runtime % 60;
            s78.EndTime = new DateTime(2023, 11, 29, s78.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s78);


            Showtime s79 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 29, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 29, 11, 0, 0),
                Approved = true

            };

            s79.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s79.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s79.Movie.Runtime / 60;
            minute = s79.Movie.Runtime % 60;
            s79.EndTime = new DateTime(2023, 11, 29, s79.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s79);


            Showtime s80 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 29, 13, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 29, 13, 0, 0),
                Approved = true

            };

            s80.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s80.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s80.Movie.Runtime / 60;
            minute = s80.Movie.Runtime % 60;
            s80.EndTime = new DateTime(2023, 11, 29, s80.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s80);


            Showtime s81 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 29, 15, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 29, 15, 30, 0),
                Approved = true

            };

            s81.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s81.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s81.Movie.Runtime / 60;
            minute = s81.Movie.Runtime % 60;
            s81.EndTime = new DateTime(2023, 11, 29, s81.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s81);


            Showtime s82 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 29, 18, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 29, 18, 0, 0),
                Approved = true

            };

            s82.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s82.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s82.Movie.Runtime / 60;
            minute = s82.Movie.Runtime % 60;
            s82.EndTime = new DateTime(2023, 11, 29, s82.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s82);


            Showtime s83 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 29, 20, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 29, 20, 0, 0),
                Approved = true

            };

            s83.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s83.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot");

            hour = s83.Movie.Runtime / 60;
            minute = s83.Movie.Runtime % 60;
            s83.EndTime = new DateTime(2023, 11, 29, s83.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s83);


            Showtime s84 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 29, 22, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 29, 22, 0, 0),
                Approved = true

            };

            s84.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s84.Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show");

            hour = s84.Movie.Runtime / 60;
            minute = s84.Movie.Runtime % 60;
            s84.EndTime = new DateTime(2023, 11, 29, s84.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s84);


            Showtime s85 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 30, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 30, 9, 0, 0),
                Approved = true

            };

            s85.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s85.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s85.Movie.Runtime / 60;
            minute = s85.Movie.Runtime % 60;
            s85.EndTime = new DateTime(2023, 11, 30, s85.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s85);


            Showtime s86 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 30, 11, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 30, 11, 0, 0),
                Approved = true

            };

            s86.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s86.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s86.Movie.Runtime / 60;
            minute = s86.Movie.Runtime % 60;
            s86.EndTime = new DateTime(2023, 11, 30, s86.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s86);


            Showtime s87 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 30, 13, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 30, 13, 30, 0),
                Approved = true

            };

            s87.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s87.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge");

            hour = s87.Movie.Runtime / 60;
            minute = s87.Movie.Runtime % 60;
            s87.EndTime = new DateTime(2023, 11, 30, s87.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s87);


            Showtime s88 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 30, 16, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 30, 16, 30, 0),
                Approved = true

            };

            s88.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s88.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s88.Movie.Runtime / 60;
            minute = s88.Movie.Runtime % 60;
            s88.EndTime = new DateTime(2023, 11, 30, s88.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s88);


            Showtime s89 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 30, 19, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 30, 19, 0, 0),
                Approved = true

            };

            s89.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s89.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s89.Movie.Runtime / 60;
            minute = s89.Movie.Runtime % 60;
            s89.EndTime = new DateTime(2023, 11, 30, s89.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s89);


            Showtime s90 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 30, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 30, 21, 0, 0),
                Approved = true

            };

            s90.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s90.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s90.Movie.Runtime / 60;
            minute = s90.Movie.Runtime % 60;
            s90.EndTime = new DateTime(2023, 11, 30, s90.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s90);


            Showtime s91 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 30, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 30, 9, 0, 0),
                Approved = true

            };

            s91.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s91.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s91.Movie.Runtime / 60;
            minute = s91.Movie.Runtime % 60;
            s91.EndTime = new DateTime(2023, 11, 30, s91.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s91);


            Showtime s92 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 30, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 30, 11, 0, 0),
                Approved = true

            };

            s92.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s92.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s92.Movie.Runtime / 60;
            minute = s92.Movie.Runtime % 60;
            s92.EndTime = new DateTime(2023, 11, 30, s92.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s92);


            Showtime s93 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 30, 13, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 30, 13, 0, 0),
                Approved = true

            };

            s93.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s93.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s93.Movie.Runtime / 60;
            minute = s93.Movie.Runtime % 60;
            s93.EndTime = new DateTime(2023, 11, 30, s93.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s93);


            Showtime s94 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 30, 15, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 30, 15, 30, 0),
                Approved = true

            };

            s94.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s94.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s94.Movie.Runtime / 60;
            minute = s94.Movie.Runtime % 60;
            s94.EndTime = new DateTime(2023, 11, 30, s94.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s94);


            Showtime s95 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 30, 18, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 30, 18, 0, 0),
                Approved = true

            };

            s95.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s95.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s95.Movie.Runtime / 60;
            minute = s95.Movie.Runtime % 60;
            s95.EndTime = new DateTime(2023, 11, 30, s95.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s95);


            Showtime s96 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 30, 20, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 30, 20, 0, 0),
                Approved = true

            };

            s96.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s96.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot");

            hour = s96.Movie.Runtime / 60;
            minute = s96.Movie.Runtime % 60;
            s96.EndTime = new DateTime(2023, 11, 30, s96.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s96);


            Showtime s97 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 11, 30, 22, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 11, 30, 22, 0, 0),
                Approved = true

            };

            s97.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s97.Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show");

            hour = s97.Movie.Runtime / 60;
            minute = s97.Movie.Runtime % 60;
            s97.EndTime = new DateTime(2023, 11, 30, s97.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s97);


            Showtime s98 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 1, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 1, 9, 0, 0),
                Approved = true

            };

            s98.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s98.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s98.Movie.Runtime / 60;
            minute = s98.Movie.Runtime % 60;
            s98.EndTime = new DateTime(2023, 12, 1, s98.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s98);


            Showtime s99 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 1, 11, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 1, 11, 0, 0),
                Approved = true

            };

            s99.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s99.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s99.Movie.Runtime / 60;
            minute = s99.Movie.Runtime % 60;
            s99.EndTime = new DateTime(2023, 12, 1, s99.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s99);


            Showtime s100 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 1, 13, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 1, 13, 30, 0),
                Approved = true

            };

            s100.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s100.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge");

            hour = s100.Movie.Runtime / 60;
            minute = s100.Movie.Runtime % 60;
            s100.EndTime = new DateTime(2023, 12, 1, s100.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s100);


            Showtime s101 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 1, 16, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 1, 16, 30, 0),
                Approved = true

            };

            s101.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s101.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s101.Movie.Runtime / 60;
            minute = s101.Movie.Runtime % 60;
            s101.EndTime = new DateTime(2023, 12, 1, s101.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s101);


            Showtime s102 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 1, 19, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 1, 19, 0, 0),
                Approved = true

            };

            s102.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s102.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s102.Movie.Runtime / 60;
            minute = s102.Movie.Runtime % 60;
            s102.EndTime = new DateTime(2023, 12, 1, s102.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s102);


            Showtime s103 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 1, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = true,
                StartTime = new DateTime(2023, 12, 1, 21, 0, 0),
                Approved = true

            };

            s103.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.SpecialEvent);
            s103.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s103.Movie.Runtime / 60;
            minute = s103.Movie.Runtime % 60;
            s103.EndTime = new DateTime(2023, 12, 1, s103.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s103);


            Showtime s104 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 1, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 1, 9, 0, 0),
                Approved = true

            };

            s104.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s104.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s104.Movie.Runtime / 60;
            minute = s104.Movie.Runtime % 60;
            s104.EndTime = new DateTime(2023, 12, 1, s104.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s104);


            Showtime s105 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 1, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 1, 11, 0, 0),
                Approved = true

            };

            s105.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s105.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s105.Movie.Runtime / 60;
            minute = s105.Movie.Runtime % 60;
            s105.EndTime = new DateTime(2023, 12, 1, s105.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s105);


            Showtime s106 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 1, 13, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 1, 13, 0, 0),
                Approved = true

            };

            s106.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s106.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s106.Movie.Runtime / 60;
            minute = s106.Movie.Runtime % 60;
            s106.EndTime = new DateTime(2023, 12, 1, s106.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s106);


            Showtime s107 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 1, 15, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 1, 15, 30, 0),
                Approved = true

            };

            s107.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s107.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s107.Movie.Runtime / 60;
            minute = s107.Movie.Runtime % 60;
            s107.EndTime = new DateTime(2023, 12, 1, s107.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s107);


            Showtime s108 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 1, 18, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 1, 18, 0, 0),
                Approved = true

            };

            s108.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s108.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s108.Movie.Runtime / 60;
            minute = s108.Movie.Runtime % 60;
            s108.EndTime = new DateTime(2023, 12, 1, s108.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s108);


            Showtime s109 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 1, 20, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = true,
                StartTime = new DateTime(2023, 12, 1, 20, 0, 0),
                Approved = true

            };

            s109.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.SpecialEvent);
            s109.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot");

            hour = s109.Movie.Runtime / 60;
            minute = s109.Movie.Runtime % 60;
            s109.EndTime = new DateTime(2023, 12, 1, s109.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s109);


            Showtime s110 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 1, 22, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 1, 22, 0, 0),
                Approved = true

            };

            s110.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s110.Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show");

            hour = s110.Movie.Runtime / 60;
            minute = s110.Movie.Runtime % 60;
            s110.EndTime = new DateTime(2023, 12, 1, s110.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s110);


            Showtime s111 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 2, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 2, 9, 0, 0),
                Approved = true

            };

            s111.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s111.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic");

            hour = s111.Movie.Runtime / 60;
            minute = s111.Movie.Runtime % 60;
            s111.EndTime = new DateTime(2023, 12, 2, s111.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s111);


            Showtime s112 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 2, 12, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 2, 12, 0, 0),
                Approved = true

            };

            s112.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s112.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge");

            hour = s112.Movie.Runtime / 60;
            minute = s112.Movie.Runtime % 60;
            s112.EndTime = new DateTime(2023, 12, 2, s112.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s112);


            Showtime s113 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 2, 15, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 2, 15, 0, 0),
                Approved = true

            };

            s113.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s113.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey");

            hour = s113.Movie.Runtime / 60;
            minute = s113.Movie.Runtime % 60;
            s113.EndTime = new DateTime(2023, 12, 2, s113.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s113);


            Showtime s114 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 2, 18, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 2, 18, 0, 0),
                Approved = true

            };

            s114.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s114.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug");

            hour = s114.Movie.Runtime / 60;
            minute = s114.Movie.Runtime % 60;
            s114.EndTime = new DateTime(2023, 12, 2, s114.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s114);


            Showtime s115 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 2, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 2, 21, 0, 0),
                Approved = true

            };

            s115.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s115.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies");

            hour = s115.Movie.Runtime / 60;
            minute = s115.Movie.Runtime % 60;
            s115.EndTime = new DateTime(2023, 12, 2, s115.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s115);


            Showtime s116 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 2, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 2, 9, 0, 0),
                Approved = true

            };

            s116.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s116.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s116.Movie.Runtime / 60;
            minute = s116.Movie.Runtime % 60;
            s116.EndTime = new DateTime(2023, 12, 2, s116.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s116);


            Showtime s117 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 2, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 2, 11, 0, 0),
                Approved = true

            };

            s117.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s117.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s117.Movie.Runtime / 60;
            minute = s117.Movie.Runtime % 60;
            s117.EndTime = new DateTime(2023, 12, 2, s117.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s117);


            Showtime s118 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 2, 13, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 2, 13, 30, 0),
                Approved = true

            };

            s118.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s118.Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Fellowship of the Ring");

            hour = s118.Movie.Runtime / 60;
            minute = s118.Movie.Runtime % 60;
            s118.EndTime = new DateTime(2023, 12, 2, s118.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s118);


            Showtime s119 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 2, 16, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 2, 16, 30, 0),
                Approved = true

            };

            s119.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s119.Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers");

            hour = s119.Movie.Runtime / 60;
            minute = s119.Movie.Runtime % 60;
            s119.EndTime = new DateTime(2023, 12, 2, s119.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s119);


            Showtime s120 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 2, 19, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 2, 19, 30, 0),
                Approved = true

            };

            s120.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s120.Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King");

            hour = s120.Movie.Runtime / 60;
            minute = s120.Movie.Runtime % 60;
            s120.EndTime = new DateTime(2023, 12, 2, s120.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s120);


            Showtime s121 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 3, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 3, 9, 0, 0),
                Approved = true

            };

            s121.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s121.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic");

            hour = s121.Movie.Runtime / 60;
            minute = s121.Movie.Runtime % 60;
            s121.EndTime = new DateTime(2023, 12, 3, s121.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s121);


            Showtime s122 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 3, 12, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 3, 12, 0, 0),
                Approved = true

            };

            s122.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s122.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge");

            hour = s122.Movie.Runtime / 60;
            minute = s122.Movie.Runtime % 60;
            s122.EndTime = new DateTime(2023, 12, 3, s122.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s122);


            Showtime s123 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 3, 15, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 3, 15, 0, 0),
                Approved = true

            };

            s123.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s123.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey");

            hour = s123.Movie.Runtime / 60;
            minute = s123.Movie.Runtime % 60;
            s123.EndTime = new DateTime(2023, 12, 3, s123.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s123);


            Showtime s124 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 3, 18, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 3, 18, 0, 0),
                Approved = true

            };

            s124.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s124.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug");

            hour = s124.Movie.Runtime / 60;
            minute = s124.Movie.Runtime % 60;
            s124.EndTime = new DateTime(2023, 12, 3, s124.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s124);


            Showtime s125 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 3, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = true,
                StartTime = new DateTime(2023, 12, 3, 21, 0, 0),
                Approved = true

            };

            s125.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.SpecialEvent);
            s125.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies");

            hour = s125.Movie.Runtime / 60;
            minute = s125.Movie.Runtime % 60;
            s125.EndTime = new DateTime(2023, 12, 3, s125.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s125);


            Showtime s126 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 3, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 3, 9, 0, 0),
                Approved = true

            };

            s126.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s126.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s126.Movie.Runtime / 60;
            minute = s126.Movie.Runtime % 60;
            s126.EndTime = new DateTime(2023, 12, 3, s126.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s126);


            Showtime s127 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 3, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 3, 11, 0, 0),
                Approved = true

            };

            s127.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s127.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s127.Movie.Runtime / 60;
            minute = s127.Movie.Runtime % 60;
            s127.EndTime = new DateTime(2023, 12, 3, s127.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s127);


            Showtime s128 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 3, 13, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 3, 13, 30, 0),
                Approved = true

            };

            s128.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s128.Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Fellowship of the Ring");

            hour = s128.Movie.Runtime / 60;
            minute = s128.Movie.Runtime % 60;
            s128.EndTime = new DateTime(2023, 12, 3, s128.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s128);


            Showtime s129 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 3, 16, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 3, 16, 30, 0),
                Approved = true

            };

            s129.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekend);
            s129.Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers");

            hour = s129.Movie.Runtime / 60;
            minute = s129.Movie.Runtime % 60;
            s129.EndTime = new DateTime(2023, 12, 3, s129.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s129);


            Showtime s130 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 3, 19, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = true,
                StartTime = new DateTime(2023, 12, 3, 19, 30, 0),
                Approved = true

            };

            s130.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.SpecialEvent);
            s130.Movie = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King");

            hour = s130.Movie.Runtime / 60;
            minute = s130.Movie.Runtime % 60;
            s130.EndTime = new DateTime(2023, 12, 3, s130.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s130);


            Showtime s131 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 4, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 4, 9, 0, 0),
                Approved = true

            };

            s131.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s131.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s131.Movie.Runtime / 60;
            minute = s131.Movie.Runtime % 60;
            s131.EndTime = new DateTime(2023, 12, 4, s131.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s131);


            Showtime s132 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 4, 11, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 4, 11, 0, 0),
                Approved = true

            };

            s132.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s132.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s132.Movie.Runtime / 60;
            minute = s132.Movie.Runtime % 60;
            s132.EndTime = new DateTime(2023, 12, 4, s132.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s132);


            Showtime s133 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 4, 13, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 4, 13, 30, 0),
                Approved = true

            };

            s133.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s133.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic");

            hour = s133.Movie.Runtime / 60;
            minute = s133.Movie.Runtime % 60;
            s133.EndTime = new DateTime(2023, 12, 4, s133.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s133);


            Showtime s134 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 4, 16, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 4, 16, 30, 0),
                Approved = true

            };

            s134.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s134.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s134.Movie.Runtime / 60;
            minute = s134.Movie.Runtime % 60;
            s134.EndTime = new DateTime(2023, 12, 4, s134.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s134);


            Showtime s135 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 4, 19, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 4, 19, 0, 0),
                Approved = true

            };

            s135.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s135.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s135.Movie.Runtime / 60;
            minute = s135.Movie.Runtime % 60;
            s135.EndTime = new DateTime(2023, 12, 4, s135.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s135);


            Showtime s136 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 4, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 4, 21, 0, 0),
                Approved = true

            };

            s136.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s136.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s136.Movie.Runtime / 60;
            minute = s136.Movie.Runtime % 60;
            s136.EndTime = new DateTime(2023, 12, 4, s136.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s136);


            Showtime s137 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 4, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 4, 9, 0, 0),
                Approved = true

            };

            s137.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s137.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s137.Movie.Runtime / 60;
            minute = s137.Movie.Runtime % 60;
            s137.EndTime = new DateTime(2023, 12, 4, s137.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s137);


            Showtime s138 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 4, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 4, 11, 0, 0),
                Approved = true

            };

            s138.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s138.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s138.Movie.Runtime / 60;
            minute = s138.Movie.Runtime % 60;
            s138.EndTime = new DateTime(2023, 12, 4, s138.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s138);


            Showtime s139 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 4, 13, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 4, 13, 0, 0),
                Approved = true

            };

            s139.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s139.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s139.Movie.Runtime / 60;
            minute = s139.Movie.Runtime % 60;
            s139.EndTime = new DateTime(2023, 12, 4, s139.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s139);


            Showtime s140 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 4, 15, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 4, 15, 30, 0),
                Approved = true

            };

            s140.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s140.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s140.Movie.Runtime / 60;
            minute = s140.Movie.Runtime % 60;
            s140.EndTime = new DateTime(2023, 12, 4, s140.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s140);


            Showtime s141 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 4, 18, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 4, 18, 0, 0),
                Approved = true

            };

            s141.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s141.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s141.Movie.Runtime / 60;
            minute = s141.Movie.Runtime % 60;
            s141.EndTime = new DateTime(2023, 12, 4, s141.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s141);


            Showtime s142 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 4, 20, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 4, 20, 0, 0),
                Approved = true

            };

            s142.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s142.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot");

            hour = s142.Movie.Runtime / 60;
            minute = s142.Movie.Runtime % 60;
            s142.EndTime = new DateTime(2023, 12, 4, s142.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s142);


            Showtime s143 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 4, 22, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 4, 22, 0, 0),
                Approved = true

            };

            s143.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s143.Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show");

            hour = s143.Movie.Runtime / 60;
            minute = s143.Movie.Runtime % 60;
            s143.EndTime = new DateTime(2023, 12, 4, s143.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s143);


            Showtime s144 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 5, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 5, 9, 0, 0),
                Approved = true

            };

            s144.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s144.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s144.Movie.Runtime / 60;
            minute = s144.Movie.Runtime % 60;
            s144.EndTime = new DateTime(2023, 12, 5, s144.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s144);


            Showtime s145 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 5, 11, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 5, 11, 0, 0),
                Approved = true

            };

            s145.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s145.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s145.Movie.Runtime / 60;
            minute = s145.Movie.Runtime % 60;
            s145.EndTime = new DateTime(2023, 12, 5, s145.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s145);


            Showtime s146 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 5, 13, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 5, 13, 30, 0),
                Approved = true

            };

            s146.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.DiscountTuesday);
            s146.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge");

            hour = s146.Movie.Runtime / 60;
            minute = s146.Movie.Runtime % 60;
            s146.EndTime = new DateTime(2023, 12, 5, s146.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s146);


            Showtime s147 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 5, 16, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 5, 16, 30, 0),
                Approved = true

            };

            s147.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.DiscountTuesday);
            s147.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s147.Movie.Runtime / 60;
            minute = s147.Movie.Runtime % 60;
            s147.EndTime = new DateTime(2023, 12, 5, s147.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s147);


            Showtime s148 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 5, 19, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 5, 19, 0, 0),
                Approved = true

            };

            s148.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s148.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s148.Movie.Runtime / 60;
            minute = s148.Movie.Runtime % 60;
            s148.EndTime = new DateTime(2023, 12, 5, s148.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s148);


            Showtime s149 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 5, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 5, 21, 0, 0),
                Approved = true

            };

            s149.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s149.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s149.Movie.Runtime / 60;
            minute = s149.Movie.Runtime % 60;
            s149.EndTime = new DateTime(2023, 12, 5, s149.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s149);


            Showtime s150 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 5, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 5, 9, 0, 0),
                Approved = true

            };

            s150.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s150.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s150.Movie.Runtime / 60;
            minute = s150.Movie.Runtime % 60;
            s150.EndTime = new DateTime(2023, 12, 5, s150.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s150);


            Showtime s151 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 5, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 5, 11, 0, 0),
                Approved = true

            };

            s151.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s151.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s151.Movie.Runtime / 60;
            minute = s151.Movie.Runtime % 60;
            s151.EndTime = new DateTime(2023, 12, 5, s151.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s151);


            Showtime s152 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 5, 13, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 5, 13, 0, 0),
                Approved = true

            };

            s152.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.DiscountTuesday);
            s152.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s152.Movie.Runtime / 60;
            minute = s152.Movie.Runtime % 60;
            s152.EndTime = new DateTime(2023, 12, 5, s152.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s152);


            Showtime s153 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 5, 15, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 5, 15, 30, 0),
                Approved = true

            };

            s153.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.DiscountTuesday);
            s153.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s153.Movie.Runtime / 60;
            minute = s153.Movie.Runtime % 60;
            s153.EndTime = new DateTime(2023, 12, 5, s153.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s153);


            Showtime s154 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 5, 18, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 5, 18, 0, 0),
                Approved = true

            };

            s154.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s154.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s154.Movie.Runtime / 60;
            minute = s154.Movie.Runtime % 60;
            s154.EndTime = new DateTime(2023, 12, 5, s154.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s154);


            Showtime s155 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 5, 20, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 5, 20, 0, 0),
                Approved = true

            };

            s155.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s155.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot");

            hour = s155.Movie.Runtime / 60;
            minute = s155.Movie.Runtime % 60;
            s155.EndTime = new DateTime(2023, 12, 5, s155.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s155);


            Showtime s156 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 5, 22, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 5, 22, 0, 0),
                Approved = true

            };

            s156.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s156.Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show");

            hour = s156.Movie.Runtime / 60;
            minute = s156.Movie.Runtime % 60;
            s156.EndTime = new DateTime(2023, 12, 5, s156.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s156);


            Showtime s157 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 6, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 6, 9, 0, 0),
                Approved = true

            };

            s157.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s157.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s157.Movie.Runtime / 60;
            minute = s157.Movie.Runtime % 60;
            s157.EndTime = new DateTime(2023, 12, 6, s157.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s157);


            Showtime s158 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 6, 11, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 6, 11, 0, 0),
                Approved = true

            };

            s158.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s158.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s158.Movie.Runtime / 60;
            minute = s158.Movie.Runtime % 60;
            s158.EndTime = new DateTime(2023, 12, 6, s158.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s158);


            Showtime s159 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 6, 13, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 6, 13, 30, 0),
                Approved = true

            };

            s159.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s159.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic");

            hour = s159.Movie.Runtime / 60;
            minute = s159.Movie.Runtime % 60;
            s159.EndTime = new DateTime(2023, 12, 6, s159.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s159);


            Showtime s160 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 6, 16, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 6, 16, 30, 0),
                Approved = true

            };

            s160.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s160.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s160.Movie.Runtime / 60;
            minute = s160.Movie.Runtime % 60;
            s160.EndTime = new DateTime(2023, 12, 6, s160.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s160);


            Showtime s161 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 6, 19, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 6, 19, 0, 0),
                Approved = true

            };

            s161.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s161.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s161.Movie.Runtime / 60;
            minute = s161.Movie.Runtime % 60;
            s161.EndTime = new DateTime(2023, 12, 6, s161.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s161);


            Showtime s162 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 6, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 6, 21, 0, 0),
                Approved = true

            };

            s162.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s162.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s162.Movie.Runtime / 60;
            minute = s162.Movie.Runtime % 60;
            s162.EndTime = new DateTime(2023, 12, 6, s162.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s162);


            Showtime s163 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 6, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 6, 9, 0, 0),
                Approved = true

            };

            s163.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s163.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s163.Movie.Runtime / 60;
            minute = s163.Movie.Runtime % 60;
            s163.EndTime = new DateTime(2023, 12, 6, s163.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s163);


            Showtime s164 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 6, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 6, 11, 0, 0),
                Approved = true

            };

            s164.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s164.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s164.Movie.Runtime / 60;
            minute = s164.Movie.Runtime % 60;
            s164.EndTime = new DateTime(2023, 12, 6, s164.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s164);


            Showtime s165 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 6, 13, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 6, 13, 0, 0),
                Approved = true

            };

            s165.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s165.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s165.Movie.Runtime / 60;
            minute = s165.Movie.Runtime % 60;
            s165.EndTime = new DateTime(2023, 12, 6, s165.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s165);


            Showtime s166 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 6, 15, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 6, 15, 30, 0),
                Approved = true

            };

            s166.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s166.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s166.Movie.Runtime / 60;
            minute = s166.Movie.Runtime % 60;
            s166.EndTime = new DateTime(2023, 12, 6, s166.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s166);


            Showtime s167 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 6, 18, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 6, 18, 0, 0),
                Approved = true

            };

            s167.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s167.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s167.Movie.Runtime / 60;
            minute = s167.Movie.Runtime % 60;
            s167.EndTime = new DateTime(2023, 12, 6, s167.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s167);


            Showtime s168 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 6, 20, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 6, 20, 0, 0),
                Approved = true

            };

            s168.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s168.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot");

            hour = s168.Movie.Runtime / 60;
            minute = s168.Movie.Runtime % 60;
            s168.EndTime = new DateTime(2023, 12, 6, s168.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s168);


            Showtime s169 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 6, 22, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 6, 22, 0, 0),
                Approved = true

            };

            s169.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s169.Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show");

            hour = s169.Movie.Runtime / 60;
            minute = s169.Movie.Runtime % 60;
            s169.EndTime = new DateTime(2023, 12, 6, s169.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s169);


            Showtime s170 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 7, 9, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 7, 9, 0, 0),
                Approved = true

            };

            s170.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s170.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s170.Movie.Runtime / 60;
            minute = s170.Movie.Runtime % 60;
            s170.EndTime = new DateTime(2023, 12, 7, s170.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s170);


            Showtime s171 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 7, 11, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 7, 11, 0, 0),
                Approved = true

            };

            s171.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s171.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s171.Movie.Runtime / 60;
            minute = s171.Movie.Runtime % 60;
            s171.EndTime = new DateTime(2023, 12, 7, s171.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s171);


            Showtime s172 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 7, 13, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 7, 13, 30, 0),
                Approved = true

            };

            s172.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s172.Movie = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge");

            hour = s172.Movie.Runtime / 60;
            minute = s172.Movie.Runtime % 60;
            s172.EndTime = new DateTime(2023, 12, 7, s172.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s172);


            Showtime s173 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 7, 16, 30, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 7, 16, 30, 0),
                Approved = true

            };

            s173.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s173.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s173.Movie.Runtime / 60;
            minute = s173.Movie.Runtime % 60;
            s173.EndTime = new DateTime(2023, 12, 7, s173.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s173);


            Showtime s174 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 7, 19, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 7, 19, 0, 0),
                Approved = true

            };

            s174.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s174.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s174.Movie.Runtime / 60;
            minute = s174.Movie.Runtime % 60;
            s174.EndTime = new DateTime(2023, 12, 7, s174.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s174);


            Showtime s175 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 7, 21, 0, 0),
                Theater = Theater.Theater1,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 7, 21, 0, 0),
                Approved = true

            };

            s175.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s175.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s175.Movie.Runtime / 60;
            minute = s175.Movie.Runtime % 60;
            s175.EndTime = new DateTime(2023, 12, 7, s175.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s175);


            Showtime s176 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 7, 9, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 7, 9, 0, 0),
                Approved = true

            };

            s176.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s176.Movie = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7");

            hour = s176.Movie.Runtime / 60;
            minute = s176.Movie.Runtime % 60;
            s176.EndTime = new DateTime(2023, 12, 7, s176.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s176);


            Showtime s177 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 7, 11, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 7, 11, 0, 0),
                Approved = true

            };

            s177.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Matinee);
            s177.Movie = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park");

            hour = s177.Movie.Runtime / 60;
            minute = s177.Movie.Runtime % 60;
            s177.EndTime = new DateTime(2023, 12, 7, s177.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s177);


            Showtime s178 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 7, 13, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 7, 13, 0, 0),
                Approved = true

            };

            s178.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s178.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty");

            hour = s178.Movie.Runtime / 60;
            minute = s178.Movie.Runtime % 60;
            s178.EndTime = new DateTime(2023, 12, 7, s178.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s178);


            Showtime s179 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 7, 15, 30, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 7, 15, 30, 0),
                Approved = true

            };

            s179.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s179.Movie = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management");

            hour = s179.Movie.Runtime / 60;
            minute = s179.Movie.Runtime % 60;
            s179.EndTime = new DateTime(2023, 12, 7, s179.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s179);


            Showtime s180 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 7, 18, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 7, 18, 0, 0),
                Approved = true

            };

            s180.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s180.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Goonies");

            hour = s180.Movie.Runtime / 60;
            minute = s180.Movie.Runtime % 60;
            s180.EndTime = new DateTime(2023, 12, 7, s180.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s180);


            Showtime s181 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 7, 20, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 7, 20, 0, 0),
                Approved = true

            };

            s181.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s181.Movie = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot");

            hour = s181.Movie.Runtime / 60;
            minute = s181.Movie.Runtime % 60;
            s181.EndTime = new DateTime(2023, 12, 7, s181.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s181);


            Showtime s182 = new Showtime()
            {
                ShowingTime = new DateTime(2023, 12, 7, 22, 0, 0),
                Theater = Theater.Theater2,
                SpecialEvent = false,
                StartTime = new DateTime(2023, 12, 7, 22, 0, 0),
                Approved = true

            };

            s182.Price = db.Prices.FirstOrDefault(p => p.TicketType == TicketType.Weekday);
            s182.Movie = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show");

            hour = s182.Movie.Runtime / 60;
            minute = s182.Movie.Runtime % 60;
            s182.EndTime = new DateTime(2023, 12, 7, s182.ShowingTime.Hour + hour, minute, 0);
            Showtimes.Add(s182);



            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (Showtime showtimeToAdd in Showtimes)
                {
                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    Showtime dbShowtime = db.Showtimes.FirstOrDefault(s => s.ShowtimeID == showtimeToAdd.ShowtimeID);

                    //if the dbBook is null, this title is not in the database
                    if (dbShowtime == null)
                    {
                        //add the book to the database and save changes
                        db.Showtimes.Add(showtimeToAdd);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intShowtimesAdded += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties
                        dbShowtime.ShowingTime = showtimeToAdd.ShowingTime;
                        dbShowtime.Theater = showtimeToAdd.Theater;
                        dbShowtime.SpecialEvent = showtimeToAdd.SpecialEvent;
                        dbShowtime.StartTime = showtimeToAdd.StartTime;

                        //since we found the correct genre object in a previous step,
                        //this update is easy - both dbBook and bookToAdd have a Genre 
                        //object for this property
                        dbShowtime.Price = showtimeToAdd.Price;
                        dbShowtime.Movie = showtimeToAdd.Movie;

                        //update the database and save the changes
                        db.Update(dbShowtime);
                        db.SaveChanges();

                        intShowtimesAdded += 1;

                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                //Build a messsage using the flags we created
                String msg = "  Repositories added:" + intShowtimesAdded + "; Error on " + intShowtimesAdded;

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            } 
            //ClearDatabase(db);
        }

        private static void ClearDatabase(AppDbContext db)
        {
            var showtimes = db.Showtimes;
            db.Showtimes.RemoveRange(showtimes);
            db.SaveChanges();
        }
    }
}



