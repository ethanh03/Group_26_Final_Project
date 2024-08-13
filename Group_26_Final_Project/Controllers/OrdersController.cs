using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Group_26_Final_Project.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group_26_Final_Project.DAL;
using Group_26_Final_Project.Models;

namespace Group_26_Final_Project.Controllers

{
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public OrdersController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
              return _context.Orders != null ? 
                          View(await _context.Orders.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Orders'  is null.");
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        [HttpGet]
        // GET: Orders/Create
        public async Task<IActionResult> Create()
        {
            Order order = new Order();
            return View(order);
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Order order)
        {
            //creates a new order number, sets time and connects to customer then takes
            //user to 
            order.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);
            order.OrderDate = DateTime.Now;

            _context.Add(order);
            await _context.SaveChangesAsync();

            return RedirectToAction("ChooseMovie", new { id = order.OrderID });
        }

        public ActionResult ChooseMovie(int id)
        {
            Order dbOrder = _context.Orders.Find(id);
            ViewBag.AllMovies = GetAllMovies();
            return View(dbOrder);
        }

        [HttpPost]
        public ActionResult ChooseMovie(Order order, int SelectedMovie)
        {

            
            Movie movie = _context.Movies.Find(SelectedMovie);
            ViewBag.MovieName = movie.Title;
            //this gets all of the showtimes associated with the movie
            //it puts in the movie ID associated with the movie
            ViewBag.AllShowtimes = GetAllShowtimes(SelectedMovie);

            return View("ChooseShowtime", order);
        }


        [HttpPost]
        public IActionResult ChooseShowtime(Order order, int SelectedShowtime)
        {

            //this gets all of the showtimes associated with the movie
            //it puts in the movie ID associated with the movie

            //this below code gets all the order details associated with a showtime
            var showtime = _context.Showtimes
            .Include(s => s.OrderDetails) // Include OrderDetails to avoid lazy loading
            .FirstOrDefault(s => s.ShowtimeID == SelectedShowtime);

            ViewBag.ShowtimeStart = showtime.StartTime;

            List<OrderDetail> orderdetails;

            orderdetails = _context.OrderDetails
                                .Where(r => r.Showtime.ShowtimeID == SelectedShowtime)
                                .ToList();

            //this finds taken seats from order details associated with the showtime
            var takenSeats = GetTakenSeats(orderdetails);
            //this subtracts those taken seats from total seats and returns available seats
            var availableSeats = GetAvailableSeats(takenSeats, GenerateAllSeats());

            ViewBag.list = new SelectList(availableSeats);

            ViewBag.AllShowtimes = GetAllShowtimesSelectList(showtime);

            return View("ChooseSeats", order);

        }

        private SelectList GetAllShowtimesSelectList(Showtime showtime)
        {
            List<Showtime> showtimeList = new List<Showtime>();
            showtimeList.Add(showtime);
            SelectList showtimeSelectList = new SelectList(showtimeList.OrderBy(s => s.ShowtimeID), "ShowtimeID", "ShowingTime");
            return showtimeSelectList;
        }


        //this method takes us to order details for what we have so far
        //it loops through selected seats and creates a new orderdetail for each
        //adding each order detail to the original order 
        [HttpPost]
        public async Task<ActionResult> ChooseSeats(Order order, String[] seats, int SelectedShowtime)
        {
            foreach (var seat in seats)
            {
                Showtime dbshowtime = _context.Showtimes.Find(SelectedShowtime);
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.SeatNumber = seat;
                orderDetail.Order = order;
                orderDetail.Showtime = dbshowtime;
                //orderDetail.ShowtimePrice = showtimeId.Price.TicketPrice;
                //orderDetail.Theater = showtimeId.Theater;
                //orderDetail.PaymentMethod = PaymentMethod.CardCash;
                //orderDetail.PopcornPoint = Convert.ToInt32(showtime.Price.TicketPrice);

                _context.Add(orderDetail);
                await _context.SaveChangesAsync();

            }

            return View("ChooseSeats", order);

        }

        private const int Rows = 5;
        private const int SeatsPerRow = 5;


        public List<string> GenerateAllSeats()
        {
            var allSeats = new List<string>();

            for (int seatNumber = 1; seatNumber <= 25; seatNumber++)
            {
                allSeats.Add(seatNumber.ToString());
            }

            return allSeats;
        }


        //this method takes in taken seats, then subtracts them from all possible seats
        //therefore returning all the available seats for a showtime
        public List<string> GetAvailableSeats(List<string> takenSeats, List<string> allSeats)
        {
            // Filter out the taken seats
            var availableSeats = allSeats.Except(takenSeats).ToList();

            return availableSeats;
        }

        //this method puts in a list of order details and extracts the taken seats
        public List<string> GetTakenSeats(List<OrderDetail> orderDetails)
        {
            // Extract the seat numbers from the order details
            var takenSeats = orderDetails.Select(detail => detail.SeatNumber).ToList();

            return takenSeats;
        }



        private SelectList GetAllMovies()
        {
            List<Movie> allMovies = _context.Movies.ToList();

            SelectList slAllMovies = new SelectList(allMovies, nameof(Movie.MovieID), nameof(Movie.Title));

            return slAllMovies;
        }

        private SelectList GetAllShowtimes(int movieID)
        {
            List<Showtime> showtimes;

            showtimes = _context.Showtimes
                                .Where(r => r.Movie.MovieID == movieID)
                                .ToList();

            SelectList slShowtimes = new SelectList(showtimes, nameof(Showtime.ShowtimeID), nameof(Showtime.ShowingTime), nameof(Showtime.Theater));

            return slShowtimes;
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,OrderNumber,Gift,OrderDate,TicketQuantity,PopcornPoints,OrderStatus")] Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderID))
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
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Orders == null)
            {
                return Problem("Entity set 'AppDbContext.Orders'  is null.");
            }
            var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
          return (_context.Orders?.Any(e => e.OrderID == id)).GetValueOrDefault();
        }



        public async Task<SelectList> GetAllCustomerUserNamesSelectList()
        {
            //create a list to hold the customers
            List<AppUser> allCustomers = new List<AppUser>();

            //See if the user is a customer
            foreach (AppUser dbUser in _context.Users)
            {
                //if the user is a customer, add them to the list of customers
                if (await _userManager.IsInRoleAsync(dbUser, "Customer") == true)//user is a customer
                {
                    allCustomers.Add(dbUser);
                }
            }

            //create a new select list with the customer emails
            SelectList sl = new SelectList(allCustomers.OrderBy(c => c.Email), nameof(AppUser.UserName), nameof(AppUser.Email));

            //return the select list
            return sl;

        }


        [HttpPost]
        public async Task<IActionResult> SelectCustomerForOrder(String SelectedCustomer)
        {
            if (String.IsNullOrEmpty(SelectedCustomer))
            {
                ViewBag.UserNames = await GetAllCustomerUserNamesSelectList();
                return View("SelectCustomerForOrder");
            }

            Order order = new Order();
            order.Customer = await _userManager.FindByNameAsync(SelectedCustomer);
            return View("Create", order);
        }
    }
}
