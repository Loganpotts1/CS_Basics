using System;

namespace Challenge_If_Statements_2
{
    class Program
    {
        static string username;
        static string password;

        static int highScore;
        static string highScoreUser;

        static void Main(string[] args)
        {
            Register();
            Login();
            int score = Game();
            checkScore(score);
            Console.WriteLine("Press any key to exit");

        static void Register()
        {
            Console.WriteLine("Hi there! Sign up to continue");
            Console.WriteLine("Please enter a username:");
            username = Console.ReadLine();
            Console.WriteLine("Please enter a password");
            password = Console.ReadLine();
            Console.WriteLine("You're signed up! You can now log in");
            Console.WriteLine("-----------------------------------");
        }

        static void Login()
        {
            Console.WriteLine("Username:");
            string usernameInput = Console.ReadLine();
            Console.WriteLine("Password:");
            string passwordInput = Console.ReadLine();

            if (usernameInput == username && passwordInput == password)
            {
                Console.WriteLine("Awesome! You're now logged in");
            } else
            {
                Console.WriteLine("Oops, the username or password wasn't correct. Please try again");
                Login();
            }
        }

        static void checkScore(int score)
        {
            if (score > highScore)
            {
                highScore = score;
                highScoreUser = username;
                Console.WriteLine("CONGRAGULATIONS, YOU HOLD THE TOP SCORE!!!");
            }

            Console.WriteLine($"Top Score: {highScore}");
            Console.WriteLine($"User: {highScoreUser}");
        }

        static int Game()
        {
            string answer1 = "unset";
            int answer1Int;
            while (!int.TryParse(answer1, out answer1Int))
            {
                if (answer1 != "unset")
                {
                    Console.WriteLine("Oops, try typing in a number next time");
                }

                Console.WriteLine("What is 1 + 1?");
                answer1 = Console.ReadLine();
            }

            if (answer1Int == 2)
            {
                Console.WriteLine("You win! Good job!");
                return username.Length * 500;
            } else
            {
                Console.WriteLine("Sorry, better luck next time");
                return 0;
            }
        }
    }
}
