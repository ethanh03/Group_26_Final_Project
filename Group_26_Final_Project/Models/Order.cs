using System;
using System.ComponentModel.DataAnnotations;

namespace Group_26_Final_Project.Models
{

    public enum OrderStatus
    {
        [Display(Name = "Purchased")] Purchased,
        [Display(Name = "Cancelled")] Cancelled,

    }

    public class Order
	{
        private const Decimal TAX_RATE = 0.0825m;

        public Int32 OrderID { get; set; }

        [Display(Name = "Order Number: ")]
        public Int32 OrderNumber { get; set; }

        [Display(Name = "Gift: ")]
        public Boolean Gift { get; set; }

        [Display(Name = "Order Date: ")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Order Subtotal: ")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal
        {
            get { return OrderDetails.Sum(od => od.ExtendedPrice); }
        }

        [Display(Name = "Order Tax: ")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTax
        {
            get { return OrderSubtotal * TAX_RATE; }
        }

        [Display(Name = "Order Total: ")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + OrderTax; }
        }

        [Display(Name = "Ticket Quantity: ")]
        public Int32 TicketQuantity { get; set; }

        [Display(Name = "Popcorn Points: ")]
        public Int32 PopcornPoints { get; set; }

        public OrderStatus OrderStatus { get; set; }

        //Navigational properties
        public List<OrderDetail> OrderDetails { get; set; }

        public AppUser Customer { get; set; }

        public Order()
        {
            if (OrderDetails == null)
            {
                OrderDetails = new List<OrderDetail>();
            }
        }
    }
}

