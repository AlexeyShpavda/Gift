using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift.Models
{
    class Fruit
    {
        short _vitaminA;
        short _vitaminC;

        public short VitaminA { get => _vitaminA; set => _vitaminA = value; }
        public short VitaminC { get => _vitaminC; set => _vitaminC = value; }
    }
}
