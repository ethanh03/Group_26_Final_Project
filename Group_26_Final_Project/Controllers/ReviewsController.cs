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
using Microsoft.AspNetCore.Identity;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace Group_26_Final_Project.Controllers
{
    [Authorize]
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _context;
        private UserManager<AppUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public ReviewsController(AppDbContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET Reviews/Index
        public async Task<IActionResult> Index()
        {
            var reviews = _context.Reviews.Include(r => r.Movie).Include(r => r.Customer).ToList();

            return View(reviews);
           
        }
    

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {



            if (id == null)
            {
                return View("Error", new String[] { "You must specify what movie review to view!" });
            }

            Review movieReview = await _context.Reviews.Include(mr => mr.Movie)
                                            .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (movieReview == null)
            {
                return View("Error", new String[] { "No movie review exists for this ID yet!" });
            }


            return View(movieReview);
        }

      
        // GET: Reviews/Create
        public IActionResult Create()
        {
            ViewBag.AllMovies = GetWatchedMovies();
            return View();
        }




        public SelectList GetWatchedMovies()
        {
            List<Movie> allMovies = _context.Movies.ToList();
            

            SelectList movieSelectList = new SelectList(allMovies.OrderBy(m => m.MovieID), "MovieID", "Title");

            return movieSelectList;
        }



        // POST: Reviews/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Review review, int SelectMovieID)
        {
            Movie dbMovie = _context.Movies.Find(SelectMovieID);

            review.Movie = dbMovie;
            review.ReviewStatus = ReviewStatus.NeedsReview;
            review.Customer = _userManager.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            _context.Add(review);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }















        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a movie review to edit!" });
            }

            //find the order detail
            Review movieReview = await _context.Reviews
                                                   .Include(r => r.Movie)
                                                   .FirstOrDefaultAsync(r => r.ReviewID == id);
            if (movieReview == null)
            {
                return View("Error", new String[] { "This movie review was not found. Try creating a review instead!" });
            }

            return View(movieReview);
        }





        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewID,Rating,ReviewText,ReviewStatus")] Review review)
        {
            if (id != review.ReviewID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            //information is not valid, try again
            if (ModelState.IsValid == false)
            {
                return View(review);
            }

            //create a new order detail
           Review dbMR;
            //if code gets this far, update the record
            try
            {
                //find the existing movie review in the database
                //include movie
                dbMR = _context.Reviews
                      .Include(rd => rd.Movie)
                      .FirstOrDefault(rd => rd.ReviewID == review.ReviewID);

                //update the scalar properties

                dbMR.Rating = review.Rating;
                dbMR.ReviewText = review.ReviewText;
                dbMR.ReviewStatus = review.ReviewStatus;

                //save changes
                _context.Update(dbMR);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            //if code gets this far, go back to the order details index page
            return RedirectToAction("Index");
        }

       

        // GET: Reviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (review == null)
            {
                return View("Error", new String[] { "This movie review was not found. Try creating a review instead!" });
            }


            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieReview = await _context.Reviews.FindAsync(id);
            _context.Reviews.Remove(movieReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
            return _context.Reviews.Any(e => e.ReviewID == id);
        }
    }
}