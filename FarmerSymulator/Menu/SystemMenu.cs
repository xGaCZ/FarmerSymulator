using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FarmerSymulator.Menu
{
    class SystemMenu
    {
        public static void MenuAnimal()
        {
            Console.WriteLine($"Wybierz zwierze które chcesz kupić: \n1-królik Cena:50\n2-kurczak Cena:20\n3-krowa Cena:200\n4-byk Cena:300\n5-owca Cena:150");
        }
        public static void MenuField()
        {
            Console.WriteLine($"Rozmiar działki jest losowy tak samo jak klasa ziemi oraz przyłącze do wody\nWybierz rozmiar działki którą chcesz kupić: \n1-Mała ( od 1 do 5 ) Cena:500\n2-Średnia ( od 6 do 10 ) Cena:1000\n3-Duża ( od 11 do 15 ) Cena:1500\n4-B.Duża (16 do 25) Cena:2200");
        }
        public static void MainMenu() 
        {
            Console.WriteLine($"1-Zakup zwierząt\n2-Zakup ziemi\n3-Dane Zwierząt\n4-Dane o polach\n5-Masarnia\n7-Koniec tury\n0-Wyjście ");

        }
        public static void ButcherMenu()
        {
            Console.WriteLine($"Wybierz gatunek zwierzęcia do sprzedaży:\n1-Byk(5PLN za 1kg)\n2-Królik(20PLN za 1kg)\n3-Owca(10PLN za 1kg)");
        }
    }
}
