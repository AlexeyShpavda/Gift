using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift.Models
{
    abstract class Sweetness
    {
        private string _name;
        private short _weight;
        private short _caloricity;
        // By 100 grams.
        private double _price;
        // Per 1 kilogram.

        protected string Name { get => _name; set => _name = value; }
        protected short Weight { get => _weight; set => _weight = value; }
        protected short Caloricity { get => _caloricity; set => _caloricity = value; }
        protected double Price { get => _price; set => _price = value; }

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
    }
}
