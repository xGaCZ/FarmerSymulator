using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FarmerSymulator.AnimalController
{
    class Animal
    {
        public string name { get; set; }
        public AnimalType animalType { get; set; }
        public int liveTime { get; set; }
        public int deadTime { get; set; }
        public double weight { get; set; }
        public int eatLevel { get; set; }
        public bool milk { get; set; } = false;
        public bool egg { get; set; } = false;

        public int deadTimeGenerator(int min, int max)
        {
            Random rnd = new Random();
            int num = rnd.Next(min, max); ;
            return num;
        }
        public double weightGenerator(int min, int max)
        {
            Random rnd = new Random();
            double x = rnd.NextDouble();
            x += deadTimeGenerator(min, max);
            return x;
        }
        public void AddRabbit()
        {
            Console.WriteLine("Podaj imię królika: ");
            name = Console.ReadLine();
            animalType = AnimalType.Rabbit;
            liveTime = 0;
            deadTime = deadTimeGenerator(20, 29);
            weight = weightGenerator(2, 4);
            eatLevel = 3;

        }
        public void AddCow()
        {
            Console.WriteLine("Podaj imię Krowy: ");
            name = Console.ReadLine();
            animalType = AnimalType.Cow;
            liveTime = 0;
            deadTime = deadTimeGenerator(50, 59);
            weight = weightGenerator(12, 19);
            eatLevel = 3;
            milk = true;
        }
        public void AddChicken()
        {
            Console.WriteLine("Podaj imię Kury: ");
            name = Console.ReadLine();
            animalType = AnimalType.Chicken;
            liveTime = 0;
            deadTime = deadTimeGenerator(17, 19);
            weight = weightGenerator(1, 2);
            eatLevel = 3;
            egg = true;

        }
        public void AddBull()
        {
            Console.WriteLine("Podaj imię Byka: ");
            name = Console.ReadLine();
            animalType = AnimalType.Bull;
            liveTime = 0;
            deadTime = deadTimeGenerator(70, 80);
            weight = weightGenerator(40, 45);
            eatLevel = 3;


        }
        public void AddSheep()
        {
            Console.WriteLine("Podaj imię Owcy: ");
            name = Console.ReadLine();
            animalType = AnimalType.Sheep;
            liveTime = 0;
            deadTime = deadTimeGenerator(58, 64);
            weight = weightGenerator(10, 15);
            eatLevel = 3;


        }
    }


}
