using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Group_26_Final_Project.Models
{
    public enum EmployeeStatus
    {
        [Display(Name = "Fired")] Fired,
        [Display(Name = "Active")] Active,
        [Display(Name = "Rehired")] Rehired,
        [Display(Name = "Manager")] Manager,
        [Display(Name = "Manager")] Customer,

    }

    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name: ")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name: ")]
        public String LastName { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? Birthday { get; set; }

        [Display(Name = "Street Address: ")]
        public string? StreetAddress { get; set; }

        [Display(Name = "City: ")]
        public string? City { get; set; }

        [Display(Name = "State: ")]
        public string? State { get; set; }

        [Display(Name = "Zip Code: ")]
        public string? ZipCode { get; set; }

        [Display(Name = "Employee Status: ")]
        public EmployeeStatus EmployeeStatus { get; set; }

        [Display(Name = "Full Name: ")]
        public String? FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public Int32 PopcornPoints { get; set; }

        // Navigational properties

        public List<Review> Reviews { get; set; }
        public List<Order> Orders { get; set; }

        public AppUser()
        {
            if (Orders == null)
            {
                Orders = new List<Order>();
            }
        }


    }
}
