using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using BookingSeats;

namespace BookingFilms
{
    class BookingFilm
    {

        /*
         * Films Method - Shows the user the options between the different films showing
         * If a user doesn't choose any of the choices they will be brought back
        */

        public static void Films()
        {
            Console.Clear();
            Console.Write("\n==================================================");
            Console.Write("\n\nTitle: The Lion King \nLength: 1h 58m \nAge Rating: PG \nDate/Time: 12:00 20/12/19  \nScreen No: 1 \n\n");
            Console.Write("==================================================");
            Console.Write("\n\nTitle: Star Wars: The Rise of Skywalker \nLength: 2h 22m \nAge Rating: PG \nDate/Time: 15:00 20/12/19 \nScreen No: 2 \n\n");
            Console.Write("==================================================");
            Console.Write("\n\nTitle: John Wick: Chapter 3 - Parabellum \nLength: 2h 10m \nAge Rating: R \n Date/Time: 18:00 20/12/19 \nScreen No: 3 \n\n");
            Console.Write("==================================================");
            Console.Write("\n\nPlease choose one of the above films:");
            Console.Write("\n\n[1] The Lion King \n[2] Star Wars: The Rise of Skywalker \n[3] John Wick: Chapter 3 - Parabellum \n\n");

            try
            {
                int choice3 = int.Parse(Console.ReadLine());

                if (choice3 == 1)
                {
                    // FILM CHOICE AVENGERS
                    Console.WriteLine();
                    Seats("The Lion King", "1h 58m", "PG", "12:00 20/12/19", "1");
                    Thread.Sleep(2000);
                }
                else if (choice3 == 2)
                {
                    // FILM CHOICE JOKER
                    Console.WriteLine();
                    Seats("Star Wars: The Rise of Skywalker", "2h 22m", "PG", "15:00 20/12/19", "2");
                    Thread.Sleep(2000);
                }
                else if (choice3 == 3)
                {
                    // FILM CHOICE TOY STORY 4
                    Console.WriteLine();
                    Seats("John Wick: Chapter 3 - Parabellum", "2h 10m", "R", "18:00 20/12/19", "3");
                    Thread.Sleep(2000);
                }
                else
                {
                    // BACK TO OPTIONS
                    Films();
                }
            }
            catch (Exception)
            {
                // BACK TO OPTIONS
                Films();
            }
        }

       /*
        * Seats Method - Shows the user the options between the different types of seats
        * If a user doesn't choose any of the choices they will be brought back
       */

        public static void Seats(string Title, string Length, string AR, string DT, string Screen)
        {
            Console.Clear();
            Console.Write("\nPlease choose one of the following choice of seats: ");
            Console.Write("\n[1] Standard Seats - £9.99 \n[2] VIP Seats - £15.00 \n\n");

            try
            {
                int choice4 = int.Parse(Console.ReadLine());

                if (choice4 == 1)
                {
                    // SEAT TYPE STANDARD
                    Console.WriteLine();
                    BookingSeat.Standard(Title, Length, AR, DT, Screen);
                    Thread.Sleep(2000);
                }
                else if (choice4 == 2)
                {
                    // SEAT TYPE VIP
                    Console.WriteLine();
                    BookingSeat.VIP(Title, Length, AR, DT, Screen);
                    Thread.Sleep(2000);
                }
                else
                {
                    // BACK TO SEAT TYPE OPTIONS
                    Seats(Title, Length, AR, DT, Screen);
                }
            }
            catch (Exception)
            {
                // BACK TO SEAT TYPE OPTIONS
                Seats(Title, Length, AR, DT, Screen);
            }
        }
    }
}
