using System;
using System.Threading;
using System.IO;
using BookingFiles;
using BookingFilms;

namespace BookingMain
{
    class Program
    {
        public static void Main(string[] args)
        {
            while(true) // A while loop that when true which it is always, clears the console and sends the user to the Menu Method
            {
                Console.Clear();
                Menu(); 
            }
        }

        public static void Menu()
        {

            BookingFile.CreateDirectory(); // Executes the CreateDirectory Method in the BookingFile Class

            BookingFile.CreateFiles(); // Executes the CreateFiles Method in the BookingFile Class

            /*
             * Gives the user a choice to start the program or see the help menu
             * If a user doesn't choose any of the choices they will be brought back
            */

            Console.Write("\nCinema Booking System\n\n\n");
            Console.Write("Please choose one of the following options:");
            Console.Write("\n\n[1] START \n[2] HELP \n\n");
            try
            {
                int choice1 = int.Parse(Console.ReadLine());

                if (choice1 == 1)
                {
                    // FILM CHOICES - BookingFim Class
                    Thread.Sleep(1000);
                    BookingFilm.Films();
                }
                else if (choice1 == 2)
                {
                    // HELP MENU
                    Thread.Sleep(1000);
                    Help();
                }
                else
                {
                    // BACK TO MENU
                    Console.Write("\nIncorrect Option");
                    Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                // BACK TO MENU
                Console.Write("\nIncorrect Option");
                Thread.Sleep(2000);
            }

        }

        /*
         * The help menu is only given at the start of the program and will contain a bit of help on Choosing Films, Type of Seats and Confirming the Ticket
        */

        public static void Help()
        {
            Console.Clear();
            Console.Write("\n==================================================\n\n");
            Console.Write("Films: \n\nStart by choosing a film by inputting a number that represents the film then pressing the enter key to confirm your choice. \n\n");
            Console.Write("==================================================\n\n");
            Console.Write("Type of Seats: \n\nThe different types of seats available are Standard or VIP seats. \nOnce the film has been chosen you will be given the choice of choosing the type of seats, input the number represented next to the seat type and press enter to continue. \nChoose carefully as you will have to wait till you get to the ticket confirmation to be able to start over. \n\n");
            Console.Write("==================================================\n\n");
            Console.Write("Ticket: \n\nThe ticket confirmation is the last stage, here will be the details of your ticket and will be given a choice to confirm the booking or go back to the menu. \nIf the choice is to go back to the menu and it was done by accident, you will be given another chance to confirm your option. \n\n");
            Console.Write("==================================================\n\n");
            Console.Write("Please choose the following option:");
            Console.Write("\n\n[1] BACK \n\n");

            try
            {
                int choice2 = int.Parse(Console.ReadLine());

                if (choice2 == 1)
                {
                    // BACK TO MENU
                    Thread.Sleep(1000);
                }
                else
                {
                    // BACK TO HELP
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Help();
                }
            }
            catch (Exception)
            {
                // BACK TO HELP
                Console.WriteLine();
                Thread.Sleep(2000);
                Help();
            }
        }

    }
}
