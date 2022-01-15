using System;
namespace PeopleNasledovanie
{
    public class Petya:Men
    {

        public static void Collector(int numberAntiques)
        {
            Console.WriteLine($"Petya has {numberAntiques} antiques.");
        }

        public static void Swims(int meters)
        {
            Console.WriteLine($"Petya swims at speed of {meters} meters per minute. ");
        }


        public override void Talk(string someSpeech)
        {
            Console.WriteLine($"Petya said that {someSpeech}.");
        }

        public override void Run(int meters)
        {

            Console.WriteLine($"Petya runed {meters}.");
           
        }

        public override void GiveReproduction(int nuber)
        {
            Console.WriteLine($"Petya made {nuber} children.");
        }

        public override void ColorEye(string color)
        {
            Console.WriteLine($"Petya is eye color {color}.");
        }

        public override void Beard(bool yes)
        {
            if(true)
            {
                Console.WriteLine($"Petya has a beard");
            }
            
        }
    }
}
