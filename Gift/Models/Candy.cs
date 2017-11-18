using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gift.Enums;

namespace Gift.Models
{
    class Candy
    {
        short _cocoaPercentage;
        Stuffing _stuffing;

        public short CocoaPercentage { get => _cocoaPercentage; set => _cocoaPercentage = value; }
        public Stuffing Stuffing { get => _stuffing; set => _stuffing = value; }
    }
}
