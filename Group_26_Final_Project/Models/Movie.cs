using System;
using System.ComponentModel.DataAnnotations;

namespace Group_26_Final_Project.Models

{

    public enum MPAARating
    {
        [Display(Name = "G")] G,
        [Display(Name = "PG")] PG,
        [Display(Name = "PG-13")] PG13,
        [Display(Name = "R")] R,
        [Display(Name = "NC-17")] NC17,

    }

    public class Movie
    {
        public Int32 MovieID { get; set; }

        [Display(Name = "Movie Number:")]
        public Int32 MovieNumber { get; set; }

        [Display(Name = "Movie Title: ")]
        [Required(ErrorMessage = "Movie title is required.")]
        public String Title { get; set; }

        [Display(Name = "Description: ")]
        [Required(ErrorMessage = "Movie description is required.")]
        public String Description { get; set; }

        [Display(Name = "Tagline: ")]
        public String? Tagline { get; set; }

        [Display(Name = "Runtime: ")]
        [Required(ErrorMessage = "Movie runtime is required.")]
        public Int32 Runtime { get; set; }

        [Display(Name = "Actors: ")]
        [Required(ErrorMessage = "At least one actor is required.")]
        public String Actors { get; set; }

        [Display(Name = "Release Year: ")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Release year must be in the format 'XXXX'.")]
        [Required(ErrorMessage = "Release Year is required.")]
        public Int32 ReleaseYear { get; set; }

        [Display(Name = "MPAA Rating: ")]
        [Required(ErrorMessage = "MPAA Rating is required.")]
        public MPAARating MPAARating { get; set; }

        [Display(Name = "Customer Rating ")]
        public Decimal? AverageRating { get; set; }

        //Navigational properties
        public Genre Genre { get; set; }

        public List<Review> Reviews { get; set; }

        public List<Showtime> Showtimes { get; set; }

        public Movie()
        {
            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }

            if (Showtimes == null)
            {
                Showtimes = new List<Showtime>();
            }
        }


    }
}

