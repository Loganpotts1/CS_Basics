using System;

namespace Classes_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Human grant = new Human("Grant", "Meyers", 31, "hazel");
            grant.Greet();

            Human carla = new Human("Carla", "Brown");
            carla.Greet();
        }
    }
}
