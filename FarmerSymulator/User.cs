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
       public List<Shop> shops = new List<Shop>();
        public string name {  get; set; }
        public int cash {  get; set; }
        public int smallFood { get; set; }
        public int mediumFood { get; set; }
        public int BigFood { get; set; }

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
            FieldSize[] animalTypes = (FieldSize[])Enum.GetValues(typeof(FieldSize));
            FieldSize selectedFieldType = animalTypes[selectField - 1];
            Field fie = new Field(selectedFieldType, nameFi);
            if (cash >= fie.fieldCost)
            {
                if (fields.FindAll(a => a.fieldNumber == nameFi).Count > 0)
                {
                    Console.WriteLine("takie zwierze już istanieje");
                    return;
                }
                cash -= fie.fieldCost;
                fields.Add(fie);
                Console.WriteLine($"Kupiles działkę w rozmiarze{fie.area}, o nazwie {fie.fieldNumber} \nAktulany budżet {cash}  ");
            }


        }
        public void BuyAnimal()
        {
       
            SystemMenu.MenuAnimal();
            int select = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj nazwe zwierzaka");
            string name = Console.ReadLine();


            AnimalType[] animalTypes = (AnimalType[])Enum.GetValues(typeof(AnimalType));
            AnimalType selectedType = animalTypes[select-1];

            Animal ani = new Animal(selectedType, name);
            if (cash >= ani.animalCost)
            {
                if (animals.FindAll(a => a.name == name).Count > 0)
                {
                    Console.WriteLine("takie zwierze już istanieje");
                    return;
                }
                cash -= ani.animalCost;
                animals.Add(ani);              
                Console.WriteLine($"Kupiles {ani.animalType}, o nazwie {ani.name} \nAktulany budżet {cash}  ");
            }

        }

    }

    
}
