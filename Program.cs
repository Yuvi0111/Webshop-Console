using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection.Metadata;

namespace Webshop_Console
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Variables variable = new Variables();
            Menu(variable);
        }
        static void Menu(Variables variable)
        {
            Console.Clear();
            Console.WriteLine("--------- \nLogin Screen \n---------");

            Console.WriteLine("1. Sign up \n2. Sign in \n3. Exit");
            Console.WriteLine("Note: Enter the number to choose" +
                " your function throughout the program");
            Console.Write("Choose your function: ");
            string loginInput = Console.ReadLine();

            while (loginInput != "3")
            {
                if (loginInput == "1")
                    SignUpScreen(variable);
                else if (loginInput == "2")
                    SignInScreen(variable);
                else
                {
                    Console.WriteLine("Invalid Input. Try again. Redirecting...");
                    Console.ReadLine();
                    Menu(variable);
                }
            }
        }

        static void SignInScreen(Variables variable)
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
                HomePage(variable);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Creditentials, please try again.");
                Console.ReadLine();
                Menu(variable);
            }

        }

        static void SignUpScreen(Variables variable)
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
            string phoneNumberConversion = Console.ReadLine();
            int phoneNumber;
            bool numberConverted = int.TryParse(phoneNumberConversion, out phoneNumber);
            if (numberConverted == false)
            {
                Console.Clear();
                Console.WriteLine("Invalid Input. Redirecting back to Menu...");
                Console.ReadLine();
                Menu(variable);
            }

            Console.WriteLine("Registered Successfully. Redirecting...");
            Console.ReadLine();
            Menu(variable);
        }

        static void HomePage(Variables variable)
        {
            Console.Clear();
            Console.WriteLine("""
            ----------Audio WebStore--------  
            ------HomePage------
              
            --Categories--       --Account--                --Help Centre--   
            1C. Headphones       1A. Account Details        1H. Write a Support Ticket 
            2C. IEM's            2A. Cart                   2H. Frequently Asked Questions
            3C. Eartips          3A. Sign Out               3H. Deliver Partners    
            4C. DAC/AMP's        4A. Exit Website
            """);
            Console.WriteLine("");
            Console.Write("User Input: ");
            string userInputHomePage = Console.ReadLine();

            while (userInputHomePage != "4A")
            {
                if (userInputHomePage == "1C")
                    Headphone(variable);
                else if (userInputHomePage == "2C")
                    IEM(variable);
                else if (userInputHomePage == "3C")
                    Eartip(variable);
                else if (userInputHomePage == "4C")
                    DAC(variable);
                else
                {
                    Console.WriteLine("Invalid Input. Try again. \nRedirecting...");
                    HomePage(variable);
                }
            }
            Console.WriteLine("Thanks for visiting");
            Environment.Exit(0);
        }

        public static void IEM(Variables variable)
        {
            Console.Clear();
            string[] IEMs = new string[] { "7hz Salnotes Zero", "TruthEar Hola", "Moondrop Chu", "Tangzu Wagner", "Truthear X Crinacle", "Return To Homepage" };
            for (int i = 1; i < IEMs.Length; i++)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + IEMs[i]);
            }
            Console.Write("\nSelect your product: ");
            string productIEM = Console.ReadLine();

            int IEMstock = 0;

            if (productIEM == "1")
            {
                IEMstock = 5;
                variable.salnotesZero = IEMs[0];
            }
            else if (productIEM == "2")
            {
                IEMstock = 3;
                variable.truthEarHola = IEMs[1];
            }
            else if (productIEM == "3")
            {
                IEMstock = 4;
                variable.moondropChu = IEMs[2];
            }
            else if (productIEM == "4")
            {
                IEMstock = 5;
                variable.tangzuWagner = IEMs[3];
            }
            else if (productIEM == "5")
            {
                IEMstock = 6;
                variable.truthearXCrinacle = IEMs[4];
            }
            else if (productIEM == "6")
            {
                HomePage(variable);
            }
            else
            {
                Console.WriteLine("Please select your product again");
                Console.ReadLine();
                IEM(variable);
            }

            Console.WriteLine("Total Stock: " + Convert.ToString(IEMstock));
            Console.Write("\nSelect Your Quantity:");
            string IEMStockNeeded = Console.ReadLine();
            int IEMStockInt;
            bool stockConverted = int.TryParse(IEMStockNeeded, out IEMStockInt);
            while (stockConverted == true)
            {
                if (IEMStockInt <= 0)
                {
                    Console.WriteLine("Please enter a valid quantity and try again.");
                    Console.ReadLine();
                    IEM(variable);
                }
                else if (Convert.ToUInt16(IEMStockNeeded) > Convert.ToUInt16(IEMstock))
                {
                    Console.WriteLine("Sorry, but we only have " + Convert.ToString(IEMstock) + " items in stocks.");
                    Console.ReadLine();
                    IEM(variable);
                }
                else
                {
                    Console.WriteLine("Successfully added to Cart. Redirecting to Homepage...");
                    Console.ReadLine();
                    HomePage(variable);
                }
            }
            Console.WriteLine("Invalid Input. Please enter an integer.");
            Console.ReadLine();
            IEM(variable);


        }
        static void DAC(Variables variable)
        {
            string[] DACs = { "Venture Electronics - Abigail", "Venture Electronics - Avani", "ShangLing - UA1 Plus", "FIIO - KA3", "IFI AUDIO - GO LINK", "Exit" };
            for (int i = 0; i < DACs.Length; i++)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + DACs[i]);
            }
            Console.Write("\nSelect your product: ");
            string productDAC = Console.ReadLine();

            int IEMstock = 0;

            if (productDAC == "1")
            {
                IEMstock = 5;
                variable.ventureElectronicsAbigail = DACs[0];
            }
            else if (productDAC == "2")
            {
                IEMstock = 3;
                variable.ventureElectronicsAvani = DACs[1];
            }
            else if (productDAC == "3")
            {
                IEMstock = 4;
                variable.shanglingUA1Plus = DACs[2];
            }
            else if (productDAC == "4")
            {
                IEMstock = 5;
                variable.FIIOKA3 = DACs[3];
            }
            else if (productDAC == "5")
            {
                IEMstock = 6;
                variable.GoLink = DACs[4];
            }
            else if (productDAC == "6")
            {
                HomePage(variable);
            }
            else
            {
                Console.WriteLine("Please select your product again");
                Console.ReadLine();
                IEM(variable);
            }

            Console.WriteLine("Total Stock: " + Convert.ToString(IEMstock));
            Console.Write("\nSelect Your Quantity:");
            string DACStockNeeded = Console.ReadLine();
            int DACStockInt;
            bool stockConverted = int.TryParse(DACStockNeeded, out DACStockInt);
            while (stockConverted == true)
            {
                if (DACStockInt <= 0)
                {
                    Console.WriteLine("Please enter a valid quantity and try again.");
                    Console.ReadLine();
                    DAC(variable);
                }
                else if (Convert.ToUInt16(DACStockNeeded) > Convert.ToUInt16(IEMstock))
                {
                    Console.WriteLine("Sorry, but we only have " + Convert.ToString(IEMstock) + " items in stocks.");
                    Console.ReadLine();
                    DAC(variable);
                }
                else
                {
                    Console.WriteLine("Successfully added to Cart. Redirecting to Homepage...");
                    Console.ReadLine();
                    HomePage(variable);
                }
            }
            Console.WriteLine("Invalid Input. Please enter an integer.");
            Console.ReadLine();
            DAC(variable);
        }
        static void Headphone(Variables variable)
        {
            string[] Headphones = { "Sennheiser HD599", "Tribit BTH Xfree Go", "Audio Technica m40x", "Sennheiser HD650", "Hifiman - Edition XS", "Exit" };
            for (int i = 0; i < Headphones.Length; i++)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + Headphones[i]);
            }
            Console.Write("\nSelect your product: ");
            string productHeadphone = Console.ReadLine();

            int IEMstock = 0;

            if (productHeadphone == "1")
            {
                IEMstock = 5;
                variable.sennheiserHD599 = Headphones[0];
            }
            else if (productHeadphone == "2")
            {
                IEMstock = 3;
                variable.tribitBTHXFreeGo = Headphones[1];
            }
            else if (productHeadphone == "3")
            {
                IEMstock = 4;
                variable.audioTechnicam40x = Headphones[2];
            }
            else if (productHeadphone == "4")
            {
                IEMstock = 5;
                variable.hifimanEditionXS = Headphones[3];
            }
            else if (productHeadphone == "5")
            {
                IEMstock = 6;
                variable.GoLink = Headphones[4];
            }
            else if (productHeadphone == "6")
            {
                HomePage(variable);
            }
            else
            {
                Console.WriteLine("Please select your product again");
                Console.ReadLine();
                Headphone(variable);
            }

            Console.WriteLine("Total Stock: " + Convert.ToString(IEMstock));
            Console.Write("\nSelect Your Quantity:");
            string headphoneStockNeeded = Console.ReadLine();
            int headphoneStockInt;
            bool stockConverted = int.TryParse(headphoneStockNeeded, out headphoneStockInt);
            while (stockConverted == true)
            {
                if (headphoneStockInt <= 0)
                {
                    Console.WriteLine("Please enter a valid quantity and try again.");
                    Console.ReadLine();
                    Headphone(variable);
                }
                else if (Convert.ToUInt16(headphoneStockNeeded) > Convert.ToUInt16(IEMstock))
                {
                    Console.WriteLine("Sorry, but we only have " + Convert.ToString(IEMstock) + " items in stocks.");
                    Console.ReadLine();
                    Headphone(variable);
                }
                else
                {
                    Console.WriteLine("Successfully added to Cart. Redirecting to Homepage...");
                    Console.ReadLine();
                    HomePage(variable);
                }
            }
            Console.WriteLine("Invalid Input. Please enter an integer.");
            Console.ReadLine();
            Headphone(variable);
        }


        public static string name, password, email;
        public static int phoneNumber;
        static void Eartip(Variables variable)
        {
            string[] EarTips = { "Silicon Tips", "Foam Tips", "Double Flange Silicon Eartips", "Triple Flange Silicon Eartips", "Two-Tone Eartips", "Exit" };
            for (int i = 0; i < EarTips.Length; i++)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + EarTips[i]);
            }
            Console.Write("\nSelect your product: ");
            Console.ReadLine();
        }
    }
}
    class Variables 
    {
            public string salnotesZero {  get; set; }
            public string truthEarHola { get; set; }
            public string moondropChu { get; set; }
            public string tangzuWagner { get; set; }
            public string truthearXCrinacle { get; set; }
        public string ventureElectronicsAbigail { get; set; }
        public string ventureElectronicsAvani { get; set; }
        public string shanglingUA1Plus { get; set; }
        public string FIIOKA3 { get; set; }
        public string GoLink { get; set; }
        public string sennheiserHD599 { get; set; }
        public string tribitBTHXFreeGo { get; set; }
        public string audioTechnicam40x { get; set;}
        public string hifimanEditionXS { get; set;}
        public string Tangu2 { get; set; }
        public string Tangu3 { get;set; }
        public string Tangu4 { get; set; }
        public string Tangu5 { get; set; }
        public string Tangu6 { get; set; }
        public string Tangu7 { get; set; }
        public string Tangu8 { get; set; }


    }

