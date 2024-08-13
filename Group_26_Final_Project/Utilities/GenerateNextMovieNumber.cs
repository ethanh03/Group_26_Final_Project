using System;
using Group_26_Final_Project.DAL;

namespace Group_26_Final_Project.Utilities
{
	public class GenerateNextMovieNumber
	{
        public static Int32 GetNextMovieNum(AppDbContext _context)
        {
            const Int32 START_NUMBER = 3001;

            Int32 MaxMovieNum;
            Int32 NextMovieNum;

            if (_context.Movies.Count() == 0)
            {
                MaxMovieNum = 3000;
            }
            else
            {
                MaxMovieNum = _context.Movies.Max(m => m.MovieNumber);
            }

            NextMovieNum = MaxMovieNum + 1;

            return NextMovieNum;
        }
    }
}

