using ScotRail;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


class Program
{
    static List<Seat> seats = new List<Seat>();
    static void Main()
    {
        for (int i = 0; i < 8; i++)
        {
            Seat seat = new Seat(i + 1); 
            seats.Add(seat);
        }

        while (true)
        {
            Console.WriteLine("1. Display Seats");
            Console.WriteLine("2. Book Seat");
            Console.WriteLine("3. Cancel Seat");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Please enter your choice from 1-4:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayAllSeats();
                    break;

                case "2":
                    BookSeat();
                    break;

                case "3":
                    CancelSeat();
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose a number from 1-4.");
                    break;
            }
        }
    }

    static void DisplayAllSeats()
    {
        foreach (var seat in seats)
        {
            seat.DisplaySeat();
        }
    }

    static void BookSeat()
    {
       
          
        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your surname:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter your email:");
        string email = Console.ReadLine();

        Console.WriteLine("Are you a first-class customer? (yes/no):");
        bool isFirstClass = Console.ReadLine().ToLower() == "yes";

        Customer customer;

        if (isFirstClass)
        {
            customer = new FirstClass(firstName, lastName, email);
        }
        else
        {
            customer = new SecondClass(firstName, lastName, email);
        }

        
        Console.WriteLine("Which seat would you like to book? Seats are numbered from 1 to 8");
        if (int.TryParse(Console.ReadLine(), out int seatID) && seatID >= 1 && seatID <= seats.Count)
        {
            seats[seatID - 1].BookSeat(customer);
        }
        else
        {
            Console.WriteLine("Invalid seat number. Please enter a number between 1 and 8.");
        }
        
    }

    static void CancelSeat()
    {
        Console.WriteLine("What seat booking do you wish to cancel?");
        if (int.TryParse(Console.ReadLine(), out int seatID) && seatID >= 1 && seatID <= seats.Count)
        {
            seats[seatID - 1].CancelSeat();
        }
        else
        {
            Console.WriteLine("Invalid seat number. Please enter a number between 1 and 8.");
        }
    }
}
