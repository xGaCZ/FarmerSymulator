﻿using System;
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
        Random random = new Random();
        public string name { get; set; }
        public AnimalType animalType { get; set; }
        public int liveTime { get; set; } = 0;
        public int deadTime { get; set; }
        public double weight { get; set; }
        public int eatLevel { get; set; } = 3;
        public bool milk { get; set; }
        public bool egg { get; set; } 
        public Animal(AnimalType animalType, bool milk, bool egg)
        {
            this.animalType = animalType;
            this.milk = milk;
            this.egg = egg;
            Create();
            
        }
        public void Create()
        {
            Console.WriteLine($"Podaj nazwe zwierzaka: ");
            name = Console.ReadLine();
            if (animalType == AnimalType.Rabbit)
            {
               deadTime = random.Next(20,25);
               weight = random.Next(2,4);
            }
            else if (animalType == AnimalType.Cow)
            {
                deadTime = random.Next(70, 75);
                weight = random.Next(10, 15);
                milk = true;
            }
            else if (animalType == AnimalType.Chicken)
            {
                deadTime = random.Next(30, 33);
                weight = random.Next(1, 3);
                egg = true;
            }
            else if (animalType == AnimalType.Sheep)
            {
                deadTime = random.Next(50, 51);
                weight = random.Next(5, 8);
            }
            else if (animalType == AnimalType.Bull)
            {
                deadTime = random.Next(100, 125);
                weight = random.Next(20, 40);
            }
        }



    }


}
