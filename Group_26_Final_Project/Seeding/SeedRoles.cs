using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Group_26_Final_Project.Seeding
{
    public class SeedRoles
    {
        public static async Task AddAllRoles(RoleManager<IdentityRole> roleManager)
        { 
            if (await roleManager.RoleExistsAsync("Manager") == false)
            {
                //this code uses the role manager object to create the admin role
                await roleManager.CreateAsync(new IdentityRole("Manager"));
            }

            if (await roleManager.RoleExistsAsync("Employee") == false)
            {
                //this code uses the role manager object to create the customer role
                await roleManager.CreateAsync(new IdentityRole("Employee"));
            }

            //if the customer role doesn't exist, add it
            if (await roleManager.RoleExistsAsync("Customer") == false)
            {
                //this code uses the role manager object to create the customer role
                await roleManager.CreateAsync(new IdentityRole("Customer"));
            }

        }
    }
}
