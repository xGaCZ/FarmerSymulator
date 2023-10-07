using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FarmerSymulator.Menu
{
    class BuyMenu
    {
      public static void Menu()
        {
            Console.WriteLine($"Wybierz zwierze które chcesz kupić: \n1-królik\n2-kurczak\n3-krowa\n4-byk\n5-owca");
        }
    }
}
