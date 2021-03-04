using System;

namespace Challenge_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetFriend(new string[] { "Austin", "Matt", "Olivia"});
        }

        static void GreetFriend(string[] names)
        {
            foreach (string name in names) {
                Console.WriteLine($"Hello friend {name}!");
            }
            
        }
    }
}
