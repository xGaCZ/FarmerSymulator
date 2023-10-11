using FarmerSymulator.AnimalController;
using FarmerSymulator.FieldController;
using FarmerSymulator.Menu;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            Console.WriteLine($"Podaj numer Pola(przykład:Małe41): ");
            string nameFi = Console.ReadLine();
            foreach (FieldSize fieldSize in Enum.GetValues(typeof(FieldSize)))
            {
                if (selectField == (int)fieldSize)
                {
                    var fi = new Field(fieldSize, nameFi);
                    if (fields.FindAll(a=>a.fieldNumber==nameFi).Count > 0)
                    {
                        Console.WriteLine("Inna działka ma taką nazwe");
                        return;
                    }
                    else
                    {
                        fields.Add(fi);
                        Console.WriteLine($"Kupiles działkę o powierzchni: {fi.area}, klasa ziemi {fi.fieldClass}, przyłaczenie do wody{fi.waterOnField}\nAktulany budżet {cash}  ");
                    }
                }
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
