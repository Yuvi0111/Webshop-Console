using System;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace Webshop_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- \n Login Screen \n ---------");
            Console.WriteLine("1. Sign up \n 2. Sign in \n 3. Exit");
            Console.WriteLine("Note: Enter the number to choose" +
                "your function throughout the program");
            Console.Write("Choose your function: ");
            string loginInput = Console.ReadLine();

            while (loginInput != "3") ;
            { if (loginInput == "1")
                    SignUpScreen();
                else if (loginInput == "2")
                    SignInScreen();
                else
                {
                    Console.WriteLine("Invalid Input. Try again. Redirecting..."); Console.ReadLine();
                    Main();
                }

            }
        }
        static void SignInScreen(string name, string password, string phoneNumber, string email)
        {
            Console.Clear();
            Console.WriteLine("--------- \n Sign in Menu \n ---------");
            Console.WriteLine("");

            Console.Write("Enter your Username: ");
            string SignInName = Console.ReadLine();

            Console.Write("Enter your Password: ");
            string SignInPass = Console.ReadLine();

            if (SignInName==name && SignInPass==password)
            {
                Console.Clear();
                Console.Write("Login Successful... \n Redirecting..."); Console.ReadLine();
                
            }
            else
            {
                Console.Clear();   
                Console.WriteLine("Invalid Creditentials, please try again."); Console.ReadLine();
                SignInScreen();
            }

        }

        static void SignUpScreen()
        {
            Console.Clear();
            Console.WriteLine("---------\nSign Up Menu\n---------");

            Console.Write("Enter your Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your Username: ");
            string name = Console.ReadLine();

            Console.Write("Enter your Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter your Phone Number: ");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());
        }
       
    }
}