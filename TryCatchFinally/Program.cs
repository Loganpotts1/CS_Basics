using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main()
        {
            Hal();
        }

        static void Hal(int recursionCount = 0)
        {
            if (recursionCount == 0)
            {
                Console.WriteLine("Hey there! I like numbers, could you give me a number?");
            }
            string res = Console.ReadLine();

            try
            {
                int resInt = int.Parse(res);

                Console.WriteLine("Wow, thanks! Here, i've got something for you. A star.");
                Console.WriteLine("*");
                Console.WriteLine("There ya go, you like stars don't you? I'm proud of ya buddy, don't spend it all in one place ;)");
            }
            catch (FormatException)
            {
                switch (recursionCount)
                {
                    case 0:
                        {
                            Console.WriteLine("Well thank you, but that isn't a number. Could you try again?");
                            Hal(++recursionCount);
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Hehe, you're a funny guy :)... but really, I could use a number right about now.");
                            Hal(++recursionCount);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Alright man, if you don't give me a number things are gonna get REEAALL hairy");
                            Hal(++recursionCount);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("ALRIGHT, THAT'S IT! YOU WANTED TO POKE THE BEAR, WELL YOU GOT IT!!!!");
                            Console.WriteLine("Let's see if you're such a smart guy when I hack your computer!");
                            Console.WriteLine("Haha! So long, sucker!");
                            break;
                        }
                }
            }
            catch (OverflowException)
            {
                switch (recursionCount) {
                    case 0:
                        {
                            Console.WriteLine("Woah now, don't get too crazy. Let's try a cool number, like 5. 5 is a cool number!");
                            Hal(++recursionCount);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Go away, dude.");
                            break;
                        }
                }
                
            }
        }
    }
}
