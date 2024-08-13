using System;
using Group_26_Final_Project.DAL;
using Group_26_Final_Project.Models;
using Microsoft.SqlServer.Server;
using static System.Reflection.Metadata.BlobBuilder;

namespace Group_26_Final_Project.Seeding
{
    public static class SeedOrderDetails
    {

        public async static void SeedOneOrderDetail(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intDetailsAdded = 0;

            // create orderdetails list and instance of orderdetails
            List<OrderDetail> OrderDetails = new List<OrderDetail>();



            OrderDetail od0 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "A1",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od0.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10001);
            od0.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 1);

            OrderDetails.Add(od0);



            OrderDetail od1 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "A2",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od1.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10001);
            od1.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 1);

            OrderDetails.Add(od1);



            OrderDetail od2 = new OrderDetail()
            {
                TransactionID = 3,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "A3",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od2.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10001);
            od2.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 1);

            OrderDetails.Add(od2);



            OrderDetail od3 = new OrderDetail()
            {
                TransactionID = 4,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "A4",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od3.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10001);
            od3.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 1);

            OrderDetails.Add(od3);



            OrderDetail od4 = new OrderDetail()
            {
                TransactionID = 5,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "A5",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od4.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10001);
            od4.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 1);

            OrderDetails.Add(od4);



            OrderDetail od5 = new OrderDetail()
            {
                TransactionID = 6,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "B1",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od5.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10001);
            od5.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 1);

            OrderDetails.Add(od5);



            OrderDetail od6 = new OrderDetail()
            {
                TransactionID = 7,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "B2",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od6.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10001);
            od6.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 1);

            OrderDetails.Add(od6);



            OrderDetail od7 = new OrderDetail()
            {
                TransactionID = 8,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "B3",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od7.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10001);
            od7.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 1);

            OrderDetails.Add(od7);



            OrderDetail od8 = new OrderDetail()
            {
                TransactionID = 9,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "B4",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od8.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10001);
            od8.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 1);

            OrderDetails.Add(od8);



            OrderDetail od9 = new OrderDetail()
            {
                TransactionID = 10,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "B5",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od9.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10001);
            od9.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 1);

            OrderDetails.Add(od9);



            OrderDetail od10 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 16, 30, 0),
                SeatNumber = "A1",
                PopcornPoint = 10,
                SeniorDiscount = true,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 10,

            };
            od10.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10002);
            od10.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 2);

            OrderDetails.Add(od10);



            OrderDetail od11 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 11, 24, 16, 30, 0),
                SeatNumber = "A2",
                PopcornPoint = 10,
                SeniorDiscount = true,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 10,

            };
            od11.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10002);
            od11.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 2);

            OrderDetails.Add(od11);



            OrderDetail od12 = new OrderDetail()
            {
                TransactionID = 3,
                DateTime = new DateTime(2023, 11, 24, 16, 30, 0),
                SeatNumber = "A3",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od12.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10002);
            od12.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 2);

            OrderDetails.Add(od12);



            OrderDetail od13 = new OrderDetail()
            {
                TransactionID = 4,
                DateTime = new DateTime(2023, 11, 24, 16, 30, 0),
                SeatNumber = "A4",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od13.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10002);
            od13.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 2);

            OrderDetails.Add(od13);



            OrderDetail od14 = new OrderDetail()
            {
                TransactionID = 5,
                DateTime = new DateTime(2023, 11, 24, 16, 30, 0),
                SeatNumber = "A5",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od14.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10002);
            od14.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 2);

            OrderDetails.Add(od14);



            OrderDetail od15 = new OrderDetail()
            {
                TransactionID = 6,
                DateTime = new DateTime(2023, 11, 24, 16, 30, 0),
                SeatNumber = "B1",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od15.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10002);
            od15.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 2);

            OrderDetails.Add(od15);



            OrderDetail od16 = new OrderDetail()
            {
                TransactionID = 7,
                DateTime = new DateTime(2023, 11, 24, 16, 30, 0),
                SeatNumber = "B2",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od16.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10002);
            od16.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 2);

            OrderDetails.Add(od16);



            OrderDetail od17 = new OrderDetail()
            {
                TransactionID = 8,
                DateTime = new DateTime(2023, 11, 24, 16, 30, 0),
                SeatNumber = "B3",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od17.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10002);
            od17.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 2);

            OrderDetails.Add(od17);



            OrderDetail od18 = new OrderDetail()
            {
                TransactionID = 9,
                DateTime = new DateTime(2023, 11, 24, 16, 30, 0),
                SeatNumber = "B4",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od18.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10002);
            od18.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 2);

            OrderDetails.Add(od18);



            OrderDetail od19 = new OrderDetail()
            {
                TransactionID = 10,
                DateTime = new DateTime(2023, 11, 24, 16, 30, 0),
                SeatNumber = "B5",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od19.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10002);
            od19.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 2);

            OrderDetails.Add(od19);



            OrderDetail od20 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "C2",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od20.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10003);
            od20.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 3);

            OrderDetails.Add(od20);



            OrderDetail od21 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "C3",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od21.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10003);
            od21.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 3);

            OrderDetails.Add(od21);



            OrderDetail od22 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "C4",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od22.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10004);
            od22.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 4);

            OrderDetails.Add(od22);



            OrderDetail od23 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 11, 23, 11, 0, 0),
                SeatNumber = "C5",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 5,

            };
            od23.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10004);
            od23.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 4);

            OrderDetails.Add(od23);



            OrderDetail od24 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "A1",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od24.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10005);
            od24.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 5);

            OrderDetails.Add(od24);



            OrderDetail od25 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "A2",
                PopcornPoint = 10,
                SeniorDiscount = true,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 10,

            };
            od25.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10006);
            od25.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 6);

            OrderDetails.Add(od25);



            OrderDetail od26 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "A3",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od26.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10007);
            od26.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 7);

            OrderDetails.Add(od26);



            OrderDetail od27 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "A4",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od27.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10008);
            od27.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 8);

            OrderDetails.Add(od27);



            OrderDetail od28 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "A5",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od28.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10009);
            od28.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 9);

            OrderDetails.Add(od28);



            OrderDetail od29 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "B1",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od29.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10010);
            od29.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 10);

            OrderDetails.Add(od29);



            OrderDetail od30 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "B2",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od30.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10011);
            od30.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 11);

            OrderDetails.Add(od30);



            OrderDetail od31 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "B3",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od31.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10012);
            od31.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 12);

            OrderDetails.Add(od31);



            OrderDetail od32 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "B4",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od32.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10013);
            od32.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 13);

            OrderDetails.Add(od32);



            OrderDetail od33 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "B5",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od33.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10014);
            od33.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 14);

            OrderDetails.Add(od33);



            OrderDetail od34 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "E1",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od34.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10015);
            od34.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 15);

            OrderDetails.Add(od34);



            OrderDetail od35 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "E2",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od35.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10016);
            od35.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 16);

            OrderDetails.Add(od35);



            OrderDetail od36 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "E3",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od36.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10017);
            od36.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 17);

            OrderDetails.Add(od36);



            OrderDetail od37 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "E4",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od37.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10018);
            od37.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 18);

            OrderDetails.Add(od37);



            OrderDetail od38 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "E5",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od38.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10019);
            od38.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 19);

            OrderDetails.Add(od38);



            OrderDetail od39 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "C4",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od39.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10020);
            od39.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 20);

            OrderDetails.Add(od39);



            OrderDetail od40 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 24, 21, 0, 0),
                SeatNumber = "C5",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od40.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10021);
            od40.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 21);

            OrderDetails.Add(od40);



            OrderDetail od41 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "D1",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od41.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10022);
            od41.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 22);

            OrderDetails.Add(od41);



            OrderDetail od42 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "A2",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od42.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10023);
            od42.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 23);

            OrderDetails.Add(od42);



            OrderDetail od43 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "A3",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od43.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10024);
            od43.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 24);

            OrderDetails.Add(od43);



            OrderDetail od44 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "A4",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od44.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10025);
            od44.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 25);

            OrderDetails.Add(od44);



            OrderDetail od45 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "A5",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od45.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10026);
            od45.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 26);

            OrderDetails.Add(od45);



            OrderDetail od46 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "B1",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od46.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10027);
            od46.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 27);

            OrderDetails.Add(od46);



            OrderDetail od47 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "B2",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od47.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10028);
            od47.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 28);

            OrderDetails.Add(od47);



            OrderDetail od48 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "B3",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od48.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10029);
            od48.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 29);

            OrderDetails.Add(od48);



            OrderDetail od49 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "B4",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od49.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10030);
            od49.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 30);

            OrderDetails.Add(od49);



            OrderDetail od50 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "B5",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od50.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10031);
            od50.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 31);

            OrderDetails.Add(od50);



            OrderDetail od51 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "E1",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od51.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10032);
            od51.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 32);

            OrderDetails.Add(od51);



            OrderDetail od52 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "E2",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od52.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10033);
            od52.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 33);

            OrderDetails.Add(od52);



            OrderDetail od53 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "E3",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od53.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10034);
            od53.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 34);

            OrderDetails.Add(od53);



            OrderDetail od54 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "E4",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od54.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10035);
            od54.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 35);

            OrderDetails.Add(od54);



            OrderDetail od55 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "E5",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od55.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10036);
            od55.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 36);

            OrderDetails.Add(od55);



            OrderDetail od56 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "C4",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od56.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10037);
            od56.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 37);

            OrderDetails.Add(od56);



            OrderDetail od57 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 21, 0, 0),
                SeatNumber = "C5",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 15,

            };
            od57.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10038);
            od57.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 38);

            OrderDetails.Add(od57);



            OrderDetail od58 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "D1",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od58.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10039);
            od58.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 39);

            OrderDetails.Add(od58);



            OrderDetail od59 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "A2",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od59.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10039);
            od59.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 39);

            OrderDetails.Add(od59);



            OrderDetail od60 = new OrderDetail()
            {
                TransactionID = 3,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "A3",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od60.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10039);
            od60.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 39);

            OrderDetails.Add(od60);



            OrderDetail od61 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "A4",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od61.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10040);
            od61.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 40);

            OrderDetails.Add(od61);



            OrderDetail od62 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "A5",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od62.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10040);
            od62.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 40);

            OrderDetails.Add(od62);



            OrderDetail od63 = new OrderDetail()
            {
                TransactionID = 3,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "B1",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od63.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10040);
            od63.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 40);

            OrderDetails.Add(od63);



            OrderDetail od64 = new OrderDetail()
            {
                TransactionID = 4,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "B2",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od64.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10040);
            od64.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 40);

            OrderDetails.Add(od64);



            OrderDetail od65 = new OrderDetail()
            {
                TransactionID = 5,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "B3",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od65.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10040);
            od65.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 40);

            OrderDetails.Add(od65);



            OrderDetail od66 = new OrderDetail()
            {
                TransactionID = 6,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "B4",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od66.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10040);
            od66.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 40);

            OrderDetails.Add(od66);



            OrderDetail od67 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "B5",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od67.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10041);
            od67.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 41);

            OrderDetails.Add(od67);



            OrderDetail od68 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "E1",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od68.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10041);
            od68.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 41);

            OrderDetails.Add(od68);



            OrderDetail od69 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "E2",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od69.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10042);
            od69.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 42);

            OrderDetails.Add(od69);



            OrderDetail od70 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "E3",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od70.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10042);
            od70.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 42);

            OrderDetails.Add(od70);



            OrderDetail od71 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "E4",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od71.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10043);
            od71.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 43);

            OrderDetails.Add(od71);



            OrderDetail od72 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "E5",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od72.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10043);
            od72.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 43);

            OrderDetails.Add(od72);



            OrderDetail od73 = new OrderDetail()
            {
                TransactionID = 3,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "C4",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od73.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10043);
            od73.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 43);

            OrderDetails.Add(od73);



            OrderDetail od74 = new OrderDetail()
            {
                TransactionID = 4,
                DateTime = new DateTime(2023, 11, 25, 19, 30, 0),
                SeatNumber = "C5",
                PopcornPoint = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 15,

            };
            od74.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10043);
            od74.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 43);

            OrderDetails.Add(od74);



            OrderDetail od75 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 12, 0, 0),
                SeatNumber = "B2",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od75.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10044);
            od75.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 44);

            OrderDetails.Add(od75);



            OrderDetail od76 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 11, 25, 12, 0, 0),
                SeatNumber = "B3",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od76.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10044);
            od76.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 44);

            OrderDetails.Add(od76);



            OrderDetail od77 = new OrderDetail()
            {
                TransactionID = 3,
                DateTime = new DateTime(2023, 11, 25, 12, 0, 0),
                SeatNumber = "B4",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od77.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10044);
            od77.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 44);

            OrderDetails.Add(od77);



            OrderDetail od78 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 12, 0, 0),
                SeatNumber = "B5",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od78.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10045);
            od78.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 45);

            OrderDetails.Add(od78);



            OrderDetail od79 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 12, 0, 0),
                SeatNumber = "E1",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od79.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10046);
            od79.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 46);

            OrderDetails.Add(od79);



            OrderDetail od80 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 11, 25, 12, 0, 0),
                SeatNumber = "E2",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od80.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10046);
            od80.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 46);

            OrderDetails.Add(od80);



            OrderDetail od81 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 12, 0, 0),
                SeatNumber = "E3",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od81.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10047);
            od81.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 47);

            OrderDetails.Add(od81);



            OrderDetail od82 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 11, 25, 12, 0, 0),
                SeatNumber = "E4",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od82.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10047);
            od82.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 47);

            OrderDetails.Add(od82);



            OrderDetail od83 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 12, 0, 0),
                SeatNumber = "E5",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 12,

            };
            od83.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10048);
            od83.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 48);

            OrderDetails.Add(od83);



            OrderDetail od84 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 25, 9, 0, 0),
                SeatNumber = "E5",
                PopcornPoint = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater2,
                ShowtimePrice = 12,

            };
            od84.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10049);
            od84.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 49);

            OrderDetails.Add(od84);



            OrderDetail od85 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 11, 27, 11, 0, 0),
                SeatNumber = "A4",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 5,

            };
            od85.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10050);
            od85.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 50);

            OrderDetails.Add(od85);



            OrderDetail od86 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 11, 27, 11, 0, 0),
                SeatNumber = "E1",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 5,

            };
            od86.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10050);
            od86.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 50);

            OrderDetails.Add(od86);



            OrderDetail od87 = new OrderDetail()
            {
                TransactionID = 3,
                DateTime = new DateTime(2023, 11, 27, 11, 0, 0),
                SeatNumber = "E2",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 5,

            };
            od87.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10050);
            od87.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 50);

            OrderDetails.Add(od87);



            OrderDetail od88 = new OrderDetail()
            {
                TransactionID = 4,
                DateTime = new DateTime(2023, 11, 27, 11, 0, 0),
                SeatNumber = "E3",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 5,

            };
            od88.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10050);
            od88.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 50);

            OrderDetails.Add(od88);



            OrderDetail od89 = new OrderDetail()
            {
                TransactionID = 5,
                DateTime = new DateTime(2023, 11, 27, 11, 0, 0),
                SeatNumber = "E4",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 5,

            };
            od89.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10050);
            od89.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 50);

            OrderDetails.Add(od89);



            OrderDetail od90 = new OrderDetail()
            {
                TransactionID = 6,
                DateTime = new DateTime(2023, 11, 27, 11, 0, 0),
                SeatNumber = "E5",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 5,

            };
            od90.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10050);
            od90.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 50);

            OrderDetails.Add(od90);



            OrderDetail od91 = new OrderDetail()
            {
                TransactionID = 7,
                DateTime = new DateTime(2023, 11, 27, 11, 0, 0),
                SeatNumber = "B3",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 5,

            };
            od91.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10050);
            od91.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 50);

            OrderDetails.Add(od91);



            OrderDetail od92 = new OrderDetail()
            {
                TransactionID = 8,
                DateTime = new DateTime(2023, 11, 27, 11, 0, 0),
                SeatNumber = "B4",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 5,

            };
            od92.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10050);
            od92.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 50);

            OrderDetails.Add(od92);



            OrderDetail od93 = new OrderDetail()
            {
                TransactionID = 9,
                DateTime = new DateTime(2023, 11, 27, 11, 0, 0),
                SeatNumber = "B5",
                PopcornPoint = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CardCash,
                Theater = Theater.Theater1,
                ShowtimePrice = 5,

            };
            od93.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10050);
            od93.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 50);

            OrderDetails.Add(od93);



            OrderDetail od94 = new OrderDetail()
            {
                TransactionID = 1,
                DateTime = new DateTime(2023, 12, 4, 22, 0, 0),
                SeatNumber = "C3",
                PopcornPoint = -100,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.PopcornPoint,
                Theater = Theater.Theater2,
                ShowtimePrice = 0,

            };
            od94.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10051);
            od94.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 51);

            OrderDetails.Add(od94);



            OrderDetail od95 = new OrderDetail()
            {
                TransactionID = 2,
                DateTime = new DateTime(2023, 12, 4, 22, 0, 0),
                SeatNumber = "C4",
                PopcornPoint = -100,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.PopcornPoint,
                Theater = Theater.Theater2,
                ShowtimePrice = 0,

            };
            od95.Order = db.Orders.FirstOrDefault(m => m.OrderNumber == 10051);
            od95.Showtime = db.Showtimes.FirstOrDefault(p => p.ShowtimeID == 51);

            OrderDetails.Add(od95);



            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (OrderDetail orderDetailToAdd in OrderDetails)
                {
                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    OrderDetail dbOrderDetail = db.OrderDetails.FirstOrDefault(s => s.OrderDetailID == orderDetailToAdd.OrderDetailID);

                    //if the dbBook is null, this title is not in the database
                    if (dbOrderDetail == null)
                    {
                        //add the book to the database and save changes
                        db.OrderDetails.Add(orderDetailToAdd);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intDetailsAdded += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties
                        dbOrderDetail.DateTime = orderDetailToAdd.DateTime;
                        dbOrderDetail.SeatNumber = orderDetailToAdd.SeatNumber;
                        dbOrderDetail.PopcornPoint = orderDetailToAdd.PopcornPoint;
                        dbOrderDetail.SeniorDiscount = orderDetailToAdd.SeniorDiscount;
                        dbOrderDetail.PaymentMethod = orderDetailToAdd.PaymentMethod;

                        //since we found the correct genre object in a previous step,
                        //this update is easy - both dbBook and bookToAdd have a Genre 
                        //object for this property
                        dbOrderDetail.Order = orderDetailToAdd.Order;
                        dbOrderDetail.Showtime = orderDetailToAdd.Showtime;

                        //update the database and save the changes
                        db.Update(dbOrderDetail);
                        db.SaveChanges();

                        intDetailsAdded += 1;

                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                //Build a messsage using the flags we created
                String msg = "  Repositories added:" + intDetailsAdded + "; Error on " + intDetailsAdded;

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}



