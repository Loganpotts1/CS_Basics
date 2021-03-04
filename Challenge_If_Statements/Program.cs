using System;

namespace Challenge_If_Statements
{
    class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            LogIn();
        }

        static void Register()
        {
            Console.WriteLine("Welcome, please create an account");
            Console.WriteLine("username:");
            username = Console.ReadLine();
            Console.WriteLine("password:");
            password = Console.ReadLine();

            Console.WriteLine("Amazing! You're all set up to log in");
        }

        static void LogIn()
        {
            Console.WriteLine("Welcome, please log in");
            Console.WriteLine("username:");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("password:");
            string inputPassword = Console.ReadLine();

            if (inputUsername == username && inputPassword == password)
            {
                Console.WriteLine("Congrats! You're logged in :)");
            }
            else
            {
                Console.WriteLine("Oops! Wrong username or password, try again");
                LogIn();
            }
        }
    }
}
