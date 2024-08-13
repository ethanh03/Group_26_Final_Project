using System;
using System.ComponentModel.DataAnnotations;

namespace Group_26_Final_Project.Models
{

    public enum ReviewStatus
    {
        [Display(Name = "NeedsReview")] NeedsReview,
        [Display(Name = "Approved")] Approved,
    }

    public class Review
    {
        public Int32 ReviewID { get; set; }

        [Display(Name = "Rating (1-5): ")]
        [Required(ErrorMessage = "Numerical rating is required.")]
        [Range(1, 5, ErrorMessage = "The rating field must be between 1 and 5.")]
        public Int32 Rating { get; set; }

        [Display(Name = "Review: ")]
        [StringLength(280, ErrorMessage = "The review field must be 280 characters or shorter.")]
        public String? ReviewText { get; set; }

        [Display(Name = "Employee Approval: ")]
        public ReviewStatus ReviewStatus { get; set; }

        //Navigational properties

        public Movie Movie { get; set; }
        public AppUser Customer { get; set; }


    }

}
