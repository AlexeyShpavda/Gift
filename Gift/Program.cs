using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gift.Models;

namespace Gift
{
    class Program
    {
        static void Main()
        {
            string l = "====================================================================================================================";

            Gift.Models.Gift gift = new Gift.Models.Gift();
            gift.ReadingFile("input.txt");

            Console.ReadKey();
        }
    }
}
