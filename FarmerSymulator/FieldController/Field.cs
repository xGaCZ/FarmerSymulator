using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerSymulator.FieldController
{
    class Field
    {
        public int area { get; set; }
        public int fieldClass { get; set; }
        public bool waterOnField { get; set; }

        public int rng(int min, int max)
        {
            Random rnd = new Random();
            int x = rnd.Next(min, max); ;
            return x;
        }
        private bool checkWater()
        {
            if (rng(0,2) == 0)
            { waterOnField = true; }
            else { waterOnField = false; }
            return waterOnField;
        }
        public void smallArea()
        {
            area = rng(1, 6);
            fieldClass = rng(1, 4);
           waterOnField = checkWater();
        }
        public void mediumArea()
        {
            area = rng(6, 11);
            fieldClass = rng(2, 6);
            waterOnField = checkWater();
        }
        public void largeArea()
        {
            area = rng(11, 15);
            fieldClass = rng(3, 7);
            waterOnField = checkWater();
        }
        public void extraLargeArea()
        {
            area = rng(16, 26);
            fieldClass = rng(4, 7);
            waterOnField = checkWater();
        }
    }
}
