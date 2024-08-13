using Group_26_Final_Project.DAL;
using System;
using System.Linq;


namespace Group_26_Final_Project.Utilities
{
    public static class GenerateNextOrderNumber
    {
        public static Int32 GetNextOrderNumber(AppDbContext _context)
        {
            //set a constant to designate where the registration numbers 
            //should start
            const Int32 START_NUMBER = 3001;

            Int32 MaxMovieNum;
            Int32 NextMovieNum;

            if (_context.Movies.Count() == 0) //there are no registrations in the database yet
            {
                MaxMovieNum = START_NUMBER; //registration numbers start at 101
            }
            else
            {
                MaxMovieNum = _context.Movies.Max(c => c.MovieNumber); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (MaxMovieNum < START_NUMBER)
            {
                MaxMovieNum = START_NUMBER;
            }

            //add one to the current max to find the next one
            NextMovieNum = MaxMovieNum + 1;

            //return the value
            return NextMovieNum;
        }

}

}

