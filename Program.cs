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
            4C. DAC/AMP's        4A. Exit Website           (Under construction)
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
                else if (userInputHomePage == "1A")
                    Account(variable);
                else if (userInputHomePage == "2A")
                    Cart(variable);
                else if (userInputHomePage == "3A")
                    Menu(variable);
                else
                {
                    Console.WriteLine("Invalid Input. Try again. \nRedirecting...");
                    HomePage(variable);
                }
            }
            Console.WriteLine("Thanks for visiting");
            Environment.Exit(0);
        }

        static void Account(Variables variable)
        {
            Console.Clear();
            Console.WriteLine("Username: " + name );
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone Number: " + phoneNumber);
            Console.Write("Password:");
            for (int i = 0; i < password.Length; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n1. Edit your username \n2. Edit your Email\n3. Edit your Phone Number\n4. Edit your Password\n5. Go back to homepage\nFunction:");
            string accountInput = Console.ReadLine();
            if (accountInput == "1")
            {
                Console.Write("Enter your new username: ");
                name = Console.ReadLine();
                Console.WriteLine("Username updated.");
                Console.ReadLine();
                Account(variable);
            }
            else if (accountInput == "2")
            {
                Console.Write("Please confirm your password to continue.\n Enter your password: ");
                string confirmPassword = Console.ReadLine();
                if (confirmPassword == password)
                {
                    Console.Write("Enter your new email");
                    email = Console.ReadLine();
                    Console.WriteLine("Email updated.");
                    Console.ReadLine();
                    Account(variable);
                }
                else
                {
                    Console.WriteLine("Invalid password.");
                    Console.ReadLine();
                    Account(variable);
                }
            }
            else if (accountInput == "3")
            {
                Console.Write("Please confirm your password to continue.\n Enter your password: ");
                string confirmPassword = Console.ReadLine();
                if (confirmPassword == password)
                {
                    Console.Write("Enter your new Phone number");
                    string phoneNumberConversion = Console.ReadLine();
                    bool numberConverted = int.TryParse(phoneNumberConversion, out phoneNumber);
                    if (numberConverted == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Input.");
                        Console.ReadLine();
                        Account(variable);
                    }
                    Console.WriteLine("Phone Number updated.");
                    Console.ReadLine();
                    Account(variable);
                }
                else
                {
                    Console.WriteLine("Invalid password.");
                    Console.ReadLine();
                    Account(variable);
                }
            }
            else if (accountInput == "4")
            {
                Console.Write("Please confirm your password to continue.\n Enter your password: ");
                string confirmPassword = Console.ReadLine();
                if (confirmPassword == password)
                {
                    Console.Write("Enter your new password");
                    password = Console.ReadLine();
                    Console.WriteLine("Password updated.");
                    Console.ReadLine();
                    Account(variable);
                }
                else
                {
                    Console.WriteLine("Invalid password.");
                    Console.ReadLine();
                    Account(variable);
                }
            }
            else if (accountInput == "5")
                HomePage(variable);
            else
            {
                Console.WriteLine("Invalid Input.");
                Console.ReadLine();
                Account(variable);
            }
        }
        
        
        
        
        
        
        
        
        
        public static void Cart(Variables variable) 
        {
            Console.Clear();
            Console.WriteLine("Cart:");
            Console.WriteLine("");

            if (variable.salnotesZero == variable.IEMs[0])
            {
                Console.WriteLine("Item: " + variable.IEMs[0] + " Quantity: " + variable.salnotesZeroStock);
            }
            if (variable.truthEarHola == variable.IEMs[1])
            {
                Console.WriteLine("Item: " + variable.IEMs[1] + " Quantity: " + variable.truthEarHolaStock);
            }
            if (variable.moondropChu == variable.IEMs[2])
            {
                Console.WriteLine("Item: " + variable.IEMs[2] + " Quantity: " + variable.moondropChuStock);
            }
            if (variable.tangzuWagner == variable.IEMs[3])
            {
                Console.WriteLine("Item: " + variable.IEMs[3] + " Quantity: " + variable.tangzuWagnerStock);
            }
            if (variable.truthearXCrinacle == variable.IEMs[4])
            {
                Console.WriteLine("Item: " + variable.IEMs[4] + " Quantity: " + variable.truthearXCrinacleStock);
            }
            if (variable.sennheiserHD599 == variable.Headphones[0])
            {
                Console.WriteLine("Item: " + variable.Headphones[0] + " Quantity: " + variable.sennheiserHD599Stock);
            }
            if (variable.tribitBTHXFreeGo == variable.Headphones[1])
            {
                Console.WriteLine("Item: " + variable.Headphones[1] + " Quantity: " + variable.tribitBTHXFreeGoStock);
            }
            if (variable.audioTechnicam40x == variable.Headphones[2])
            {
                Console.WriteLine("Item: " + variable.Headphones[2] + " Quantity: " + variable.audioTechnicam40xStock);
            }
            if (variable.sennheiserHD650 == variable.Headphones[3])
            {
                Console.WriteLine("Item: " + variable.Headphones[3] + " Quantity: " + variable.sennheiserHD650Stock);
            }
            if (variable.hifimanEditionXS == variable.Headphones[4])
            {
                Console.WriteLine("Item: " + variable.Headphones[4] + " Quantity: " + variable.hifimanEditionXSStock);
            }
            if (variable.ventureElectronicsAbigail == variable.DACs[0])
            {
                Console.WriteLine("Item: " + variable.DACs[0] + " Quantity: " + variable.ventureElectronicsAbigailStock);
            }
            if (variable.ventureElectronicsAvani == variable.DACs[1])
            {
                Console.WriteLine("Item: " + variable.DACs[1] + " Quantity: " + variable.ventureElectronicsAvaniStock);
            }
            if (variable.shanglingUA1Plus == variable.DACs[2])
            {
                Console.WriteLine("Item: " + variable.DACs[2] + " Quantity: " + variable.shanglingUA1PlusStock);
            }
            if (variable.FIIOKA3 == variable.DACs[3])
            {
                Console.WriteLine("Item: " + variable.DACs[3] + " Quantity: " + variable.FIIOKA3Stock);
            }
            if (variable.GoLink == variable.DACs[4])
            {
                Console.WriteLine("Item: " + variable.DACs[4] + " Quantity: " + variable.GoLinkStock);
            }
            if (variable.siliconTips == variable.EarTips[0])
            {
                Console.WriteLine("Item: " + variable.EarTips[0] + " Quantity: " + variable.siliconTipsStock);
            }
            if (variable.foamTips == variable.EarTips[1])
            {
                Console.WriteLine("Item: " + variable.EarTips[1] + " Quantity: " + variable.foamTipsStock);
            }
            if (variable.doubleFlangesSiliconTips == variable.EarTips[2])
            {
                Console.WriteLine("Item: " + variable.EarTips[2] + " Quantity: " + variable.doubleFlangesSiliconTipsStock);
            }
            if (variable.tripleFlangesSiliconTips == variable.EarTips[3])
            {
                Console.WriteLine("Item: " + variable.EarTips[3] + " Quantity: " + variable.tripleFlangesSiliconTipsStock);
            }
            if (variable.twotoneTips == variable.EarTips[4])
            {
                Console.WriteLine("Item: " + variable.EarTips[4] + " Quantity: " + variable.twotoneTipsStock);
            }
            CartProceed(variable);
        }
        static void CartProceed(Variables variable)
        {
            Console.WriteLine("\n1. Proceed with purchase\n2. Return to Homepage");
            string cartInput = Console.ReadLine();
            if (cartInput == "1") 
            {
             Console.Clear();
             Console.WriteLine("Proceeding...\nThanks for your purchase :D");
             Console.ReadLine();
             Environment.Exit(0);
            }
            else if (cartInput == "2")
            {
                HomePage(variable);
            }
            else
            {
                Console.WriteLine("Dummy.\nInvalid Input!");
                Console.ReadLine();
                CartProceed(variable);
            }
        }

        static void Eartip(Variables variable)
        {
            variable.EarTips = new string[] { "Silicon Tips", "Foam Tips", "Double Flange Silicon Tips", "Triple Flange Silicon Tips", "Two-Tone Tips", "Exit" };
            for (int i = 0; i < variable.EarTips.Length; i++)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + variable.EarTips[i]);
            }
            Console.Write("\nSelect your product: ");
            string productEartip = Console.ReadLine();

            int eartipStock = 0;

            if (productEartip == "1")
                eartipStock = 5;
            else if (productEartip == "2")
                eartipStock = 3;
            else if (productEartip == "3")
                eartipStock = 4;
            else if (productEartip == "4")
                eartipStock = 5;
            else if (productEartip == "5")    
                eartipStock = 6;
            else if (productEartip == "6")
                HomePage(variable);
            else
            {
                Console.WriteLine("Please select your product again");
                Console.ReadLine();
                Headphone(variable);
            }

            Console.WriteLine("Total Stock: " + Convert.ToString(eartipStock));
            Console.Write("\nSelect Your Quantity:");
            string eartipStockNeeded = Console.ReadLine();
            int eartipStockInt;
            bool stockConverted = int.TryParse(eartipStockNeeded, out eartipStockInt);
            
            



            while (stockConverted == true)
            {
                if (eartipStockInt <= 0)
                {
                    Console.WriteLine("Please enter a valid quantity and try again.");
                    Console.ReadLine();
                    Headphone(variable);
                }
                else if (Convert.ToUInt16(eartipStockNeeded) > Convert.ToUInt16(eartipStock))
                {
                    Console.WriteLine("Sorry, but we only have " + Convert.ToString(eartipStock) + " items in stocks.");
                    Console.ReadLine();
                    Headphone(variable);
                }
                else
                {
                    if (productEartip == "1")
                    {
                        variable.siliconTipsStock = Convert.ToString(eartipStockInt);
                        variable.siliconTips = variable.EarTips[0];
                    }
                    else if (productEartip == "2")
                    {
                        variable.foamTipsStock = Convert.ToString(eartipStockInt);
                        variable.foamTips = variable.EarTips[1];
                    }
                    else if (productEartip == "3")
                    {
                        variable.doubleFlangesSiliconTipsStock = Convert.ToString(eartipStockInt);
                        variable.doubleFlangesSiliconTips = variable.EarTips[2];
                    }
                    else if (productEartip == "4")
                    {
                        variable.tripleFlangesSiliconTipsStock = Convert.ToString(eartipStockInt);
                        variable.tripleFlangesSiliconTips = variable.EarTips[3];
                    }
                    else if (productEartip == "5")
                    {
                        variable.twotoneTipsStock = Convert.ToString(eartipStockInt);
                        variable.twotoneTips = variable.EarTips[4];
                    }

                    Console.WriteLine("Successfully added to Cart. Redirecting to Homepage...");
                    Console.ReadLine();
                    HomePage(variable);
                }
            }
            Console.WriteLine("Invalid Input. Please enter an integer.");
            Console.ReadLine();
            Headphone(variable);
        
        
        }

        public static void IEM(Variables variable)
        {
            Console.Clear();
            variable.IEMs = new string[] { "7hz Salnotes Zero", "TruthEar Hola", "Moondrop Chu", "Tangzu Wagner", "Truthear X Crinacle", "Return To Homepage" };
            for (int i = 0; i < variable.IEMs.Length; i++)
            {
                Console.WriteLine(Convert.ToString(i + 1) + ". " + variable.IEMs[i]);
            }
            Console.Write("\nSelect your product: ");
            string productIEM = Console.ReadLine();

            int IEMstock = 0;

            if (productIEM == "1")
                IEMstock = 5;
            else if (productIEM == "2")
                IEMstock = 3;
            else if (productIEM == "3")
                IEMstock = 4;
            else if (productIEM == "4")
                IEMstock = 5;
            else if (productIEM == "5")
                IEMstock = 6;
            else if (productIEM == "6")
                HomePage(variable);
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
                    if (productIEM == "1")
                    {
                        variable.salnotesZeroStock = IEMStockNeeded;
                        variable.salnotesZero = variable.IEMs[0];
                    }
                    else if (productIEM == "2")
                    {
                        variable.truthEarHolaStock = IEMStockNeeded;
                        variable.truthEarHola = variable.IEMs[1];
                    }
                    else if (productIEM == "3")
                    {
                        variable.moondropChuStock = IEMStockNeeded;
                        variable.moondropChu = variable.IEMs[2];
                    }
                    else if (productIEM == "4")
                    {
                        variable.tangzuWagnerStock = IEMStockNeeded;
                        variable.tangzuWagner = variable.IEMs[3];
                    }
                    else if (productIEM == "5")
                    {
                        variable.truthearXCrinacleStock = IEMStockNeeded;
                        variable.truthearXCrinacle = variable.IEMs[4];
                    }

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
            variable.DACs = new string[] { "Venture Electronics - Abigail", "Venture Electronics - Avani", "ShangLing - UA1 Plus", "FIIO - KA3", "IFI AUDIO - GO LINK", "Exit" };
            for (int i = 0; i < variable.DACs.Length; i++)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + variable.DACs[i]);
            }
            Console.Write("\nSelect your product: ");
            string productDAC = Console.ReadLine();

            int DACstock = 0;

            if (productDAC == "1")
                DACstock = 5;
            else if (productDAC == "2")
                DACstock = 3;
            else if (productDAC == "3")
                DACstock = 4;
            else if (productDAC == "4")
                DACstock = 5;
            else if (productDAC == "5")
                DACstock = 6;
            else if (productDAC == "6")
                HomePage(variable);
            else
            {
                Console.WriteLine("Please select your product again");
                Console.ReadLine();
                IEM(variable);
            }

            Console.WriteLine("Total Stock: " + Convert.ToString(DACstock));
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
                else if (Convert.ToUInt16(DACStockNeeded) > Convert.ToUInt16(DACstock))
                {
                    Console.WriteLine("Sorry, but we only have " + Convert.ToString(DACstock) + " items in stocks.");
                    Console.ReadLine();
                    DAC(variable);
                }
                else
                {
                    if (productDAC == "1")
                    {
                        variable.ventureElectronicsAbigailStock = DACStockNeeded;
                        variable.ventureElectronicsAbigail = variable.DACs[0];
                    }
                    else if (productDAC == "2")
                    {
                        variable.ventureElectronicsAvaniStock = DACStockNeeded;
                        variable.ventureElectronicsAvani = variable.DACs[1];
                    }
                    else if (productDAC == "3")
                    {
                        variable.shanglingUA1PlusStock = DACStockNeeded;
                        variable.shanglingUA1Plus = variable.DACs[2];
                    }
                    else if (productDAC == "4")
                    {
                        variable.FIIOKA3Stock = DACStockNeeded;
                        variable.FIIOKA3 = variable.DACs[3];
                    }
                    else if (productDAC == "5")
                    {
                        variable.GoLinkStock = DACStockNeeded;
                        variable.GoLink = variable.DACs[4];
                    }

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
            variable.Headphones = new string[] { "Sennheiser HD599", "Tribit BTH Xfree Go", "Audio Technica m40x", "Sennheiser HD650", "Hifiman - Edition XS", "Exit" };
            for (int i = 0; i < variable.Headphones.Length; i++)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + variable.Headphones[i]);
            }
            Console.Write("\nSelect your product: ");
            string productHeadphone = Console.ReadLine();

            int headphoneStock = 0;

            if (productHeadphone == "1")
                headphoneStock = 5;
            else if (productHeadphone == "2")
                headphoneStock = 3;
            else if (productHeadphone == "3")
                headphoneStock = 4; 
            else if (productHeadphone == "4")
                headphoneStock = 5;
            else if (productHeadphone == "5")
                headphoneStock = 6;
                
            else if (productHeadphone == "6")
                HomePage(variable);
            else
            {
                Console.WriteLine("Please select your product again");
                Console.ReadLine();
                Headphone(variable);
            }

            Console.WriteLine("Total Stock: " + Convert.ToString(headphoneStock));
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
                else if (Convert.ToUInt16(headphoneStockNeeded) > Convert.ToUInt16(headphoneStock))
                {
                    Console.WriteLine("Sorry, but we only have " + Convert.ToString(headphoneStock) + " items in stocks.");
                    Console.ReadLine();
                    Headphone(variable);
                }
                else
                {
                    if (productHeadphone == "1")
                    {
                        variable.sennheiserHD599Stock = headphoneStockNeeded;
                        variable.sennheiserHD599 = variable.Headphones[0];
                    }
                    else if (productHeadphone == "2")
                    {
                        variable.tribitBTHXFreeGoStock = headphoneStockNeeded;
                        variable.tribitBTHXFreeGo = variable.Headphones[1];
                    }
                    else if (productHeadphone == "3")
                    {
                        variable.audioTechnicam40xStock = headphoneStockNeeded;
                        variable.audioTechnicam40x = variable.Headphones[2];
                    }
                    else if (productHeadphone == "4")
                    {
                        variable.sennheiserHD650Stock = headphoneStockNeeded;
                        variable.sennheiserHD650 = variable.Headphones[3];
                    }
                    else if (productHeadphone == "5")
                    {
                        variable.hifimanEditionXSStock = headphoneStockNeeded;
                        variable.hifimanEditionXS = variable.Headphones[4];
                    }
                    

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
        public string siliconTips { get; set; }
        public string foamTips { get;set; }
        public string doubleFlangesSiliconTips { get; set; }
        public string tripleFlangesSiliconTips { get; set; }
        public string twotoneTips { get; set; }
        public string salnotesZeroStock { get; set; }
        public string truthEarHolaStock { get; set; }
        public string moondropChuStock { get; set; }
        public string tangzuWagnerStock { get; set; }
        public string truthearXCrinacleStock { get; set; }
    public string siliconTipsStock { get; set; }
    public string foamTipsStock { get; set; }
    public string doubleFlangesSiliconTipsStock { get; set; }
    public string tripleFlangesSiliconTipsStock { get; set; }
    public string twotoneTipsStock { get; set; }
    public string ventureElectronicsAbigailStock { get; set; }
    public string ventureElectronicsAvaniStock { get; set; }
    public string shanglingUA1PlusStock { get; set; }
    public string FIIOKA3Stock { get; set; }
    public string GoLinkStock { get; set; }
    public string sennheiserHD599Stock { get; set; }
    public string tribitBTHXFreeGoStock { get; set; }
    public string audioTechnicam40xStock { get; set; }
    public string hifimanEditionXSStock { get; set; }
    public string sennheiserHD650Stock { get; set; }
    public string sennheiserHD650 { get; set; }









    public string[] IEMs {  get; set; }
    public string[] DACs { get; set; }
    public string[] Headphones { get; set; }
    public string[] EarTips { get; set; }
    

}


