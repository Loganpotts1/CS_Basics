using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(5, 15));
            Console.WriteLine(Divide(56, 3));
            Console.Read();
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        //It's important to convert other number types to the same type when using them, otherwise calculations may be skewed ex: SomeMethod(double num1, double num2) INSTEAD OF SomeMethod(int num1, int num2)
        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
