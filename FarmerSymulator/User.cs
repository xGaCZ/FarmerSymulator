using FarmerSymulator.AnimalController;
using FarmerSymulator.FieldController;
using FarmerSymulator.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerSymulator
{
    class User 
    {
        public List<Animal> animals = new List<Animal>();
        public List<Field> fields = new List<Field>();
        public string name {  get; set; }
        public int cash {  get; set; }

        public void AddUser(string firstName, int startCash)
        {
            name = firstName;
            cash = startCash;
        }
      
        public void BuyAnimal()
        {
            BuyMenu.Menu();
            int select = int.Parse(Console.ReadLine());
            if(select == 1)
            { if(cash >= 50)
                { 
                var anim = new Animal(AnimalType.Rabbit, false, false);
                animals.Add(anim);
                    cash-= 50;

                Console.WriteLine($"Kupiles krolika, o nazwie {anim.name} \nAktulany budżet {cash}  ");
                }
            else { Console.WriteLine($"Brak środków zeby zakupić {AnimalType.Rabbit} "); }
            }
            else if (select == 2)
            {
                if (cash >= 20)
                {
                    var anim = new Animal(AnimalType.Chicken, false, true);
                    animals.Add(anim);
                    cash -= 20;
                    Console.WriteLine($"Kupiles krolika, o nazwie {anim.name} \nAktulany budżet {cash}  ");
                }
                else { Console.WriteLine($"Brak środków zeby zakupić {AnimalType.Chicken} "); }
            }
            else if (select == 3)
            {      if (cash >= 200)
                {
                    var anim = new Animal(AnimalType.Cow, true, false);
                    animals.Add(anim);
                    cash -= 200;
                    Console.WriteLine($"Kupiles krolika, o nazwie {anim.name} \nAktulany budżet {cash}  ");
                }

                else { Console.WriteLine($"Brak środków zeby zakupić {AnimalType.Cow} "); }
            }
            else if (select == 4)
            {
                if (cash >= 300)
                {
                    var anim = new Animal(AnimalType.Bull, false, false);
                    animals.Add(anim);
                    cash -= 300;
                    Console.WriteLine($"Kupiles krolika, o nazwie {anim.name} \nAktulany budżet {cash}  ");
                }
                else { Console.WriteLine($"Brak środków zeby zakupić {AnimalType.Bull} "); }
            }
            else if (select == 5)
            {
                if (cash >= 150)
                {
                    var anim = new Animal(AnimalType.Sheep, false, false);
                    animals.Add(anim);
                    cash -= 150;
                    Console.WriteLine($"Kupiles krolika, o nazwie {anim.name} \nAktulany budżet {cash}  ");
                }
                else { Console.WriteLine($"Brak środków zeby zakupić {AnimalType.Cow} "); }
            }


        }

    }
    
}
