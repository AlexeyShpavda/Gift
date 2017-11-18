using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gift.Enums;

namespace Gift.Models
{
    class Wafer
    {
        Taste _taste;
        bool _glaze;

        public Taste Taste { get => _taste; set => _taste = value; }
        public bool Glaze { get => _glaze; set => _glaze = value; }
    }
}
