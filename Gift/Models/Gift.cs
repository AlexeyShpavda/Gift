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
    class Gift : IReadFiles
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
                    //if (str[0] == '')
                    //    gift.Add(new );
                    //else if (str[0] == '')
                    //    gift.Add(new );
                    //else if (str[0] == '')
                    //    gift.Add(new );

                }
            }
        }

    }
}
