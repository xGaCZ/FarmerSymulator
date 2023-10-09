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
        public void BuyField()
        {
            SystemMenu.MenuField();
            int selectField = int.Parse(Console.ReadLine());
            if(selectField == 1)
            {
                if(cash >= 500)
                {
                    var fi = new Field(FieldSize.small);
                    fields.Add(fi);
                    cash -= 500;
                    Console.WriteLine($"Kupiles ziemię, o numerze {fi.fieldNumber}\nDziałka ma rozmiar {fi.area}\nDziałka posiada Wode {fi.waterOnField} \nAktulany budżet {cash}  ");
                }
                else { Console.WriteLine($"Brak środków zeby zakupić ziemię "); }
            }
            else if (selectField == 2)
            {
                if (cash >=1000)
                {
                    var fi = new Field(FieldSize.medium);
                    fields.Add(fi);
                    cash -= 1000;
                    Console.WriteLine($"Kupiles ziemię, o numerze {fi.fieldNumber}\nDziałka ma rozmiar {fi.area}\nDziałka posiada Wode {fi.waterOnField} \nAktulany budżet {cash}  ");
                }
                else { Console.WriteLine($"Brak środków zeby zakupić ziemię "); }
            }
            else if (selectField == 3)
            {
                if (cash >= 1500)
                {
                    var fi = new Field(FieldSize.large);
                    fields.Add(fi);
                    cash -= 1500;
                    Console.WriteLine($"Kupiles ziemię, o numerze {fi.fieldNumber}\nDziałka ma rozmiar {fi.area}\nDziałka posiada Wode {fi.waterOnField} \nAktulany budżet {cash}  ");
                }
                else { Console.WriteLine($"Brak środków zeby zakupić ziemię "); }
            }
            else if (selectField == 4)
            {
                if (cash >= 2200)
                {
                    var fi = new Field(FieldSize.extraLarge);
                    fields.Add(fi);
                    cash -= 2200;
                    Console.WriteLine($"Kupiles ziemię, o numerze {fi.fieldNumber}\nDziałka ma rozmiar {fi.area}\nDziałka posiada Wode {fi.waterOnField} \nAktulany budżet {cash}  ");
                }
                else { Console.WriteLine($"Brak środków zeby zakupić ziemię "); }
            }
        }
      
        public void BuyAnimal()
        {
            SystemMenu.MenuAnimal();
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
                    Console.WriteLine($"Kupiles kure, o nazwie {anim.name} \nAktulany budżet {cash}  ");
                }
                else { Console.WriteLine($"Brak środków zeby zakupić {AnimalType.Chicken} "); }
            }
            else if (select == 3)
            {      if (cash >= 200)
                {
                    var anim = new Animal(AnimalType.Cow, true, false);
                    animals.Add(anim);
                    cash -= 200;
                    Console.WriteLine($"Kupiles krowe, o nazwie {anim.name} \nAktulany budżet {cash}  ");
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
                    Console.WriteLine($"Kupiles byka, o nazwie {anim.name} \nAktulany budżet {cash}  ");
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
                    Console.WriteLine($"Kupiles owce, o nazwie {anim.name} \nAktulany budżet {cash}  ");
                }
                else { Console.WriteLine($"Brak środków zeby zakupić {AnimalType.Cow} "); }
            }


        }

    }

    
}
