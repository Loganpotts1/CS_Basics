using System;

namespace Arrays_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] friends = new string[5];
            //string[1] = "Austin";

            //string[] friends = new string[] {...};

            string[] friends = { "Austin", "Matt", "Olivia", "Justin", "Devin" };

            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine($"{friends[i]} is not my friend!");
            }

            foreach (string j in friends)
            {
                Console.WriteLine($"I changed my mind, {j} and I are still friends :)");
            }
        }
    }
}
