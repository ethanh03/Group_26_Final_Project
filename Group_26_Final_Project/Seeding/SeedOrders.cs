using System;
using Group_26_Final_Project.DAL;
using Group_26_Final_Project.Models;
using Microsoft.SqlServer.Server;
using static System.Reflection.Metadata.BlobBuilder;

namespace Group_26_Final_Project.Seeding
{
    public static class SeedOrders
    {

        public async static void SeedOneOrder(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intOrderNumber = 10001;
            Int32 intOrdersAdded = 0;
            // create movie list and instance of movie
            List<Order> Orders = new List<Order>();


            Order o0 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 1),
                TicketQuantity = 10,
                PopcornPoints = 50,
                OrderStatus = OrderStatus.Purchased,


            };
            o0.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Michelle" && u.LastName == "Banks");
            Orders.Add(o0);
            intOrderNumber += 1;


            Order o1 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 5),
                TicketQuantity = 10,
                PopcornPoints = 116,
                OrderStatus = OrderStatus.Purchased,


            };
            o1.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Christopher" && u.LastName == "Baker");
            Orders.Add(o1);
            intOrderNumber += 1;


            Order o2 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 20),
                TicketQuantity = 2,
                PopcornPoints = 10,
                OrderStatus = OrderStatus.Purchased,


            };
            o2.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");
            Orders.Add(o2);
            intOrderNumber += 1;


            Order o3 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 14),
                TicketQuantity = 2,
                PopcornPoints = 10,
                OrderStatus = OrderStatus.Purchased,


            };
            o3.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Michelle" && u.LastName == "Banks");
            Orders.Add(o3);
            intOrderNumber += 1;


            Order o4 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 5),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o4.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Franco" && u.LastName == "Broccolo");
            Orders.Add(o4);
            intOrderNumber += 1;


            Order o5 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 20),
                TicketQuantity = 1,
                PopcornPoints = 10,
                OrderStatus = OrderStatus.Purchased,


            };
            o5.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Wendy" && u.LastName == "Chang");
            Orders.Add(o5);
            intOrderNumber += 1;


            Order o6 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 14),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o6.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Lim" && u.LastName == "Chou");
            Orders.Add(o6);
            intOrderNumber += 1;


            Order o7 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 20),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o7.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");
            Orders.Add(o7);
            intOrderNumber += 1;


            Order o8 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 5),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o8.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Shan" && u.LastName == "Dixon");
            Orders.Add(o8);
            intOrderNumber += 1;


            Order o9 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 20),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o9.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Jim" && u.LastName == "Bob");
            Orders.Add(o9);
            intOrderNumber += 1;


            Order o10 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 14),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o10.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Lou" && u.LastName == "Ann");
            Orders.Add(o10);
            intOrderNumber += 1;


            Order o11 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 20),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o11.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");
            Orders.Add(o11);
            intOrderNumber += 1;


            Order o12 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 5),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o12.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Victoria" && u.LastName == "Lawrence");
            Orders.Add(o12);
            intOrderNumber += 1;


            Order o13 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 20),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Cancelled,


            };
            o13.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Erik" && u.LastName == "Lineback");
            Orders.Add(o13);
            intOrderNumber += 1;


            Order o14 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 14),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o14.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Ernest" && u.LastName == "Lowe");
            Orders.Add(o14);
            intOrderNumber += 1;


            Order o15 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 20),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o15.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");
            Orders.Add(o15);
            intOrderNumber += 1;


            Order o16 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 20),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o16.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");
            Orders.Add(o16);
            intOrderNumber += 1;


            Order o17 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 20),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o17.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");
            Orders.Add(o17);
            intOrderNumber += 1;


            Order o18 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 20),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o18.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");
            Orders.Add(o18);
            intOrderNumber += 1;


            Order o19 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 20),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o19.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");
            Orders.Add(o19);
            intOrderNumber += 1;


            Order o20 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 20),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o20.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");
            Orders.Add(o20);
            intOrderNumber += 1;


            Order o21 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o21.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Michelle" && u.LastName == "Banks");
            Orders.Add(o21);
            intOrderNumber += 1;


            Order o22 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o22.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Christopher" && u.LastName == "Baker");
            Orders.Add(o22);
            intOrderNumber += 1;


            Order o23 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o23.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");
            Orders.Add(o23);
            intOrderNumber += 1;


            Order o24 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o24.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Michelle" && u.LastName == "Banks");
            Orders.Add(o24);
            intOrderNumber += 1;


            Order o25 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o25.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Franco" && u.LastName == "Broccolo");
            Orders.Add(o25);
            intOrderNumber += 1;


            Order o26 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o26.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Wendy" && u.LastName == "Chang");
            Orders.Add(o26);
            intOrderNumber += 1;


            Order o27 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o27.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Lim" && u.LastName == "Chou");
            Orders.Add(o27);
            intOrderNumber += 1;


            Order o28 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Cancelled,


            };
            o28.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Shan" && u.LastName == "Dixon");
            Orders.Add(o28);
            intOrderNumber += 1;


            Order o29 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o29.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Jim" && u.LastName == "Bob");
            Orders.Add(o29);
            intOrderNumber += 1;


            Order o30 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o30.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Lou" && u.LastName == "Ann");
            Orders.Add(o30);
            intOrderNumber += 1;


            Order o31 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o31.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Victoria" && u.LastName == "Lawrence");
            Orders.Add(o31);
            intOrderNumber += 1;


            Order o32 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Cancelled,


            };
            o32.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Erik" && u.LastName == "Lineback");
            Orders.Add(o32);
            intOrderNumber += 1;


            Order o33 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o33.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Ernest" && u.LastName == "Lowe");
            Orders.Add(o33);
            intOrderNumber += 1;


            Order o34 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o34.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Christopher" && u.LastName == "Baker");
            Orders.Add(o34);
            intOrderNumber += 1;


            Order o35 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o35.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Christopher" && u.LastName == "Baker");
            Orders.Add(o35);
            intOrderNumber += 1;


            Order o36 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o36.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Christopher" && u.LastName == "Baker");
            Orders.Add(o36);
            intOrderNumber += 1;


            Order o37 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 1,
                PopcornPoints = 15,
                OrderStatus = OrderStatus.Purchased,


            };
            o37.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Christopher" && u.LastName == "Baker");
            Orders.Add(o37);
            intOrderNumber += 1;


            Order o38 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 3,
                PopcornPoints = 45,
                OrderStatus = OrderStatus.Purchased,


            };
            o38.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Christopher" && u.LastName == "Baker");
            Orders.Add(o38);
            intOrderNumber += 1;


            Order o39 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 1),
                TicketQuantity = 6,
                PopcornPoints = 90,
                OrderStatus = OrderStatus.Purchased,


            };
            o39.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");
            Orders.Add(o39);
            intOrderNumber += 1;


            Order o40 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 1),
                TicketQuantity = 2,
                PopcornPoints = 30,
                OrderStatus = OrderStatus.Cancelled,


            };
            o40.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Michelle" && u.LastName == "Banks");
            Orders.Add(o40);
            intOrderNumber += 1;


            Order o41 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 1),
                TicketQuantity = 2,
                PopcornPoints = 30,
                OrderStatus = OrderStatus.Purchased,


            };
            o41.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Jim" && u.LastName == "Bob");
            Orders.Add(o41);
            intOrderNumber += 1;


            Order o42 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 1),
                TicketQuantity = 4,
                PopcornPoints = 60,
                OrderStatus = OrderStatus.Purchased,


            };
            o42.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Lou" && u.LastName == "Ann");
            Orders.Add(o42);
            intOrderNumber += 1;


            Order o43 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 1),
                TicketQuantity = 3,
                PopcornPoints = 36,
                OrderStatus = OrderStatus.Purchased,


            };
            o43.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");
            Orders.Add(o43);
            intOrderNumber += 1;


            Order o44 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 1),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o44.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Victoria" && u.LastName == "Lawrence");
            Orders.Add(o44);
            intOrderNumber += 1;


            Order o45 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 1),
                TicketQuantity = 2,
                PopcornPoints = 24,
                OrderStatus = OrderStatus.Purchased,


            };
            o45.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Franco" && u.LastName == "Broccolo");
            Orders.Add(o45);
            intOrderNumber += 1;


            Order o46 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 1),
                TicketQuantity = 2,
                PopcornPoints = 20,
                OrderStatus = OrderStatus.Purchased,


            };
            o46.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Wendy" && u.LastName == "Chang");
            Orders.Add(o46);
            intOrderNumber += 1;


            Order o47 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 1),
                TicketQuantity = 1,
                PopcornPoints = 10,
                OrderStatus = OrderStatus.Purchased,


            };
            o47.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Christopher" && u.LastName == "Baker");
            Orders.Add(o47);
            intOrderNumber += 1;


            Order o48 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 15),
                TicketQuantity = 1,
                PopcornPoints = 12,
                OrderStatus = OrderStatus.Purchased,


            };
            o48.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Lim" && u.LastName == "Chou");
            Orders.Add(o48);
            intOrderNumber += 1;


            Order o49 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 24),
                TicketQuantity = 9,
                PopcornPoints = 45,
                OrderStatus = OrderStatus.Cancelled,


            };
            o49.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Jim" && u.LastName == "Bob");
            Orders.Add(o49);
            intOrderNumber += 1;


            Order o50 = new Order()
            {
                OrderNumber = intOrderNumber,
                OrderDate = new DateTime(2023, 11, 26),
                TicketQuantity = 2,
                PopcornPoints = -200,
                OrderStatus = OrderStatus.Purchased,


            };
            o50.Customer = db.Users.FirstOrDefault(u => u.FirstName == "Brad" && u.LastName == "White");
            Orders.Add(o50);
            intOrderNumber += 1;


            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (Order orderToAdd in Orders)
                {
                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    Order dbOrder = db.Orders.FirstOrDefault(o => o.OrderID == orderToAdd.OrderID);

                    //if the dbBook is null, this title is not in the database
                    if (dbOrder == null)
                    {
                        //add the book to the database and save changes
                        db.Orders.Add(orderToAdd);
                        db.SaveChanges();

                        intOrdersAdded += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties
                        dbOrder.OrderDate = orderToAdd.OrderDate;
                        dbOrder.TicketQuantity = orderToAdd.TicketQuantity;
                        dbOrder.PopcornPoints = orderToAdd.PopcornPoints;
                        dbOrder.OrderStatus = orderToAdd.OrderStatus;
                        

                        //since we found the correct genre object in a previous step,
                        //this update is easy - both dbBook and bookToAdd have a Genre 
                        //object for this property
                        dbOrder.Customer = orderToAdd.Customer;

                        //update the database and save the changes
                        db.Update(dbOrder);
                        db.SaveChanges();

                        intOrdersAdded += 1;

                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                //Build a messsage using the flags we created
                String msg = "  Repositories added:" + intOrdersAdded + "; Error on " + intOrdersAdded;

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}



