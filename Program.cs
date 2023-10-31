using System;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace Webshop_Console
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("--------- \nLogin Screen \n---------");

            Console.WriteLine("1. Sign up \n2. Sign in \n3. Exit");
            Console.WriteLine("Note: Enter the number to choose" +
                "your function throughout the program");
            Console.Write("Choose your function: ");
            string loginInput = Console.ReadLine();

            while (loginInput != "3")
            {
                if (loginInput == "1")
                    SignUpScreen();
                else if (loginInput == "2")
                    SignInScreen();
                else
                {
                    Console.WriteLine("Invalid Input. Try again. Redirecting...");
                    Console.ReadLine();
                    Menu();
                }
            }
        }

        static void SignInScreen()
        {
            Console.Clear();
            Console.WriteLine("--------- \n Sign in Menu \n ---------");
            Console.WriteLine("");

            Console.Write("Enter your Username: ");
            string signInName = Console.ReadLine();

            Console.Write("Enter your Password: ");
            string signInPass = Console.ReadLine();

            if (signInName == name && signInPass == password)
            {
                Console.Clear();
                Console.Write("Login Successful... \n Redirecting...");
                Console.ReadLine();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Creditentials, please try again.");
                Console.ReadLine();
                SignInScreen();
            }

        }

        static void SignUpScreen()
        {
            Console.Clear();
            Console.WriteLine("---------\nSign Up Menu\n---------");

            Console.Write("Enter your Email: ");
            email = Console.ReadLine();

            Console.Write("Enter your Username: ");
            name = Console.ReadLine();

            Console.Write("Enter your Password: ");
            password = Console.ReadLine();

            Console.Write("Enter your Phone Number: ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Registered Successfully. Redirecting...");
            Console.ReadLine();
            Menu();
        }

        static void HomePage()
        {
            Console.WriteLine("""
            ----------Audio WebStore--------  
            ------HomePage------
              
            --Categories--       --Account--                --Help Centre--   
            1C. Headphones       1A. Account Details        1H. Write a Support Ticket 
            2C. IEM's            2A. Cart                   2H. Frequently Asked Questions
            3C. Eartips          3A. Sign Out               3H. Deliver Partners    
            4C. DAC/AMP's        4A. Exit Website
            """);

            Console.Write("User Input: ");
            string userInputHomePage = Console.ReadLine();

            while (userInputHomePage != "4A")
            {
                if (userInputHomePage == "1C")
                    Headphones();
                else if (userInputHomePage == "2C")
                    IEM();
                else if (userInputHomePage == "3C")
                    Eartips();
                else if (userInputHomePage == "4C")
                    DAC();
                else
                {
                    Console.WriteLine("Invalid Input. Try again. \nRedirecting...");
                   HomePage();
                }
            }
            Console.WriteLine("Thanks for visiting");
            Environment.Exit(0);



        }
        static void IEM()
        {
            string[] IEM = { "7hz Salnotes Zero", "TruthEar Hola", "Moondrop Chu", "" };
        }
        static void Eartips()
        {
            string[] EarTips = { "Silicon Tips" };
        }
        static void DAC()
        {

        }
        static void Headphones()
        {

        }
        public static string name, password, email;
        public static int phoneNumber;

    }
}