using System;
using System.ComponentModel.DataAnnotations;

namespace Group_26_Final_Project.Models
{
    public enum AvgRatingSearch { [Display(Name = "Greater Than")] GreaterThan, [Display(Name = "Less Than")] LessThan }

    public class SearchViewModel
    {
        // title = textbox
        [Display(Name = "Search by Title")]
        public String? Title { get; set; }

        // description search = textbox
        [Display(Name = "Search by Tagline")]
        public String? Tagline { get; set; }

        // category = drop down menu
        [Display(Name = "Search by Genre (Select from Dropdown)")]
        public Int32? SelectedGenre { get; set; }

        //CategoryID
        public Int32 GenreID { get; set; }

        // category = drop down menu
        [Display(Name = "Search by MPAA Rating (Select from Dropdown)")]
        public MPAARating? SelectedMPAARating { get; set; }

        // salary = decimal number textbox
        [Display(Name = "Search by Release Year")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Release year must be in the format 'XXXX'.")]
        public Int32? ReleaseYear { get; set; }

        //published date = date time
        [Display(Name = "Search by Actors")]
        public String? Actors { get; set; }

        // greater than or less than salary
        [Display(Name = "Search by Customer Rating")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1-5!")]
        public Decimal? RatingSearch { get; set; }

        [Display(Name = "")]
        public AvgRatingSearch? AvgRatingSearch { get; set; }

        [Display(Name = "Customer Rating")]
        public Double? AvgRating { get; set; }

        //published date = date time
        [Display(Name = "Search by Movie Showtime")]
        [DataType(DataType.Date)]
        public DateTime? ShowtimeDate { get; set; }

        public List<Movie> Movies { get; set; }

    }
       
}

