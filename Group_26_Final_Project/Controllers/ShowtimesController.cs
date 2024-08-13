using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group_26_Final_Project.DAL;
using Group_26_Final_Project.Models;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace Group_26_Final_Project.Controllers
{
    [Authorize (Roles = "Manager")]
    public class ShowtimesController : Controller
    {
        private readonly AppDbContext _context;

        public ShowtimesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Showtimes
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
              return _context.Showtimes != null ? 
                          View(await _context.Showtimes.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Showtimes'  is null.");
        }
        [AllowAnonymous]
        public async Task<IActionResult> TheaterOneIndex()
        {
            return _context.Showtimes != null ?
                        View(await _context.Showtimes.Where(s => s.Theater == Theater.Theater1 && s.Approved == true).ToListAsync()) :
                        Problem("Entity set 'AppDbContext.Showtimes'  is null.");
        }
        [AllowAnonymous]
        public async Task<IActionResult> TheaterTwoIndex()
        {
            return _context.Showtimes != null ?
                        View(await _context.Showtimes.Where(s => s.Theater == Theater.Theater2 && s.Approved == true).ToListAsync()) :
                        Problem("Entity set 'AppDbContext.Showtimes'  is null.");
        }

        public async Task<IActionResult> UpcomingScheduleTheaterOne()
        {
            DateTime nextScheduleStart = new DateTime(2023, 11, 23, 12, 0, 0);
            DateTime nextScheduleEnd = new DateTime(2023, 11, 23, 12, 0, 0);

            nextScheduleStart = nextScheduleStart.AddDays(1);
            nextScheduleEnd = nextScheduleEnd.AddDays(1);

            while (nextScheduleStart.DayOfWeek != DayOfWeek.Thursday)
            {
                nextScheduleStart = nextScheduleStart.AddDays(1);
                nextScheduleEnd = nextScheduleEnd.AddDays(1);
            }

            nextScheduleStart = nextScheduleStart.AddDays(8);
            nextScheduleEnd = nextScheduleEnd.AddDays(14);

            return _context.Showtimes != null ?
                        View(await _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day >= nextScheduleStart.Day && s.ShowingTime.Day <= nextScheduleEnd.Day && s.Theater == Theater.Theater1).OrderBy(s => s.ShowingTime).ToListAsync()) :
                        Problem("Entity set 'AppDbContext.Showtimes'  is null.");
        }

        public async Task<IActionResult> UpcomingScheduleTheaterTwo()
        {
            DateTime nextScheduleStart = new DateTime(2023, 11, 23, 12, 0, 0);
            DateTime nextScheduleEnd = new DateTime(2023, 11, 23, 12, 0, 0);

            nextScheduleStart = nextScheduleStart.AddDays(1);
            nextScheduleEnd = nextScheduleEnd.AddDays(1);

            while (nextScheduleStart.DayOfWeek != DayOfWeek.Thursday)
            {
                nextScheduleStart = nextScheduleStart.AddDays(1);
                nextScheduleEnd = nextScheduleEnd.AddDays(1);
            }

            nextScheduleStart = nextScheduleStart.AddDays(8);
            nextScheduleEnd = nextScheduleEnd.AddDays(14);

            return _context.Showtimes != null ?
                        View(await _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day >= nextScheduleStart.Day && s.ShowingTime.Day <= nextScheduleEnd.Day && s.Theater == Theater.Theater2).OrderBy(s => s.ShowingTime).ToListAsync()) :
                        Problem("Entity set 'AppDbContext.Showtimes'  is null.");
        }

        public ActionResult ShowingTimeSearch()
        {
            return View();
        }

        public ActionResult DisplayShowSearch(DateTime ShowDate)
        {

            var query = from s in _context.Showtimes.Include(m => m.Movie)
                        select s;

            query = query.Where(s => s.ShowtimeID != null);
            query = query.Where(s => s.Approved == true);
            query = query.Where(s => s.ShowingTime.Date == ShowDate.Date);

            List<Showtime> qShowings = query.ToList();


            List<Movie> SelectedMovies = new List<Movie>();

            foreach (Showtime s in qShowings)
            {
                Movie m = _context.Movies.Find(s.Movie.MovieID);
                if (SelectedMovies.Contains(m) == false)
                { SelectedMovies.Add(m); }
            }

            ViewBag.TotalMovies = _context.Showtimes.Include(m => m.Movie).Count();
            ViewBag.DisplayedMovies = SelectedMovies.Count();

            SelectedMovies.OrderByDescending(m => m.Title);

            return View("Index", SelectedMovies);


        }


        // GET: Showtimes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Showtimes == null)
            {
                return NotFound();
            }

            var showtime = await _context.Showtimes
                .FirstOrDefaultAsync(m => m.ShowtimeID == id);
            if (showtime == null)
            {
                return NotFound();
            }

            return View(showtime);
        }

        private SelectList GetAllMoviesSelectList()
        {
            //Get the list of months from the database
            List<Movie> movieList = _context.Movies.ToList();

            //convert the list to a SelectList by calling SelectList constructor
            //MonthID and MonthName are the names of the properties on the Month class
            //MonthID is the primary key
            SelectList movieSelectList = new SelectList(movieList.OrderBy(m => m.MovieID), "MovieID", "Title");

            //return the electList
            return movieSelectList;
        }

        private SelectList GetAllPricesSelectList()
        {
            //Get the list of months from the database
            List<Price> priceList = _context.Prices.ToList();

            //convert the list to a SelectList by calling SelectList constructor
            //MonthID and MonthName are the names of the properties on the Month class
            //MonthID is the primary key
            SelectList priceSelectList = new SelectList(priceList.OrderBy(p => p.PriceID), "PriceID", "TicketType");

            //return the electList
            return priceSelectList;
        }

        // GET: Showtimes/Create
        public IActionResult Create(Showtime newShowtime)
        {
            ViewBag.AllMovies = GetAllMoviesSelectList();
            ViewBag.AllPrices = GetAllPricesSelectList();

            return View(newShowtime);
        }

        // POST: Showtimes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Showtime showtime, int SelectedMovie, int SelectedPrice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(showtime);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            Movie dbMovie = _context.Movies.Find(SelectedMovie);
            Price dbPrice = _context.Prices.Find(SelectedPrice);


            showtime.Movie = dbMovie;
            showtime.Price = dbPrice;

            // Set showtime start and end times
            showtime.StartTime = showtime.ShowingTime;
            showtime.EndTime = showtime.ShowingTime;

            Int32 hour = showtime.Movie.Runtime / 60;
            Int32 minute = showtime.Movie.Runtime % 60;

            showtime.EndTime = showtime.EndTime?.AddHours(hour);
            showtime.EndTime = showtime.EndTime?.AddMinutes(minute);

            //if code gets this far, add the registration to the database
            _context.Add(showtime);
            await _context.SaveChangesAsync();

            // send manager to index page
            return RedirectToAction("Index");
        }

        // GET: Showtimes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Showtimes == null)
            {
                return NotFound();
            }

            var showtime = await _context.Showtimes.FindAsync(id);
            if (showtime == null)
            {
                return NotFound();
            }
            return View(showtime);
        }

        // POST: Showtimes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShowtimeID,ShowingTime,Theater,SpecialEvent,StartTime,EndTime")] Showtime showtime)
        {
            if (id != showtime.ShowtimeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(showtime);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShowtimeExists(showtime.ShowtimeID))
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
            return View(showtime);
        }

        // GET: Showtimes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Showtimes == null)
            {
                return NotFound();
            }

            var showtime = await _context.Showtimes
                .FirstOrDefaultAsync(m => m.ShowtimeID == id);
            if (showtime == null)
            {
                return NotFound();
            }

            return View(showtime);
        }

        // POST: Showtimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Showtimes == null)
            {
                return Problem("Entity set 'AppDbContext.Showtimes'  is null.");
            }
            var showtime = await _context.Showtimes.FindAsync(id);
            if (showtime != null)
            {
                _context.Showtimes.Remove(showtime);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShowtimeExists(int id)
        {
          return (_context.Showtimes?.Any(e => e.ShowtimeID == id)).GetValueOrDefault();
        }

        

        public async Task<IActionResult> PublishTheaterOneScheduleAsync()
        {
            // Get all showings from upcoming schedule for Theater One
            List<Showtime> upcomingTheaterOneShowtimes = new List<Showtime>();

            DateTime nextScheduleStart = new DateTime(2023, 11, 23, 12, 0, 0);
            DateTime nextScheduleEnd = new DateTime(2023, 11, 23, 12, 0, 0);

            nextScheduleStart = nextScheduleStart.AddDays(1);

            while (nextScheduleStart.DayOfWeek != DayOfWeek.Thursday)
            {
                nextScheduleStart = nextScheduleStart.AddDays(1);
            }

            nextScheduleStart = nextScheduleStart.AddDays(8);

            DateTime currentDay = new DateTime();
            currentDay = nextScheduleStart;

            List<Showtime> fridayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater1).OrderBy(s => s.ShowingTime).ToList();
            currentDay = currentDay.AddDays(1);
            List<Showtime> saturdayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater1).OrderBy(s => s.ShowingTime).ToList();
            currentDay = currentDay.AddDays(1);
            List<Showtime> sundayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater1).OrderBy(s => s.ShowingTime).ToList();
            currentDay = currentDay.AddDays(1);
            List<Showtime> mondayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater1).OrderBy(s => s.ShowingTime).ToList();
            currentDay = currentDay.AddDays(1);
            List<Showtime> tuesdayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater1).OrderBy(s => s.ShowingTime).ToList();
            currentDay = currentDay.AddDays(1);
            List<Showtime> wednesdayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater1).OrderBy(s => s.ShowingTime).ToList();
            currentDay = currentDay.AddDays(1);
            List<Showtime> thursdayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater1).OrderBy(s => s.ShowingTime).ToList();

            // Get all movies from upcoming schedule for Theater Two
            List<Showtime> upcomingTheaterTwoShowtimes = new List<Showtime>();

            upcomingTheaterTwoShowtimes = _context.Showtimes.Where(s => s.ShowingTime.Day >= nextScheduleStart.Day && s.ShowingTime.Day <= nextScheduleEnd.Day && s.Theater == Theater.Theater2 && s.Approved == true).OrderBy(s => s.ShowingTime).ToList();
            String check = new String("");
            currentDay = nextScheduleStart;

            check = checkScheduleDay(currentDay, fridayShowings, upcomingTheaterTwoShowtimes);
            if (check != "true")
            {
                return View("TheaterOneScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            check = checkScheduleDay(currentDay, saturdayShowings, upcomingTheaterTwoShowtimes);
            if (check != "true")
            {
                return View("TheaterOneScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            check = checkScheduleDay(currentDay, sundayShowings, upcomingTheaterTwoShowtimes);
            if (check != "true")
            {
                return View("TheaterOneScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            check = checkScheduleDay(currentDay, mondayShowings, upcomingTheaterTwoShowtimes);
            if (check != "true")
            {
                return View("TheaterOneScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            check = checkScheduleDay(currentDay, tuesdayShowings, upcomingTheaterTwoShowtimes);
            if (check != "true")
            {
                return View("TheaterOneScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            check = checkScheduleDay(currentDay, wednesdayShowings, upcomingTheaterTwoShowtimes);
            if (check != "true")
            {
                return View("TheaterOneScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            check = checkScheduleDay(currentDay, thursdayShowings, upcomingTheaterTwoShowtimes);
            if (check != "true")
            {
                return View("TheaterOneScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            foreach (Showtime s in fridayShowings)
            {
                s.Approved = true;
            }
            foreach (Showtime s in saturdayShowings)
            {
                s.Approved = true;
            }
            foreach (Showtime s in sundayShowings)
            {
                s.Approved = true;
            }
            foreach (Showtime s in mondayShowings)
            {
                s.Approved = true;
            }
            foreach (Showtime s in tuesdayShowings)
            {
                s.Approved = true;
            }
            foreach (Showtime s in wednesdayShowings)
            {
                s.Approved = true;
            }
            foreach (Showtime s in thursdayShowings)
            {
                s.Approved = true;
            }

            await _context.SaveChangesAsync();


            return View("Index");
        }

        public IActionResult PublishTheaterTwoSchedule()
        {
            // Get all showings from upcoming schedule for Theater Two
            List<Showtime> upcomingTheaterTwoShowtimes = new List<Showtime>();

            DateTime nextScheduleStart = new DateTime(2023, 11, 23, 12, 0, 0);
            DateTime nextScheduleEnd = new DateTime(2023, 11, 23, 12, 0, 0);

            nextScheduleStart = nextScheduleStart.AddDays(1);

            while (nextScheduleStart.DayOfWeek != DayOfWeek.Thursday)
            {
                nextScheduleStart = nextScheduleStart.AddDays(1);
            }

            nextScheduleStart = nextScheduleStart.AddDays(8);
  
            DateTime currentDay = new DateTime();
            currentDay = nextScheduleStart;

            List<Showtime> fridayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater2).OrderBy(s => s.ShowingTime).ToList();
            currentDay = currentDay.AddDays(1);
            List<Showtime> saturdayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater2).OrderBy(s => s.ShowingTime).ToList();
            currentDay = currentDay.AddDays(1);
            List<Showtime> sundayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater2).OrderBy(s => s.ShowingTime).ToList();
            currentDay = currentDay.AddDays(1);
            List<Showtime> mondayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater2).OrderBy(s => s.ShowingTime).ToList();
            currentDay = currentDay.AddDays(1);
            List<Showtime> tuesdayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater2).OrderBy(s => s.ShowingTime).ToList();
            currentDay = currentDay.AddDays(1);
            List<Showtime> wednesdayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater2).OrderBy(s => s.ShowingTime).ToList();
            currentDay = currentDay.AddDays(1);
            List<Showtime> thursdayShowings = _context.Showtimes.Include(s => s.Movie).Where(s => s.ShowingTime.Day == currentDay.Day && s.Theater == Theater.Theater2).OrderBy(s => s.ShowingTime).ToList();

            // Get all movies from upcoming schedule for Theater One
            List<Showtime> upcomingTheaterOneShowtimes = new List<Showtime>();
            upcomingTheaterTwoShowtimes = _context.Showtimes.Where(s => s.ShowingTime.Day >= nextScheduleStart.Day && s.ShowingTime.Day <= nextScheduleEnd.Day && s.Theater == Theater.Theater1 && s.Approved == true).OrderBy(s => s.ShowingTime).ToList();

            String check = new String("");
            currentDay = nextScheduleStart;

            check = checkScheduleDay(currentDay, fridayShowings, upcomingTheaterOneShowtimes);
            if (check != "true")
            {
                return View("TheaterTwoScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            check = checkScheduleDay(currentDay, saturdayShowings, upcomingTheaterOneShowtimes);
            if (check != "true")
            {
                return View("TheaterTwoScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            check = checkScheduleDay(currentDay, sundayShowings, upcomingTheaterOneShowtimes);
            if (check != "true")
            {
                return View("TheaterTwoScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            check = checkScheduleDay(currentDay, mondayShowings, upcomingTheaterOneShowtimes);
            if (check != "true")
            {
                return View("TheaterTwoScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            check = checkScheduleDay(currentDay, tuesdayShowings, upcomingTheaterOneShowtimes);
            if (check != "true")
            {
                return View("TheaterTwoScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            check = checkScheduleDay(currentDay, wednesdayShowings, upcomingTheaterOneShowtimes);
            if (check != "true")
            {
                return View("TheaterTwoScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            check = checkScheduleDay(currentDay, thursdayShowings, upcomingTheaterOneShowtimes);
            if (check != "true")
            {
                return View("TheaterTwoScheduleError", new[] { check });
            }
            currentDay = currentDay.AddDays(1);

            foreach (Showtime s in fridayShowings)
            {
                s.Approved = true;
            }
            foreach (Showtime s in saturdayShowings)
            {
                s.Approved = true;
            }
            foreach (Showtime s in sundayShowings)
            {
                s.Approved = true;
            }
            foreach (Showtime s in mondayShowings)
            {
                s.Approved = true;
            }
            foreach (Showtime s in tuesdayShowings)
            {
                s.Approved = true;
            }
            foreach (Showtime s in wednesdayShowings)
            {
                s.Approved = true;
            }
            foreach (Showtime s in thursdayShowings)
            {
                s.Approved = true;
            }

            return View(Index);
        }

        private String checkScheduleDay(DateTime day, List<Showtime> mainShowtimes, List<Showtime> comparisonShowtimes)
        {
            if (mainShowtimes.Count() == 0)
            {
                return $"{day.Date.ToShortDateString()} cannot be empty";
            }

            Showtime previousShowing = new Showtime();

            foreach (Showtime showtime in mainShowtimes)
            {
                if (comparisonShowtimes.Any(s => s.ShowingTime == showtime.ShowingTime))
                {
                    return $"Schedule cannot be published because the showing of {showtime.Movie.Title} on {showtime.ShowingTime.ToShortDateString()} at {showtime.ShowingTime.ToShortTimeString()} conflicts with a showing of the same movie at the same time in other theater";
                }

                if (previousShowing.ShowingTime.Year == 1)
                {
                    if (showtime.StartTime?.Hour == 9 && showtime.StartTime?.Minute == 0)
                    {
                        previousShowing = showtime;
                        continue;
                    }
                    return $"First movie showing for date {day.Date.ToShortDateString()} must start at 9:00 AM";

                }

                Int32? previousShowingEnd = previousShowing.EndTime?.Hour * 60;
                previousShowingEnd += previousShowing.EndTime?.Minute;

                Int32 currentShowingStart = showtime.ShowingTime.Hour * 60;
                currentShowingStart += showtime.ShowingTime.Minute;

                Int32? showtimeGap = currentShowingStart - previousShowingEnd;

                if (showtimeGap > 45)
                {
                    return $"There exists a gap greater than 45 minutes between the showing of {previousShowing.Movie.Title} on {previousShowing.ShowingTime.ToShortDateString()} at {previousShowing.ShowingTime.ToShortTimeString()} and the showing of {showtime.Movie.Title} on {showtime.ShowingTime.ToShortDateString()} at {showtime.ShowingTime.ToShortTimeString()}";

                }
                else if (showtimeGap < 25)
                {
                    return $"There exists a gap less than 25 minutes between the showing of {previousShowing.Movie.Title} on {previousShowing.ShowingTime.ToShortDateString()} at {previousShowing.ShowingTime.ToShortTimeString()} and the showing of {showtime.Movie.Title} on {showtime.ShowingTime.ToShortDateString()} at {showtime.ShowingTime.ToShortTimeString()}";

                }

                if (previousShowing.EndTime?.Day != showtime.EndTime?.Day)
                {
                    String Test = new string("");
                    return $"Last movie showing for date {previousShowing.ShowingTime.ToShortDateString()} cannot end after 12:00 AM";

                }
                previousShowing = showtime;
            }

            if ((previousShowing.EndTime?.Hour == 21 && previousShowing.EndTime?.Minute < 30) || previousShowing.EndTime?.Hour < 21)
            {
                return $"Add more showings to {previousShowing.ShowingTime.ToShortDateString()}";
            }

            return "true";
        }

        public IActionResult CopyScheduleOne()
        {
            List<DayOfWeek> copyday = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().ToList();

            IEnumerable<SelectListItem> copydaysSelectList = copyday.Select(day => new SelectListItem
            {
                Value = day.ToString(),
                Text = day.ToString()
            });

            List<DayOfWeek> pasteday = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().ToList();

            IEnumerable<SelectListItem> pastedaysSelectList = pasteday.Select(day => new SelectListItem
            {
                Value = day.ToString(),
                Text = day.ToString()
            });

            ViewBag.copyday = new SelectList(copydaysSelectList, "Value", "Text");
            ViewBag.pasteday = new SelectList(pastedaysSelectList, "Value", "Text");


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CopyScheduleOne(Showtime modelShowtime, DayOfWeek copyday, DayOfWeek pasteday)
        {
            DateTime nextScheduleStart = new DateTime(2023, 11, 23, 12, 0, 0);
            DateTime nextScheduleEnd = new DateTime(2023, 11, 23, 12, 0, 0);

            nextScheduleStart = nextScheduleStart.AddDays(1);
            nextScheduleEnd = nextScheduleEnd.AddDays(1);

            while (nextScheduleStart.DayOfWeek != DayOfWeek.Thursday)
            {
                nextScheduleStart = nextScheduleStart.AddDays(1);
                nextScheduleEnd = nextScheduleEnd.AddDays(1);
            }

            nextScheduleStart = nextScheduleStart.AddDays(8);
            nextScheduleEnd = nextScheduleEnd.AddDays(14);

            DateTime copyDate = nextScheduleStart;
            DateTime pasteDate = nextScheduleStart;

            if (copyday == DayOfWeek.Saturday)
            {
                copyDate = copyDate.AddDays(1);
            }
            if (copyday == DayOfWeek.Sunday)
            {
                copyDate = copyDate.AddDays(2);
            }
            if (copyday == DayOfWeek.Monday)
            {
                copyDate = copyDate.AddDays(3);
            }
            if (copyday == DayOfWeek.Tuesday)
            {
                copyDate = copyDate.AddDays(4);
            }
            if (copyday == DayOfWeek.Wednesday)
            {
                copyDate = copyDate.AddDays(5);
            }
            if (copyday == DayOfWeek.Thursday)
            {
                copyDate = copyDate.AddDays(6);
            }

            List<Showtime> upcomingTheaterOneShowtimes = new List<Showtime>();

            upcomingTheaterOneShowtimes = _context.Showtimes.Include(s => s.Movie).Include(s => s.Price).Where(s => s.ShowingTime.Day >= nextScheduleStart.Day && s.ShowingTime.Day <= nextScheduleEnd.Day && s.Theater == Theater.Theater1 && s.ShowingTime.Date == copyDate.Date).OrderBy(s => s.ShowingTime).ToList();


            if (pasteday == DayOfWeek.Saturday)
            {
                pasteDate = pasteDate.AddDays(1);
            }
            if (pasteday == DayOfWeek.Sunday)
            {
                pasteDate = pasteDate.AddDays(2);
            }
            if (pasteday == DayOfWeek.Monday)
            {
                pasteDate = pasteDate.AddDays(3);
            }
            if (pasteday == DayOfWeek.Tuesday)
            {
                pasteDate = pasteDate.AddDays(4);
            }
            if (pasteday == DayOfWeek.Wednesday)
            {
                pasteDate = pasteDate.AddDays(5);
            }
            if (pasteday == DayOfWeek.Thursday)
            {
                pasteDate = pasteDate.AddDays(6);
            }

            // iterate through list, make copy, add to theater 2
            foreach (Showtime showtime in upcomingTheaterOneShowtimes)
            {
                Showtime showtimeCopy = new Showtime();
                showtimeCopy.Theater = modelShowtime.Theater;
                showtimeCopy.SpecialEvent = showtime.SpecialEvent;
                showtimeCopy.StartTime = pasteDate;
                showtimeCopy.EndTime = pasteDate;
                showtimeCopy.ShowingTime = pasteDate;
                showtimeCopy.StartTime = showtimeCopy.StartTime?.AddHours((double)(showtime.StartTime?.Hour)-12);
                showtimeCopy.StartTime = showtimeCopy.StartTime?.AddMinutes((double)(showtime.StartTime?.Minute));
                showtimeCopy.EndTime = showtimeCopy.EndTime?.AddHours((double)(showtime.EndTime?.Hour-12));
                showtimeCopy.EndTime = showtimeCopy.EndTime?.AddMinutes((double)(showtime.EndTime?.Minute));
                showtimeCopy.ShowingTime = showtimeCopy.ShowingTime.AddHours(showtime.ShowingTime.Hour-12);
                showtimeCopy.ShowingTime = showtimeCopy.ShowingTime.AddMinutes(showtime.ShowingTime.Minute);


                Movie dbMovie = _context.Movies.Find(showtime.Movie.MovieID);
                Price dbPrice = _context.Prices.Find(showtime.Price.PriceID);

                showtimeCopy.Movie = dbMovie;
                showtimeCopy.Price = dbPrice;

                _context.Add(showtimeCopy);
            }
            await _context.SaveChangesAsync();

            return View("Index");
        }

        public IActionResult CopyScheduleTwo()
        {
            List<DayOfWeek> copyday = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().ToList();

            IEnumerable<SelectListItem> copydaysSelectList = copyday.Select(day => new SelectListItem
            {
                Value = day.ToString(),
                Text = day.ToString()
            });

            List<DayOfWeek> pasteday = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().ToList();

            IEnumerable<SelectListItem> pastedaysSelectList = pasteday.Select(day => new SelectListItem
            {
                Value = day.ToString(),
                Text = day.ToString()
            });

            ViewBag.copyday = new SelectList(copydaysSelectList, "Value", "Text");
            ViewBag.pasteday = new SelectList(pastedaysSelectList, "Value", "Text");


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CopyScheduleTwo(Showtime modelShowtime, DayOfWeek copyday, DayOfWeek pasteday)
        {
            DateTime nextScheduleStart = new DateTime(2023, 11, 23, 12, 0, 0);
            DateTime nextScheduleEnd = new DateTime(2023, 11, 23, 12, 0, 0);

            nextScheduleStart = nextScheduleStart.AddDays(1);
            nextScheduleEnd = nextScheduleEnd.AddDays(1);

            while (nextScheduleStart.DayOfWeek != DayOfWeek.Thursday)
            {
                nextScheduleStart = nextScheduleStart.AddDays(1);
                nextScheduleEnd = nextScheduleEnd.AddDays(1);
            }

            nextScheduleStart = nextScheduleStart.AddDays(8);
            nextScheduleEnd = nextScheduleEnd.AddDays(14);

            DateTime copyDate = nextScheduleStart;
            DateTime pasteDate = nextScheduleStart;

            if (copyday == DayOfWeek.Saturday)
            {
                copyDate = copyDate.AddDays(1);
            }
            if (copyday == DayOfWeek.Sunday)
            {
                copyDate = copyDate.AddDays(2);
            }
            if (copyday == DayOfWeek.Monday)
            {
                copyDate = copyDate.AddDays(3);
            }
            if (copyday == DayOfWeek.Tuesday)
            {
                copyDate = copyDate.AddDays(4);
            }
            if (copyday == DayOfWeek.Wednesday)
            {
                copyDate = copyDate.AddDays(5);
            }
            if (copyday == DayOfWeek.Thursday)
            {
                copyDate = copyDate.AddDays(6);
            }

            List<Showtime> upcomingTheaterTwoShowtimes = new List<Showtime>();

            upcomingTheaterTwoShowtimes = _context.Showtimes.Include(s => s.Movie).Include(s => s.Price).Where(s => s.ShowingTime.Day >= nextScheduleStart.Day && s.ShowingTime.Day <= nextScheduleEnd.Day && s.Theater == Theater.Theater2 && s.ShowingTime.Date == copyDate.Date).OrderBy(s => s.ShowingTime).ToList();

            if (pasteday == DayOfWeek.Saturday)
            {
                pasteDate = pasteDate.AddDays(1);
            }
            if (pasteday == DayOfWeek.Sunday)
            {
                pasteDate = pasteDate.AddDays(2);
            }
            if (pasteday == DayOfWeek.Monday)
            {
                pasteDate = pasteDate.AddDays(3);
            }
            if (pasteday == DayOfWeek.Tuesday)
            {
                pasteDate = pasteDate.AddDays(4);
            }
            if (pasteday == DayOfWeek.Wednesday)
            {
                pasteDate = pasteDate.AddDays(5);
            }
            if (pasteday == DayOfWeek.Thursday)
            {
                pasteDate = pasteDate.AddDays(6);
            }

            // iterate through list, make copy, add to theater 2
            foreach (Showtime showtime in upcomingTheaterTwoShowtimes)
            {
                Showtime showtimeCopy = new Showtime();
                showtimeCopy.Theater = modelShowtime.Theater;
                showtimeCopy.ShowingTime = pasteDate.Date;
                showtimeCopy.SpecialEvent = showtime.SpecialEvent;
                showtimeCopy.StartTime = pasteDate.Date;
                showtimeCopy.EndTime = pasteDate.Date;

                Movie dbMovie = _context.Movies.Find(showtime.Movie.MovieID);
                Price dbPrice = _context.Prices.Find(showtime.Price.PriceID);

                showtimeCopy.Movie = dbMovie;
                showtimeCopy.Price = dbPrice;

                _context.Add(showtimeCopy);
            }
            await _context.SaveChangesAsync();

            return View("Index");
        }
    }
}

