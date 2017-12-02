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
            string l = "====================================================================================================";

            Gift.Models.Gift gift = new Gift.Models.Gift();
            gift.ReadingFile("input.txt");

            // List of sweets in the gift.
            Console.WriteLine("Initial data");
            Console.WriteLine(l);
            Console.Write(gift);
            Console.WriteLine(l);

            // Adds 2 fruits if the gift don't contains fruit.
            if (!gift.ContainFruit())
            {
                gift.gift.Add(new Fruit("Apple", "50", "35", "8", "65", "3"));
                gift.gift.Add(new Fruit("Raspberry", "45", "25", "7", "35", "4"));
            }
            Console.WriteLine("Added 2 fruits if the gift don't contains fruit");
            Console.WriteLine(l);
            Console.Write(gift);
            Console.WriteLine(l);

            // Сalculate weight of the gift, if weight of the gift is more than 1 kg we remove the heaviest candy.
            if (gift.СalculatesWeight() > 1000)
            {
                gift.DeleteHeaviestCandy();
            }
            Console.WriteLine("If weight of the gift is more than 1 kg remove the heaviest candy");
            Console.WriteLine(l);
            Console.Write(gift);
            Console.WriteLine(l);

            // Calorie sorting.
            gift.gift.Sort();
            Console.WriteLine("After сalorie sorting");
            Console.WriteLine(l);
            Console.Write(gift);
            Console.WriteLine(l);


            // Calculating the cost of a gift.
            Console.WriteLine("Price:" + gift.СalculatesPrice());
            Console.WriteLine(l);

            // Records the composition of the gift, weight and price in a file.
            gift.WriteToFiles("output.txt");

            Console.ReadKey();
        }
    }
}
