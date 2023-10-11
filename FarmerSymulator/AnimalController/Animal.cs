using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int animalCost { get; set; }
        public AnimalType animalType { get; set; }
        public int liveTime { get; set; } = 0;
        public int deadTime { get; set; }
        public int weight { get; set; }
        public int eatLevel { get; set; } = 3;
        public bool milk { get; set; }
        public bool egg { get; set; } 
        public int meetCost { get; set; }
        public Animal(AnimalType animalType, bool milk, bool egg,string name)
        {
            this.animalType = animalType;
            this.milk = milk;
            this.egg = egg;
            this.name = name;


            Create();
            
        }
        public void Create()
        {

            
            if (animalType == AnimalType.Rabbit)
            {
               deadTime = random.Next(20,25);
               weight = random.Next(2,4);
                animalCost= 50;
                meetCost = 20;
            }
            else if (animalType == AnimalType.Cow)
            {
                deadTime = random.Next(70, 75);
                weight = random.Next(10, 15);
                animalCost = 50;
                milk = true;
            }
            else if (animalType == AnimalType.Chicken)
            {
                deadTime = random.Next(30, 33);
                weight = random.Next(1, 3);
                animalCost = 50;
                egg = true;
            }
            else if (animalType == AnimalType.Sheep)
            {
                deadTime = random.Next(50, 51);
                weight = random.Next(5, 8);
               animalCost = 50;
                meetCost = 10;
            }
            else if (animalType == AnimalType.Bull)
            {
                deadTime = random.Next(100, 125);
                weight = random.Next(20, 40);
                animalCost = 50;
                meetCost = 5;
            }
        }



    }


}
