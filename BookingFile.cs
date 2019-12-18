using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using BookingFilms;

namespace BookingFiles
{
    class BookingFile
    {

        /*
         * CreateDirectory Method - Creates directory called CinemaBookingSystem in C Drive if none exists
        */ 

        public static void CreateDirectory()
        {
            Directory.CreateDirectory("C:\\CinemaBookingSystem");
        }

        /*
         * CreateFiles Method - Creates files called Booking.txt and Seats.txt with the amount of seats for each screening in CinemaBookingSystem directory if none already exists
        */

        public static void CreateFiles()
        {
            if (!File.Exists(@"C:\CinemaBookingSystem\Booking.txt"))
            {
                File.Create(@"C:\CinemaBookingSystem\Booking.txt");
            }

            if (!File.Exists(@"C:\CinemaBookingSystem\Seats.txt"))
            {
                string[] seats = new string[3] {"50", "50", "50"};

                File.WriteAllLines(@"C:\CinemaBookingSystem\Seats.txt", seats);
            }

        }

        /*
         * Booking Method - Saves the Title, Length, AR, DT, Screen, Type, Seats, Price and a Line to seperate between the different bookings in Bookings.txt 
        */

        public static void Booking(string Title, string Length, string AR, string DT, string Screen, string Type, string Seats, string Price, string Line)
        {
            string[] Booking = new string[9] { Title, Length, AR, DT, Screen, Type, Seats, Price, Line };

            File.AppendAllLines(@"C:\CinemaBookingSystem\Booking.txt", Booking);

        }

        /*
         * Seats Method - Updates the number of seats left in Seats.txt
        */

        public static void Seats(int num1, int num2, int num3)
        {

            string[] Seats = File.ReadAllLines(@"C:\CinemaBookingSystem\Seats.txt");

            if (num1 == 1)
            {

                int result = Subtract1(num2);

                Seats[0] = result.ToString();

                string[] seats = { Seats[0], Seats[1], Seats[2] };

                if (num3 == 1)
                {
                    File.WriteAllLines(@"C:\CinemaBookingSystem\Seats.txt", seats);
                }

            }
            else if (num1 == 2)
            {

                int result = Subtract2(num2);

                Seats[1] = result.ToString();

                string[] seats = { Seats[0], Seats[1], Seats[2] };

                if (num3 == 1)
                {
                    File.WriteAllLines(@"C:\CinemaBookingSystem\Seats.txt", seats);
                }

            }
            else if (num1 == 3)
            {

                int result = Subtract3(num2);

                Seats[2] = result.ToString();

                string[] seats = { Seats[0], Seats[1], Seats[2] };

                if (num3 == 1)
                {
                    File.WriteAllLines(@"C:\CinemaBookingSystem\Seats.txt", seats);
                }

            }
        }

        /*
         * Subtract Methods - Checks if number of seats a user requested is avilable in the Seats.txt File and returns the result to Seats Method 
         * Or displays the number of seats left, if the user requested number is higher than the amount of seats available and takes the user to the Films Method in BookingFilm Class 
        */

        public static int Subtract1(int num1)
        {

            string[] Seats = File.ReadAllLines(@"C:\CinemaBookingSystem\Seats.txt");

            int[] SeatNum = Array.ConvertAll(Seats, int.Parse);

            if (SeatNum[0] < num1)
            {
                Console.Write("\n\nNumber of seats left in Screen 1: " + SeatNum[0]);
                Thread.Sleep(3000);
                BookingFilm.Films();
            }

            return SeatNum[0] - num1;
        }

        public static int Subtract2(int num1)
        {

            string[] Seats = File.ReadAllLines(@"C:\CinemaBookingSystem\Seats.txt");

            int[] SeatNum = Array.ConvertAll(Seats, int.Parse);

            if (SeatNum[1] < num1)
            {
                Console.Write("\n\nNumber of seats left in Screen 2: " + SeatNum[1]);
                Thread.Sleep(3000);
                BookingFilm.Films();
            }

            return SeatNum[1] - num1;
        }

        public static int Subtract3(int num1)
        {

            string[] Seats = File.ReadAllLines(@"C:\CinemaBookingSystem\Seats.txt");

            int[] SeatNum = Array.ConvertAll(Seats, int.Parse);

            if (SeatNum[2] < num1)
            {
                Console.Write("\n\nNumber of seats left in Screen 3: " + SeatNum[2]);
                Thread.Sleep(3000);
                BookingFilm.Films();
            }

            return SeatNum[2] - num1;
        }
    }
}
