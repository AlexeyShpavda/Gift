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
        private short _wheight;
        private short _caloricity;
        // By 100 grams.
        private double _price;
        // Per 1 kilogram.

        protected string Name { get => _name; set => _name = value; }
        protected short Wheight { get => _wheight; set => _wheight = value; }
        protected short Caloricity { get => _caloricity; set => _caloricity = value; }
        protected double Price { get => _price; set => _price = value; }

    }
}
