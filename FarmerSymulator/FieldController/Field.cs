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
        public string fieldNumber { get; set; }
        public int fieldCost { get; set; }
        public FieldSize fieldSize { get; set; }
        Random rng = new Random();
        public Field(FieldSize fieldSize, string fieldNumber)
        {
            this.fieldSize = fieldSize; 
            this.fieldNumber = fieldNumber;
            Create();
        }

        public void Create()
        {

            if(fieldSize == FieldSize.small)
            {
                area =rng.Next(1,6);
                fieldCost = 500;
                fieldClass = rng.Next(1, 4);
                if (rng.Next(0, 2) == 0)
                { waterOnField = true; }
                else { waterOnField = false; }
            }
            else if (fieldSize == FieldSize.medium)
            {
                area = rng.Next(6,11);
                fieldCost = 1000;
                fieldClass = rng.Next(2, 6);
                if (rng.Next(0, 2) == 0)
                { waterOnField = true; }
                else { waterOnField = false; }
            }
            else if (fieldSize == FieldSize.large) 
            {
                fieldCost = 1500;
                area = rng.Next(11, 16);
                fieldClass = rng.Next(3, 7);
                if (rng.Next(0, 2) == 0)
                { waterOnField = true; }
                else { waterOnField = false; }
            }
            else if (fieldSize == FieldSize.extraLarge)
            {
                area = rng.Next(16, 26);
                fieldCost = 2200;
                fieldClass = rng.Next(4, 7);
                if (rng.Next(0, 2) == 0)
                { waterOnField = true; }
                else { waterOnField = false; }
            }
        }
    }
}
