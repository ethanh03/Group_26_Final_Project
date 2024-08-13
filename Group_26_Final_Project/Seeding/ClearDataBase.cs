using System;
using Group_26_Final_Project.DAL;

namespace Group_26_Final_Project.Seeding
{
	public class ClearDataBase
	{
        public static void ClearDatabase(AppDbContext db)
        {
            var genres = db.Genres;
            db.Genres.RemoveRange(genres);

            var movies = db.Movies;
            db.Movies.RemoveRange(movies);

            var orderdetails = db.OrderDetails;
            db.OrderDetails.RemoveRange(orderdetails);

            var orders = db.Orders;
            db.Orders.RemoveRange(orders);

            var prices = db.Prices;
            db.Prices.RemoveRange(prices);

            var reviews = db.Reviews;
            db.Reviews.RemoveRange(reviews);

            var roles = db.Roles;
            db.Roles.RemoveRange(roles);

            var showtimes = db.Showtimes;
            db.Showtimes.RemoveRange(showtimes);

            var users = db.Users;
            db.Users.RemoveRange(users);

            var roleclaims = db.RoleClaims;
            db.RoleClaims.RemoveRange(roleclaims);

            var userclaims = db.UserClaims;
            db.UserClaims.RemoveRange(userclaims);

            var userlogins = db.UserLogins;
            db.UserLogins.RemoveRange(userlogins);

            var userroles = db.UserRoles;
            db.UserRoles.RemoveRange(userroles);

            var usertokens = db.UserTokens;
            db.UserTokens.RemoveRange(usertokens);

            db.SaveChanges();
        
        }
    }
}


