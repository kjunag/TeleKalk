using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace kalk
{
    class Checksum_Methods
    {
        static List<int> data = new List<int>();
        public static void addToList(string word_input)
        {
            
            
                var word = int.Parse(word_input, NumberStyles.HexNumber);
                data.Add(word);
            

        }

        public static string CalcChecksum()
        {
            var dane = data;
            int w = dane.Sum();
            if (w > 65535)
            {
                int ww = w / 0x10000;
                w -= ww * 0x10000;
                w = ~(w + ww) & 0xFFFF;

            }
            var w_string = w.ToString("X");
            return w_string;
        }
        
        public static void clearList()
        {
            data.Clear();
        }
    }
}
