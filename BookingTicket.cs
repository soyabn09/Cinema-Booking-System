using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using BookingFiles;

namespace BookingTickets
{
    class BookingTicket
    {
       /*
        * FinalTicket Method - Shows the user the final details before the user 
        * If a user doesn't choose any of the choices they will be brought back
        * The user will be given a confirmation when going back to the menu
       */
        public static void FinalTicket(string Title, string Length, string AR, string DT, string Screen, string Type, string Seats, string Price, int Screen1, int Seats1)
        {
            Console.Clear();
            Console.Write("\nTitle: " + Title + "\nLength: " + Length + "\nAge Rating: " + AR + "\nDate/Time: " + DT + "\nScreen No: " + Screen + "\nType: " + Type + "\nSeats: " + Seats + "\nTotal Price: " + Price + "\n\n");
            Console.Write("=======================================\n\n");
            Console.Write("Please choose one of the following options:");
            Console.Write("\n\n[1] CONFIRM BOOKING \n[2] MENU \n\n");

            try
            {
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Thread.Sleep(2000);
                    BookingFile.Booking(Title, Length, AR, DT, Screen, Type, Seats, Price, "=======================================");
                    BookingFile.Seats(Screen1, Seats1, 1);
                    Console.Clear();
                    Console.Write("\nBooking Confirmed!\n");
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.Write("\nTitle: " + Title + "\nLength: " + Length + "\nAge Rating: " + AR + "\nDate/Time: " + DT + "\nScreen No: " + Screen + "\nType: " + Type + "\nSeats: " + Seats + "\nTotal Price: " + Price + "\n\n");
                    Console.Write("=======================================\n\n");
                    Console.Write("ARE YOU SURE?");
                    Console.Write("\n\n[1] YES \n[2] NO \n\n");

                    try
                    {
                        int choice2 = int.Parse(Console.ReadLine());

                        if (choice2 == 1)
                        {

                        }
                        else if (choice2 == 2)
                        {
                            FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);
                        }
                        else
                        {
                            FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);
                        }
                    }
                    catch (Exception)
                    {
                        FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);
                    }

                }
                else
                {
                    FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);
                }
            }
            catch (Exception)
            {
                FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);
            }
        }
    }
}
