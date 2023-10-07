
using FarmerSymulator;
using FarmerSymulator.AnimalController;
using System.Runtime.CompilerServices;

User player  = new User();

string firstName=Console.ReadLine();
player.AddUser(firstName, 400);
int x = int.Parse(Console.ReadLine());
switch (x)
{

    case 1:

        break;
}
Console.WriteLine("Wybierz numer zwierzaka któremu chcesz zmienić nazwę");

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
    
}