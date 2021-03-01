using System;

namespace Excersize_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string here:");
            string resString = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the character to search for:");
            string resChar = Console.ReadLine().ToLower();
            Console.WriteLine("The first occurence of " + resChar + " is " + resString.IndexOf(resChar));

            Console.WriteLine("What's your first name?");
            string resFName = Console.ReadLine();
            Console.WriteLine("And your last?");
            string resLName = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + resFName + " " + resLName + "!");
        }
    }
}
