using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gift.Enums;

namespace Gift.Models
{
    class Wafer :Sweetness
    {
        Taste _taste;
        bool _glaze;

        public Taste Taste { get => _taste; set => _taste = value; }
        public bool Glaze { get => _glaze; set => _glaze = value; }

        public Wafer(string name, string weight, string caloricity, string price, string taste, string glaze)
            : base(name, weight, caloricity, price)
        {
            Taste = (Taste)Enum.Parse(typeof(Taste), taste);
            Glaze = Boolean.Parse(glaze);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("|Taste: {0,-13}|Glaze: {1}", Taste, Glaze);
        }
    }
}
