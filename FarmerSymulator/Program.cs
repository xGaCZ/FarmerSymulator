
using FarmerSymulator;
using FarmerSymulator.AnimalController;
using FarmerSymulator.FieldController;
using FarmerSymulator.Menu;
using System.Runtime.CompilerServices;

User player  = new User();
bool exit = false;
int egg = 0;
int milk = 0;
Console.WriteLine("Podaj Nazwę gracza: ");
string firstName=Console.ReadLine();
player.AddUser(firstName, 11100);
do
{

    SystemMenu.MainMenu();
    int x = int.Parse(Console.ReadLine());

    switch (x)
    {

        case 1:
            player.BuyAnimal();
            break;
        case 2:
            player.BuyField();
            break;
        case 3:
            foreach(Animal animal in player.animals)
            { Console.WriteLine($"Gatunek zwierzęcia:{animal.animalType} Nazwa:{animal.name} Waga: {animal.weight} Poziom głodu:{animal.eatLevel} Zgon za: {animal.deadTime-animal.liveTime}"); }
            break;
            case 4:
            foreach(Field field in player.fields)
            {
                Console.WriteLine($"Rozmiar Pola:{field.area} Nazwa pola: {field.fieldNumber} Gatunek ziemi:{field.fieldClass} Podłącznie do wody:{field.waterOnField}");
            }
            break;
            case 5:
            SystemMenu.ButcherMenu();
            int x1 = int.Parse(Console.ReadLine());
            if (x1==1)
            {
                foreach(Animal animal in player.animals)
                {
                    if (animal.animalType == AnimalType.Bull)
                    {
                        Console.WriteLine($"Nazwa byka:{animal.name} Waga{animal.weight} Wartość byka{animal.weight*5}PLN");
                    }
                }
                
            }
            else if (x1 == 2)
            {
                foreach (Animal animal in player.animals)
                {
                    if (animal.animalType == AnimalType.Rabbit)
                    {
                        Console.WriteLine($"Nazwa królika:{animal.name} Waga{animal.weight} Wartość królika{animal.weight * 20}PLN");
                    }
                }

            }
            else if (x1 == 3)
            {
                foreach (Animal animal in player.animals)
                {
                    if (animal.animalType == AnimalType.Sheep)
                    {
                        Console.WriteLine($"Nazwa Owcy:{animal.name} Waga{animal.weight} Wartość Owcy{animal.weight * 10}PLN");
                    }
                }

            }
            Console.WriteLine("Podaj nazwę zwierzęcia którego chcesz sprzedać: ");
            string nameSellAnimal=Console.ReadLine();
            foreach (Animal type in player.animals.ToList())
            {

                if (nameSellAnimal == type.name)
                {
                    player.cash = player.cash + (type.weight*type.meetCost);
                    player.animals.Remove(type);
                }
                else { break; }
            }
            break;
     
            case 7:
            
            foreach (Animal type in player.animals)
                { 
                    if(type.animalType == AnimalType.Chicken && type.eatLevel >=3)
                    {
                        egg++;
                    }
                }
                foreach (Animal type in player.animals)
                {
                    if (type.animalType == AnimalType.Cow && type.eatLevel >= 3)
                    {
                        milk++;
                    }
                }
            foreach (Animal type in player.animals)
            {
                type.eatLevel--;
                type.liveTime ++;
            }

            foreach (Animal type in player.animals.ToList())
                {

                    if (type.eatLevel == 0 || type.deadTime == type.liveTime)
                    {
                        player.animals.Remove(type);
                    }
                }

            
            break;

        case 0:
            exit = true;
            break;
    }
} while (!exit);
Console.WriteLine("Wybierz numer zwierzaka któremu chcesz zmienić nazwę");
/*
for(int i = 0; i < player.animals.Count; i++)
{
    Animal animal = player.animals[i];
    Console.WriteLine(i + ". " + animal.name);
}

int selected = int.Parse(Console.ReadLine());
Console.WriteLine("Wpisz nową nazwe zwierzaka");
string name = Console.ReadLine();
player.animals[selected].name = name;

Console.WriteLine("");
Console.WriteLine("");
foreach (Animal animal in player.animals)
{
    Console.WriteLine(animal.name);
    
}*/