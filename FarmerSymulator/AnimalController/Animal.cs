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
        }



    }


}
