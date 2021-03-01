using System;

namespace Challenge_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte bitey = 254;
            sbyte bitty = 115;
            short shorty = 30000;
            ushort unsignedShorty = 65000;
            int intty = 1000000000;
            uint unsigedIntty = 4000000000;
            long longy = 1000000000000;
            ulong unsignedLongy = 1;

            float floaty = 10.55467F;
            double doubly = 11.11567453;
            decimal deccy = 12.14784378378473843874M;

            bool booly = true;
            char charry = 'J';

            string stringy = "I control text";
            string stringyNum = "48";
            int intyNum = Int32.Parse(stringyNum);
            Console.WriteLine(intyNum);
        }
    }
}
