using System;

namespace Challenge_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Challenge();
        }

        static void Challenge()
        {
            bool valid = false;

            while (valid != true)
            {
                Console.WriteLine("Give me an input:");
                string input = Console.ReadLine().Trim();

                Console.WriteLine("What type was that input?");
                Console.WriteLine("Enter 1 if it was a string");
                Console.WriteLine("Enter 2 if it was a number");
                Console.WriteLine("Enter 3 if it was a boolean");
                string dataType = Console.ReadLine().Trim();

                bool isNumber = int.TryParse(dataType, out int dataTypeToInt);

                if (!isNumber || dataTypeToInt > 3 || dataTypeToInt < 1)
                {
                    Console.WriteLine("Sorry, that wasn't a valid entry. Try again.");
                    continue;
                }

                switch (dataTypeToInt)
                {
                    case 1: 
                        {
                            bool boolMatch = bool.TryParse(input, out bool someBool);
                            bool intMatch = int.TryParse(input, out int someInt);

                            if (boolMatch || intMatch)
                            {
                                Console.WriteLine("Sorry, it looks like that isn't a string. Try again.");
                                continue;
                            } else
                            {
                                Console.WriteLine("Congrats! It's valid");
                                valid = true;
                            }

                            break;
                        }

                    case 2:
                        {
                            bool intMatch = int.TryParse(input, out int someInt);

                            if (!intMatch)
                            {
                                Console.WriteLine("Sorry, it looks like that isn't a number. Try again.");
                            } else
                            {
                                Console.WriteLine("Congrats! It's valid");
                                valid = true;
                            }

                            break;
                        }

                    case 3:
                        {
                            bool boolMatch = bool.TryParse(input, out bool someBool);

                            if (!boolMatch)
                            {
                                Console.WriteLine("Sorry, it looks like that isn't a boolean. Try again");
                            } else
                            {
                                Console.WriteLine("Congrats! It's valid");
                                valid = true;
                            }

                            break;
                        }
                }


            }
            
        }
    }
}
