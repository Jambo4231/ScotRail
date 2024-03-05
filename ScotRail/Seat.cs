using System;

namespace ScotRail
{
    internal class Seat
    {
        public int SeatID { get;  set; }
        public int CustomerID { get;  set; }
        public bool IsBooked { get;  set; }
        public Customer AssignedCustomer { get;  set; }


        public Seat(int seatID)
        {
            SeatID = seatID;
            CustomerID = -1;
            IsBooked = false;
        }

        public void DisplaySeat()
        {
            Console.WriteLine($"Seat {SeatID}: {(IsBooked ? "Booked" : "Available")}");
            if (IsBooked)
            {
                Console.WriteLine($"Booked by Customer ID:{CustomerID}");
            }
        }

        public void CancelSeat()
        {
            if (IsBooked)
            {
                IsBooked = false;
                CustomerID = -1;
                Console.WriteLine($"Seat {SeatID} is no longer booked");
            }
            else
            {
                Console.WriteLine($"Seat {SeatID} isn't booked");
            }
        }

        public void BookSeat(Customer customer)
        {
            if (!IsBooked)
            {
                IsBooked=true;
                AssignedCustomer = customer;
                CustomerID = customer.CustomerID;
                Console.WriteLine($"Seat {SeatID} is now booked by Customer ID: {customer.CustomerID}");
            }
            else
            {
                Console.WriteLine($"Seat {SeatID} is already booked.");
            }
        }
    }
}
