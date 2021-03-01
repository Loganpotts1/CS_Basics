using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Logan";

            string nameLower = name.ToLower();

            Console.WriteLine("Hey there! My name is " + nameLower);
            Console.Read();
        }
    }
}
