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
                    Placeholder
              else 


            }
        }
        static void SignInScreen()
        {
            Object User1 = new Object();
            Console.WriteLine("--------- \n Sign in Menu \n ---------");
            Console.WriteLine("");

            Console.Write("Enter your Username: ");
            string SignInName = Console.ReadLine();

            Console.Write("Enter your Password: ");
            string SignInPass = Console.ReadLine();

            if (SignInName==User1.Name && SignInPass==User1.Password)
            {
                Console.WriteLine("")
            }


        }

        static void SignUpScreen()
        {
            Object User1 = new Object();
            Console.WriteLine("--------- \n Sign Up Menu \n ---------");
            Console.WriteLine("");
            
            Console.Write("Enter your Email: ");
            User1.Email = Console.ReadLine();

            Console.Write("Enter your Username: ");
            User1.Name = Console.ReadLine();

            Console.Write("Enter your Password: ");
            User1.Password = Console.ReadLine();

            Console.WriteLine("Enter your Phone Number: ");
            User1.phoneNumber = Convert.ToInt32(Console.ReadLine());
        }
       
    }

   public class Object
   {
      public String Email, Name, Password;
     public int phoneNumber;
        
   }
}