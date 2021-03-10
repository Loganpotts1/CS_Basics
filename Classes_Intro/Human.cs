using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Intro
{
    class Human
    {
        private string firstName;
        private string lastName;
        private int age;
        private string eyeColor;

        //These extra constructors are just to show the possibility of multiple constructors. This would be useful if you needed to do something entirely different if the user entered a certain parameter
        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Human(string firstName, string lastName, int age, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }

        public void Greet()
        {
            Console.WriteLine($"Hi! My name is {firstName} {lastName}.{(age > 0 ? $" I am {age} years old." : null)}");
            if (eyeColor != null)
            {
                Console.WriteLine($"Also, my eye color is {eyeColor}!");
            }
        }
    }
}
