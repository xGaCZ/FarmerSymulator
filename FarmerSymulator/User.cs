using FarmerSymulator.AnimalController;
using FarmerSymulator.FieldController;
using FarmerSymulator.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            Console.WriteLine("Podaj nazwe zwierzaka");
            string name = Console.ReadLine();


            foreach (AnimalType animalType in Enum.GetValues(typeof(AnimalType)))
            {
                
                if (select ==(int)animalType)
                {
                    bool isEgg = ((int)animalType == 2);
                    bool isMilk = ((int)animalType == 3);
                    var b = new Animal(animalType,isMilk , isEgg, name);
                    if (animals.FindAll(a => a.name == name).Count > 0)
                    {
                        Console.WriteLine("takie zwierze już istanieje");
                        return;
                    }
                    else
                    {
                        animals.Add(b);                  
                        Console.WriteLine($"Kupiles {b.animalType}, o nazwie {b.name} \nAktulany budżet {cash}  ");
                    }
                }
            }

           

            
        }

    }

    
}
