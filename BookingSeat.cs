using System;
using System.Collections.Generic;
using System.Text;
using BookingFiles;
using BookingTickets;

namespace BookingSeats
{
    class BookingSeat
    {
        /*
         * Standard Method - Alows the user to input any number of seats
         * The number of seats will be checked by the Seats Method in the BookingFile Class
         * If a user doesn't choose any of the choices they will be brought back
        */

        public static void Standard(string Title, string Length, string AR, string DT, string Screen)
        {
            Console.Clear();
            Console.Write("\nPlease input the amount of seats: ");
            try
            {
                int input1 = int.Parse(Console.ReadLine());

                if (input1 <= 0)
                {
                    Standard(Title, Length, AR, DT, Screen);
                }

                BookingFile.Seats(Convert.ToInt16(Screen), input1, 0);

                double price = input1 * 9.99;

                int Screen1 = Convert.ToInt32(Screen);
                int Seats1 = Convert.ToInt32(input1);

                BookingTicket.FinalTicket(Title, Length, AR, DT, Screen, "Standard", input1.ToString(), price.ToString(), Screen1, Seats1);
            }
            catch (Exception)
            {
                Standard(Title, Length, AR, DT, Screen);
            }
        }

        /*
        * VIP Method - Alows the user to input any number of seats
        * The number of seats will be checked by the Seats Method in the BookingFile Class
        * If a user doesn't choose any of the choices they will be brought back
       */

        public static void VIP(string Title, string Length, string AR, string DT, string Screen)
        {
            Console.Clear();
            Console.Write("\nPlease input the amount of seats: ");
            try
            {
                int input2 = int.Parse(Console.ReadLine());

                if (input2 <= 0)
                {
                    VIP(Title, Length, AR, DT, Screen);
                }

                BookingFile.Seats(Convert.ToInt16(Screen), input2, 0);

                double price = input2 * 15.00;

                int Screen1 = Convert.ToInt32(Screen);
                int Seats1 = Convert.ToInt32(input2);

                BookingTicket.FinalTicket(Title, Length, AR, DT, Screen, "VIP", input2.ToString(), price.ToString(), Screen1, Seats1);
            }
            catch (Exception)
            {
                VIP(Title, Length, AR, DT, Screen);
            }
        }
    }
}
