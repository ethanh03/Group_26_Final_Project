using System.ComponentModel.DataAnnotations;
using Group_26_Final_Project.Models;

namespace Group_26_Final_Project.Models
{
    public enum PaymentMethod
    {
        [Display(Name = "Card/Cash")] CardCash,
        [Display(Name = "Popcorn Points")] PopcornPoint,
    }
    public class OrderDetail
    { 
        public Int32 OrderDetailID { get; set; }

        public Int32 TransactionID { get; set; }

        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "You must specify a seat number.")]
        [Display(Name = "Seat Number: ")]
        public String SeatNumber { get; set; }

        [Display(Name = "Price: ")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Int32 PriceID { get; set; }

        [Display(Name = "Extended Price: ")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ExtendedPrice { get; set; }

        [Display(Name = "Theater: ")]
        public Theater Theater { get; set; }

        [Display(Name = "Popcorn Points: ")]
        public Int32 PopcornPoint { get; set; }

        [Display(Name = "Senior Discount: ")]
        public Boolean SeniorDiscount { get; set; }

        [Display(Name = "Payment Method: ")]
        public PaymentMethod PaymentMethod { get; set; }

        [Display(Name ="Showtime Price")]
        public Decimal ShowtimePrice { get; set; }

        // Navigational Properties
        //ADD NAVIGATIONAL PROPERTIES
        public Order Order { get; set; }

        public Showtime Showtime { get; set; }

    }

    
}
