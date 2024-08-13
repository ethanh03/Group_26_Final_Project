using System;
using System.ComponentModel.DataAnnotations;

namespace Group_26_Final_Project.Models
{

    public class Genre
    {
        public Int32 GenreID { get; set; }

        [Display(Name = "Genre: ")]
        [Required(ErrorMessage = "Genre name is required.")]
        public String GenreName { get; set; }

        //Navigational properties
        public List<Movie> Movies { get; set; }

        public Genre()
        {
            if (Movies == null)
            {
                Movies = new List<Movie>();
            }
        }
    }

}


