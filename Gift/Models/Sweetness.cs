using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift.Models
{
    abstract class Sweetness : IComparable<Sweetness>
    {
        private string _name;
        private short _weight;
        private short _caloricity;
        // By 100 grams.
        private double _price;
        // For 1 kilogram.

        public string Name { get => _name; set => _name = value; }
        public short Weight { get => _weight; set => _weight = value; }
        public short Caloricity { get => _caloricity; set => _caloricity = value; }
        public double Price { get => _price; set => _price = value; }

        public Sweetness(string name, string weight, string caloricity, string price)
        {
            Name = name;
            Weight = Int16.Parse(weight);
            Caloricity = Int16.Parse(caloricity);
            Price = Double.Parse(price);
        }

        public override string ToString()
        {
            return String.Format("Name: {0,-10}|Weight: {1,-4}|Caloricity: {2,-3}|Price: {3,-4}",
                Name, Weight, Caloricity, Price);
        }

        public int CompareTo(Sweetness obj)
        {
            if (Caloricity > obj.Caloricity)
                return 1;
            if (Caloricity < obj.Caloricity)
                return -1;
            else
                return 0;
        }

        public double ReturnsPrice()
        {
            return (Price / 1000) * Weight;
        }
    }
}
