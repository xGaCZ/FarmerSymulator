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
        public FieldSize fieldSize { get; set; }
        Random rng = new Random();
        public Field(FieldSize fieldSize)
        {
            this.fieldSize = fieldSize; 
            Create();
        }

        public void Create()
        {
            Console.WriteLine($"Podaj numer Pola(przykład:Małe41): ");
            fieldNumber = Console.ReadLine();
            if(fieldSize == FieldSize.small)
            {
                area =rng.Next(1,6);
                fieldClass = rng.Next(1, 4);
                if (rng.Next(0, 2) == 0)
                { waterOnField = true; }
                else { waterOnField = false; }
            }
            else if (fieldSize == FieldSize.medium)
            {
                area = rng.Next(6,11);
                fieldClass = rng.Next(2, 6);
                if (rng.Next(0, 2) == 0)
                { waterOnField = true; }
                else { waterOnField = false; }
            }
            else if (fieldSize == FieldSize.large) 
            {
                area = rng.Next(11, 16);
                fieldClass = rng.Next(3, 7);
                if (rng.Next(0, 2) == 0)
                { waterOnField = true; }
                else { waterOnField = false; }
            }
            else if (fieldSize == FieldSize.extraLarge)
            {
                area = rng.Next(16, 26);
                fieldClass = rng.Next(4, 7);
                if (rng.Next(0, 2) == 0)
                { waterOnField = true; }
                else { waterOnField = false; }
            }
        }
    }
}
