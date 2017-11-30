using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Gift.Interfaces;
using Gift.Breakers;

namespace Gift.Models
{
    class Gift : IReadFiles, IWriteToFiles
    {
        List<Sweetness> _gift = new List<Sweetness>();

        internal List<Sweetness> gift { get => _gift; set => _gift = value; }

        public void ReadingFile(string fileName)
        {
            string str;
            using (StreamReader reader = new StreamReader(fileName))
            {
                while ((str = reader.ReadLine()) != null)
                {
                    string[] words = LineBreaker.ReturnWordArr(' ', str, 1);
                    if (str[0] == 'C')
                        gift.Add(new Candy(words[0], words[1], words[2], words[3], words[4], words[5]));
                    else if (str[0] == 'W')
                        gift.Add(new Wafer(words[0], words[1], words[2], words[3], words[4], words[5]));
                    else if (str[0] == 'F')
                        gift.Add(new Fruit(words[0], words[1], words[2], words[3], words[4], words[5]));
                }
            }
        }

        public override string ToString()
        {
            string str = String.Empty;
            foreach (var element in gift)
            {
                str += element.ToString() + "\r\n";
            }
            return str;
        }

        public bool ContainFruit()
        {
            foreach (var sweetness in gift)
            {
                if (sweetness is Fruit)
                {
                    return true;
                }
            }
            return true;
        }

        public int ReturnsWeight()
        {
            int weight = 0;
            foreach (var sweetness in gift)
            {
                weight += sweetness.Weight;
            }
            return weight;
        }

        public void DeleteHeaviestCandy()
        {
            int _maxWeight = 0;
            int _candyIndex = -1;
            for (var i = 0; i < gift.Count; i++)
            {
                if (gift[i] is Candy && _maxWeight < gift[i].Weight)
                {
                    _maxWeight = gift[i].Weight;
                    _candyIndex = i;
                }
            }
            if (_candyIndex < 0)
            {
                return;
            }
            gift.RemoveAt(_candyIndex);
        }

        public double СalculatesPrice()
        {
            double price = 0;
            foreach (Sweetness sweet in gift)
            {
                price += sweet.ReturnsPrice();
            }
            return price;
        }

        public int СalculatesWeight()
        {
            int weight = 0;
            foreach (Sweetness sweet in gift)
            {
                weight += sweet.Weight;
            }
            return weight;
        }

        public void WriteToFiles(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(ToString());
                writer.WriteLine("Weight: " + СalculatesWeight() + " | " + "Price: " + СalculatesPrice());
            }
        }

    }
}
