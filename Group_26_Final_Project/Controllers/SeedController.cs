using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Group_26_Final_Project.Models;
using Group_26_Final_Project.DAL;
using Group_26_Final_Project.Seeding;
using System;

namespace Group_26_Final_Project.Controllers
{
    public class SeedController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedController(AppDbContext db, UserManager<AppUser> um, RoleManager<IdentityRole> rm)
        {
            _context = db;
            _userManager = um;
            _roleManager = rm;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SeedRoles()
        {
            try
            {
                //call the method to seed the roles
                await Seeding.SeedRoles.AddAllRoles(_roleManager);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }


        public async Task<IActionResult> SeedMovies()
        {
            try
            {
                //call the method to seed the roles
                Seeding.SeedMovies.SeedOneMovie(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }
        
        public async Task<IActionResult> SeedGenres()
        {
            try
            {
                //call the method to seed the roles
                Seeding.SeedGenres.SeedAllGenres(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }

        public async Task<IActionResult> SeedPrices()
        {
            try
            {
                //call the method to seed the roles
                Seeding.SeedPrices.SeedAllPrices(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }

        public async Task<IActionResult> SeedShowtimes()
        {
            try
            {
                //call the method to seed the roles
                Seeding.SeedShowtimes.SeedOneShowtime(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }

        public async Task<IActionResult> SeedReviews()
        {
            try
            {
                //call the method to seed the roles
                Seeding.SeedReviews.SeedOneReview(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }

        public async Task<IActionResult> SeedOrders()
        {
            try
            {
                //call the method to seed the roles
                Seeding.SeedOrders.SeedOneOrder(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }

        public async Task<IActionResult> SeedOrderDetails()
        {
            try
            {
                //call the method to seed the roles
                Seeding.SeedOrderDetails.SeedOneOrderDetail(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }
        public async Task<IActionResult> SeedPeople()
            {
                try
                {
                    //call the method to seed the users
                    await Seeding.SeedUsers.SeedAllUsers(_userManager, _context);
                }
                catch (Exception ex)
                {
                    //add the error messages to a list of strings
                    List<String> errorList = new List<String>();

                    //Add the outer message
                    errorList.Add(ex.Message);

                    if (ex.InnerException != null)
                    {
                        //Add the message from the inner exception
                        errorList.Add(ex.InnerException.Message);

                        //Add additional inner exception messages, if there are any
                        if (ex.InnerException.InnerException != null)
                        {
                            errorList.Add(ex.InnerException.InnerException.Message);
                        }

                    }


                    return View("Error", errorList);
                }

                //this is the happy path - seeding worked!
                return View("Confirm");
            }

        public async Task<IActionResult> ClearDatabase()
        {
            Seeding.ClearDataBase.ClearDatabase(_context);

            return View();
        }
        }
    }
