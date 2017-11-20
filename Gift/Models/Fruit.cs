using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift.Models
{
    class Fruit :Sweetness
    {
        short _vitaminA;
        short _vitaminC;

        public short VitaminA { get => _vitaminA; set => _vitaminA = value; }
        public short VitaminC { get => _vitaminC; set => _vitaminC = value; }

        public Fruit(string name, string weight, string caloricity, string price, string vitaminA, string vitaminC)
            : base(name, weight, caloricity, price)
        {
            VitaminA = Int16.Parse(vitaminA);
            VitaminC = Int16.Parse(vitaminC);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("|VitaminA: {0,-10}|VitaminC: {1}", VitaminA, VitaminC);
        }
    }
}
