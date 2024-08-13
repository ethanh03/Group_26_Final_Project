using System;
using System.ComponentModel.DataAnnotations;

namespace Group_26_Final_Project.Models
{
    public enum Theater
    {
    [Display(Name = "Theater 1")] Theater1,
    [Display(Name = "Theater 2")] Theater2,
    }

    public class Showtime
    {
        public Int32 ShowtimeID { get; set; }

        [Required(ErrorMessage = "Showing Time is required.")]
        [DisplayFormat(DataFormatString = "{0:dddd, d MMMM yyyy hh:mm tt}")]
        [Display(Name = "Showing Time: ")]
        public DateTime ShowingTime { get; set; }

        [Required(ErrorMessage = "Theater is required.")]
        [Display(Name = "Theater: ")]
        public Theater Theater { get; set; }

        [Display(Name = "Special Event? ")]
        public Boolean SpecialEvent { get; set; }

        [Display(Name = "Start Time: ")]
        public DateTime? StartTime { get; set; }

        [Display(Name = "End Time: ")]
        public DateTime? EndTime { get; set; }

        public Boolean Approved { get; set; }

        //navigational properties
        public Price Price { get; set; }
        public Movie Movie { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        public Showtime()
        {
            if (OrderDetails == null)
            {
                OrderDetails = new List<OrderDetail>();
            }
        }
    }
}