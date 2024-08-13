using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc.Rendering;

using Microsoft.EntityFrameworkCore;

using Group_26_Final_Project.DAL;

using Group_26_Final_Project.Models;



namespace Group_26_Final_Project.Controllers

{

    public class MoviesController : Controller

    {

        private readonly AppDbContext _context;



        public MoviesController(AppDbContext context)

        {

            _context = context;

        }

        // GET: Movies/Index
        public IActionResult Index(string SearchString)

        {
            var query = from m in _context.Movies
                        select m;

            if (SearchString != null)
            {
                query = query.Where(m => m.Title.Contains(SearchString));
            }

            List<Movie> SelectedMovies = query.Include(m => m.Genre).ToList();

            foreach (var movie in SelectedMovies)
            {
                //movie.AverageRating = CalculateAverageRating(movie.MovieID);
            }

            ViewBag.AllMovies = _context.Movies.Count();
            ViewBag.SelectedMovies = SelectedMovies.Count();


            return View("Index", SelectedMovies.OrderBy(m => m.MovieID));

        }

        private double? CalculateAverageRating(int movieId)
        {
            var ratings = _context.Reviews
            .Where(r => r.Movie.MovieID == movieId && r.ReviewStatus == ReviewStatus.Approved)
            .Select(r => r.Rating);

            if (ratings.Any())
            {
                return (double)ratings.Average();
            }
            else
            {
                return null; // Handle the case when there are no ratings
            }
        }

        // GET: Movies/Details

        public IActionResult Details(int? id)

        {

            if (id == null)

            {

                return NotFound();

            }

            Movie movie = _context.Movies.Include(m => m.Genre).FirstOrDefault(j => j.MovieID == id);



            List<Showtime> movieShowtimes = new List<Showtime>();
            movieShowtimes = _context.Showtimes
            .Where(s => s.Movie.MovieID == movie.MovieID && s.Approved == true)
            .OrderBy(s => s.ShowingTime)
            .ToList();



            ViewBag.MovieShowtimes = movieShowtimes;



            List<Review> movieReviews = new List<Review>();
            movieReviews = _context.Reviews
            .Include(r => r.Customer)
            .Where(s => s.Movie.MovieID == movie.MovieID)
            .OrderByDescending(s => s.Rating)
            .ToList();



            foreach (var review in movieReviews)
            {
                review.ReviewText = string.IsNullOrEmpty(review.ReviewText) || review.ReviewText.ToLower() == "nan"
                ? string.Empty
                : review.ReviewText;
            }



            ViewBag.MovieReviews = movieReviews;


            if (movie == null)

            {

                return NotFound();
            }

            return View(movie);

        }

        public IActionResult DetailedSearch()

        {

            ViewBag.AllGenres = GetAllGenresList();

            SearchViewModel svm = new SearchViewModel();

            svm.SelectedGenre = 0;

            svm.SelectedMPAARating = 0;



            var movies = _context.Movies.Include(m => m.Genre).ToList();

            svm.Movies = movies;


            return View(svm);
        }

        public SelectList GetAllGenresList()

        {

            List<Genre> genreList = _context.Genres.ToList();



            Genre SelectNone = new Genre() { GenreID = 0, GenreName = "All Genres" };



            genreList.Add(SelectNone);



            SelectList genreSelectList = new SelectList(genreList.OrderBy(m => m.GenreID), "GenreID", "GenreName");



            return genreSelectList;

        }

        public SelectList GetAllGenres()

        {

            List<Genre> genreList = _context.Genres.ToList();



            SelectList genreSelectList = new SelectList(genreList.OrderBy(m => m.GenreID), "GenreID", "GenreName");



            return genreSelectList;

        }

        /*//GET: Movies/Create
        [Authorize(Roles = "Manager")]
        public IActionResult Create(Movie movie)
        {
            ViewBag.AllGenres = GetAllGenresList();
            return View(movie);
        }*/

        //GET: Movies/Create
        [Authorize(Roles = "Manager")]
        public IActionResult Create()
        {
            ViewBag.AllGenres = GetAllGenres();
            return View();
        }



        // POST: Movies/Create

        // To protect from overposting attacks, enable the specific properties you want to bind to.

        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]

        [ValidateAntiForgeryToken]

        public IActionResult Create(Movie movie, int[] SelectedGenre)
        {
            movie.MovieNumber = Utilities.GenerateNextMovieNumber.GetNextMovieNum(_context);

            if (SelectedGenre == null)
            {
                ViewBag.AllGenres = GetAllGenres();
                return View(movie);
            }


            if (ModelState.IsValid)
            {
                Genre dbGenre = _context.Genres.Find(SelectedGenre);

                movie.Genre = dbGenre;
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Details", "Movies", new { id = movie.MovieID });

            }

            return View(movie);
        }

        public ActionResult DisplaySearchResults(SearchViewModel svm)

        {

            var query = from c in _context.Movies.Include(m => m.Genre)

                        select c;



            // search by title

            if (svm.Title != null && svm.Title != "")

            {

                query = query.Where(c => c.Title.Contains(svm.Title));

            }



            // search by tagline

            if (svm.Tagline != null && svm.Tagline != "")

            {

                query = query.Where(c => c.Tagline.Contains(svm.Tagline));

            }



            // search by category

            if (svm.SelectedGenre != 0)

            {

                query = query.Where(c => c.Genre.GenreID == svm.SelectedGenre);

            }



            if (svm.SelectedMPAARating != 0)
            {
                query = query.Where(m => m.MPAARating == svm.SelectedMPAARating);
            }

            // search by tagline

            if (svm.ReleaseYear != null)

            {

                query = query.Where(c => c.ReleaseYear == svm.ReleaseYear);

            }

            if (svm.Actors != null)

            {

                query = query.Where(c => c.Actors.Contains(svm.Actors));

            }

            if (svm.RatingSearch.HasValue && svm.AvgRatingSearch.HasValue)
            {
                var statusToCheck = ReviewStatus.Approved;
                decimal ratingSearch = svm.RatingSearch.Value;

                if (svm.AvgRatingSearch == AvgRatingSearch.GreaterThan)
                {
                    query = query
                    .Where(c => c.Reviews
                    .Any(r => r.ReviewStatus == statusToCheck) &&
                    (decimal)c.Reviews
                    .Where(r => r.ReviewStatus == statusToCheck)
                    .Average(r => r.Rating) > ratingSearch);
                }
                else if (svm.AvgRatingSearch == AvgRatingSearch.LessThan)
                {
                    query = query
                    .Where(c => c.Reviews
                    .Any(r => r.ReviewStatus == statusToCheck) &&
                    (decimal)c.Reviews
                    .Where(r => r.ReviewStatus == statusToCheck)
                    .Average(r => r.Rating) < ratingSearch);
                }
            }


            List<Movie> SelectedMovies = query.ToList();

            //Populate the view bag with a count of all the job postings
            ViewBag.AllMovies = _context.Movies.Count();



            //Populate the view bag with a count of all the filtered job postings

            ViewBag.SelectedMovies = SelectedMovies.Count();

            return View("Index", SelectedMovies);

        }

        public ActionResult ShowingTimeSearch()
        {
            return View();
        }

        /*public ActionResult DisplayShowSearch(DateTime ShowDate)
        {

            var query = from s in _context.Showtimes.Include(m => m.Movie)
                        select s;

            query = query.Where(s => s.ShowingTime.Date == ShowDate.Date);

            List<Movie> SelectedShowtimes = query.Include(m => m.ShowingTime).ToList();
            List<Movie> SelectedMovies = new List<Movie>();

            foreach (Showtime s in qShowings)
            {
                Movie m = _context.Movies.Find(s.Movie.MovieID);
                if (SelectedMovies.Contains(m) == false)
                { SelectedMovies.Add(m); }
            }

            ViewBag.TotalMovies = _context.Movies.Count();
            ViewBag.DisplayedMovies = SelectedMovies.Count();

            SelectedMovies.OrderByDescending(m => m.Title);

            return View("Index", SelectedMovies);


        }


        public IActionResult Index(string SearchString)

        {
            var query = from m in _context.Movies
                        select m;

            if (SearchString != null)
            {
                query = query.Where(m => m.Title.Contains(SearchString));
            }

            List<Movie> SelectedMovies = query.Include(m => m.Genre).ToList();

            foreach (var movie in SelectedMovies)
            {
                //movie.AverageRating = CalculateAverageRating(movie.MovieID);
            }

            ViewBag.AllMovies = _context.Movies.Count();
            ViewBag.SelectedMovies = SelectedMovies.Count();


            return View("Index", SelectedMovies.OrderBy(m => m.MovieID));

        }*/





        // GET: Movies/Edit/5

        public async Task<IActionResult> Edit(int? id)

        {

            if (id == null || _context.Movies == null)

            {

                return NotFound();

            }



            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)

            {

                return NotFound();

            }

            return View(movie);

        }



        // POST: Movies/Edit/5

        // To protect from overposting attacks, enable the specific properties you want to bind to.

        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]

        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, [Bind("MovieID,Title,Description,Tagline,Runtime,Actors,ReleaseYear,MPAARating")] Movie movie)

        {

            if (id != movie.MovieID)

            {

                return NotFound();

            }



            if (ModelState.IsValid)

            {

                try

                {

                    _context.Update(movie);

                    await _context.SaveChangesAsync();

                }

                catch (DbUpdateConcurrencyException)

                {

                    if (!MovieExists(movie.MovieID))

                    {

                        return NotFound();

                    }

                    else

                    {

                        throw;

                    }

                }

                return RedirectToAction(nameof(Index));

            }

            return View(movie);

        }



        // GET: Movies/Delete/5

        public async Task<IActionResult> Delete(int? id)

        {

            if (id == null || _context.Movies == null)

            {

                return NotFound();

            }



            var movie = await _context.Movies

            .FirstOrDefaultAsync(m => m.MovieID == id);

            if (movie == null)

            {

                return NotFound();

            }



            return View(movie);

        }



        // POST: Movies/Delete/5

        [HttpPost, ActionName("Delete")]

        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(int id)

        {

            if (_context.Movies == null)

            {

                return Problem("Entity set 'AppDbContext.Movies'  is null.");

            }

            var movie = await _context.Movies.FindAsync(id);

            if (movie != null)

            {

                _context.Movies.Remove(movie);

            }



            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }



        private bool MovieExists(int id)

        {

            return (_context.Movies?.Any(e => e.MovieID == id)).GetValueOrDefault();

        }

    }

}