using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gift.Enums;

namespace Gift.Models
{
    class Candy :Sweetness
    {
        short _cocoaPercentage;
        Stuffing _stuffing;

        public short CocoaPercentage { get => _cocoaPercentage; set => _cocoaPercentage = value; }
        public Stuffing Stuffing { get => _stuffing; set => _stuffing = value; }

        public Candy(string name, string weight, string caloricity, string price, string cocoaPercentage, string stuffing)
            : base(name, weight, caloricity, price)
        {
            CocoaPercentage = Int16.Parse(cocoaPercentage);
            Stuffing = (Stuffing)Enum.Parse(typeof(Stuffing), stuffing);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("|CocoaPercentage: {0,-3}|Stuffing: {1}", CocoaPercentage, Stuffing);
        }
    }
}
