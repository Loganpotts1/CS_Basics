using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(6, 7, 8);
            Console.WriteLine($"Volume is {box.Volume}");
            Console.WriteLine($"Front Area is {box.AreaFront}");
        }
    }
}
