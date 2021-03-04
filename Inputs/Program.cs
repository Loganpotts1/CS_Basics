using System;

namespace Inputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I multiply things! I will take two numbers from you and multiply them");
            Console.WriteLine("Could you give me the first number?");
            string num1 = Console.ReadLine();
            Console.WriteLine("And the second?");
            string num2 = Console.ReadLine();
            Console.WriteLine("Awesome, gimme some time to quantify the results...");
            Console.WriteLine("Beep!");
            Console.WriteLine("Blurp");
            Console.WriteLine($"The product of {num1} and {num2} is {double.Parse(num1) * double.Parse(num2)}");
        }
    }
}
