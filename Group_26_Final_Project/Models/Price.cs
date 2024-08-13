using System;
using System.ComponentModel.DataAnnotations;

namespace Group_26_Final_Project.Models
{
    public enum TicketType
    {
        [Display(Name = "Special Event")] SpecialEvent,
        [Display(Name = "Matinee")] Matinee,
        [Display(Name = "Discount Tuesday")] DiscountTuesday,
        [Display(Name = "Weekday")] Weekday,
        [Display(Name = "Weekend")] Weekend,
    }

    public class Price
	{
        public Int32 PriceID { get; set; }

        [Display(Name = "Ticket Type: ")]
        public TicketType TicketType { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Display(Name = "Ticket Price: ")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Int32 TicketPrice { get; set; }

        //navigational properties

        public List<Showtime> Showtimes { get; set; }

        public Price()
        {
            if (Showtimes == null)
            {
                Showtimes = new List<Showtime>();
            }
        }
    }
}

