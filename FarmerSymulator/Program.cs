
using FarmerSymulator;
using FarmerSymulator.AnimalController;
using FarmerSymulator.FieldController;
using FarmerSymulator.Menu;
using System.Runtime.CompilerServices;
User player  = new User();
AnimalType animalTypes = new AnimalType();
Shop shop = new Shop();
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
            
                foreach(Animal animal in player.animals.FindAll(a=> a.animalType==AnimalType.Bull || a.animalType==AnimalType.Sheep || a.animalType == AnimalType.Rabbit))
                {                  
                 Console.WriteLine($"Gatunek zwierzęcia:{animal.animalType} Nazwa:{animal.name} Waga{animal.weight} Wartość:{animal.weight*animal.meetCost}PLN");                    
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
                else { Console.WriteLine("Takie zwierze nie istnieje"); }
            }
            break;
     
            case 7:
            
            foreach (Animal type in player.animals.ToList())
                { 
                    if(type.animalType == AnimalType.Chicken && type.eatLevel >=3)
                    {
                        egg++;
                    }
                if (type.animalType == AnimalType.Cow && type.eatLevel >= 3)
                {
                    milk++;
                }
                type.eatLevel--;
                type.liveTime++;

                if (type.eatLevel == 0 || type.deadTime == type.liveTime)
                {
                    player.animals.Remove(type);
                }
                }
            
            break;
        case 8:
            Console.WriteLine("Witamy w sklepie!!!\n1-Zakup Karmy\n2-Sprzedaż towaru");

            int userChoose = int.Parse(Console.ReadLine());
            if (userChoose == 1)
            {
                Console.WriteLine("1-Mała karma\n2-Średnia karma\n3-Duża karma\n");
                int userChoose1 = int.Parse(Console.ReadLine());
                if (userChoose1 == 1)
                {
                    int x1 = shop.FoodBuySmall(player.cash);
                    player.cash -= (x1 * shop.bigFoodCost);
                    player.smallFood += x1;
            
                }
                else if (userChoose1 == 2)
                {
                    int x2 = shop.FoodBuyMedium(player.cash);
                    player.cash -= (x2 * shop.bigFoodCost);
                    player.smallFood += x2;
                }
                else if (userChoose1 == 3)
                {
                   int x3=shop.FoodBuyBig(player.cash);
                    player.cash -= (x3 * shop.bigFoodCost);
                    player.smallFood += x3;
                }

            }
            else if (userChoose == 2)
            {
                Console.WriteLine($"1-Jajka (cena:{shop.eggCost})\n2-Mleko (cena:{shop.milkCost}) ");
                int userChoose1 = int.Parse(Console.ReadLine());
                if (userChoose1 == 1)
                {
                    Console.WriteLine($"Posiadasz: {egg} jaj");
                    int v1=shop.EggSell(egg);
                    player.cash += v1;
                    Console.WriteLine($"Posiadasz jeszcze {egg} jajek i zarobiłeś{v1}");
                }
                else if (userChoose1 == 2)
                {
                    Console.WriteLine($"Posiadasz: {milk} mleka");
                    int v2 = shop.MilkSell(milk);
                    player.cash += v2;
                    Console.WriteLine($"Posiadasz jeszcze {milk} mleka i zarobiłeś{v2}");
                }

            }
           
            break;

        case 9:
            Console.WriteLine($"Wybierz gatunek zwierzaka którego chcesz nakarmić\n1-królik\n2-kurczak\n3-krowa\n4-byk\n5-owca");
            int chooseType = int.Parse(Console.ReadLine());
            Console.WriteLine($"Wybierz typ Karmy\n1-mała (najedzenie +1 waga +1)\n2-średnia (najedzenie +2 waga +3)\n3-duże (najedzenie +3 waga +5)");
            int chooseType3 = int.Parse(Console.ReadLine());

            foreach (Animal type in player.animals.ToList())
            {
                int chooseType2 = (int)type.animalType;
                if (chooseType3 == 1)
                {
                    if (chooseType == chooseType2 &&  chooseType >= 2)
                    {

                        type.eatLevel += 1;
                        player.smallFood -= 1;

                    }
                    else
                    {
                        type.eatLevel += 1;
                        player.smallFood -= 1;
                        type.weight += 1;
                    }
                }
                if (chooseType3 == 2)
                {
                    if (chooseType == chooseType2 && chooseType >= 2)
                    {

                        type.eatLevel += 2;
                        player.mediumFood -= 1;

                    }
                    else
                    {
                        type.eatLevel += 2;
                        player.mediumFood -= 1;
                        type.weight += 3;
                    }
                }
                if (chooseType3 == 3)
                {
                    if (chooseType == chooseType2 && chooseType >= 2)
                    {

                        type.eatLevel += 3;
                        player.BigFood -= 1;

                    }
                    else
                    {
                        type.eatLevel +=3 ;
                        player.smallFood -= 1;
                        type.weight += 4;
                    }
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