using System;

namespace Constants
{
    class Program
    {
        //Constants as fields
        //Typically you want to put global constants outside of any methods, that way you can access them anywhere
        //Also, in C#, the naming convention for constants is PascalCasing
        const double Pi = 3.14159265359;
        const byte Weeks = 52, months = 12;
        const string Birthday = "May 19, 1999";
        static void Main(string[] args)
        {
            Console.WriteLine($"My birthday is {Birthday}!");
        }
    }
}
