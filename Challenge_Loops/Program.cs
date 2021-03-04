using System;

namespace Challenge_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start entering scores between 0 and 20. When you are finished, type 'done' into the console");

            string res = Console.ReadLine();
            int count = 0;
            double sum = 0;

            while (res != "done")
            {
                double resToInt;
                bool isNum = double.TryParse(res, out resToInt);

                if (!isNum || resToInt > 20 || resToInt < 0)
                {
                    Console.WriteLine("Invalid entry, please try again");
                } else
                {
                    sum += resToInt;
                    count++;
                    Console.WriteLine("Score entered, type in another score or type 'done' to calculate the average");
                }
                
                res = Console.ReadLine();
            }
            
            if (sum == 0)
            {
                Console.WriteLine("The average of 0 is 0");
            } else
            {
                Console.WriteLine($"The average of the {count} scores is {sum / count}");
            }

            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
}
