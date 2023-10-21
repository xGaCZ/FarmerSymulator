using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerSymulator
{
    class Shop 
    {
        public int eggCost { get; set; } = 10;
        public int milkCost { get; set; } = 15;
        public int smallFoodCost { get; set; } = 1;
        public int mediumFoodCost { get; set; } = 2;
        public int bigFoodCost { get; set; } = 3;


        public int EggSell( int eggValue)
        {
            if (eggValue > 0) 
            { 
            Console.WriteLine("ile jaj chcesz sprzedać:");
            int esell = int.Parse(Console.ReadLine());
                if(eggValue>= esell) 
                {
                    int xa = esell * eggCost;
                    return xa;
                }
                else
                { Console.WriteLine("nie masz tyle jaj"); }

            }
            else { Console.WriteLine("nie masz tyle jajek"); }
            return 0;
        }
        public int MilkSell( int milkValue)
        {
            if (milkValue > 0)
            {
                Console.WriteLine("ile mleka chcesz sprzedać:");
                int esell = int.Parse(Console.ReadLine());
                if (milkValue >= esell)
                {
                    int xxa = esell * milkCost;
                    return xxa;
                }

            }
            else { Console.WriteLine("nie masz tyle mleka"); }
            return 0;
        }
        public int FoodBuySmall(int cashPlayer)
        {
                Console.WriteLine("Ile karmy chcesz kupić");
                int valuie = int.Parse(Console.ReadLine());
                if(cashPlayer >= valuie*smallFoodCost)
                {
                Console.WriteLine($"Kupiłeś {valuie} karmy");
                return valuie;
                }
                return 0;
            }
        public int FoodBuyMedium(int cashPlayer)
        {
                Console.WriteLine("Ile karmy chcesz kupić");
                int valuie = int.Parse(Console.ReadLine());
                if (cashPlayer >= valuie * mediumFoodCost)
                {
                Console.WriteLine($"Kupiłeś {valuie} karmy");
                return valuie;
                   
                }
            return 0;
        }
        public int FoodBuyBig(int cashPlayer)
        {
                Console.WriteLine("Ile karmy chcesz kupić");
                int valuie = int.Parse(Console.ReadLine());
                if (cashPlayer >= valuie * bigFoodCost)
                {
                Console.WriteLine($"Kupiłeś {valuie} karmy");
                return valuie;              
                }
            return 0;
        }
        
    }
}
