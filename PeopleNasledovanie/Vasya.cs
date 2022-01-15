using System;

namespace PeopleNasledovanie
{
    public class Vasya:Men
    {
        
        public static void Work(string profession)
        {
            Console.WriteLine($"Vasya works {profession}.");
        }

        public static void HasACar(int number)
        {
            Console.WriteLine($"Vasya have {number} cars.");
        }
        

        public override void ColorEye(string color)
        {
            Console.WriteLine($"Vasya is eye color {color}.");
        }

        public override void Run(int meters)
        {
            Console.WriteLine($"Vasya runed {meters} meters.");
        }

        public override void Beard(bool yes)
        {
            if (true)
            {
                Console.WriteLine($"Vasya has a beard.");
            }
           
        }

        public override void Talk(string speech)
        {
            Console.WriteLine($"Hallo {speech}.");
              
        }

        public override void GiveReproduction(int nuber)
        {
            Console.WriteLine($"Vasya made {nuber} children.");
        }
    }
}
