using System;
namespace PeopleNasledovanie
{
    public class Masha:Women
    {
        public static void Hobby(string view)
        {
            Console.WriteLine($"Masha is hobby {view}.");
        }
        
        public static void Animals(string animal)
        {
            Console.WriteLine($"Masha has {animal}.");
        }

        public override void ColorEye(string color)
        {
            Console.WriteLine($"Masha is eye color{color}");
        }

        public override void GiveChild(int number)
        {
            Console.WriteLine($"Masha has children{number}");
        }

        public override void Pregnancy(int numberOfTimes)
        {
            Console.WriteLine($"Masha was pregnant{numberOfTimes}");
        }

        public override void Run(int meters)
        {
            Console.WriteLine($"petya runed{meters}");           
        }

        public override void Talk(string speech)
        {
            Console.WriteLine("I have" + speech);
        }
    }
}
