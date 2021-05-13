using System;
using System.Collections.Generic;
using System.Text;

namespace kalk
{
    class Hamming_Methods

    {
        public static int parity(float ones)
        {
            int parity_bit = 0;
            if (ones % 2 == 0)
            {
                parity_bit = 0;
            }

            else
            {
                parity_bit = 1;
            }

            return parity_bit;
        }
        public static string hamming_15_11_encode(string input)
        {
            string output;
            int result;
            if (input.Length == 11)
            {
                int p1;
                int p2;
                int p4;
                int p8;
                float p1_ones;
                float p2_ones;
                float p4_ones;
                float p8_ones;
                p1_ones = float.Parse(input[0].ToString()) + float.Parse(input[1].ToString()) + float.Parse(input[3].ToString()) + float.Parse(input[4].ToString()) + float.Parse(input[6].ToString())
                    + float.Parse(input[8].ToString()) + float.Parse(input[10].ToString());
                p2_ones = float.Parse(input[0].ToString()) + float.Parse(input[2].ToString()) + float.Parse(input[3].ToString()) + float.Parse(input[5].ToString()) + float.Parse(input[6].ToString())
                    + float.Parse(input[9].ToString()) + float.Parse(input[10].ToString());
                p4_ones = float.Parse(input[1].ToString()) + float.Parse(input[2].ToString()) + float.Parse(input[3].ToString()) + float.Parse(input[7].ToString()) + float.Parse(input[8].ToString()) + float.Parse(input[9].ToString())
                    + float.Parse(input[10].ToString());
                p8_ones = float.Parse(input[4].ToString()) + float.Parse(input[5].ToString()) + float.Parse(input[6].ToString()) + float.Parse(input[7].ToString())
                    + float.Parse(input[8].ToString()) + float.Parse(input[9].ToString()) + float.Parse(input[10].ToString());

                p1 = parity(p1_ones);
                p2 = parity(p2_ones);
                p4 = parity(p4_ones);
                p8 = parity(p8_ones);
                output = $"{p1}{p2}{input[0]}{p4}{input[1]}{input[2]}{input[3]}{p8}{input[4]}{input[5]}{input[6]}{input[7]}{input[8]}{input[9]}{input[10]}";
                return output;
            }
            else
            {
                output = "wpisz poprawną wartość";
            }
            return output;
        }

        public static string hamming_7_4_encode(string input)
        {
            string output = null;
            int result;

            if (input.Length == 4 && int.TryParse(input, out result) == true)
            {
                int p1;
                int p2;
                int p4;
                float p1_ones;
                float p2_ones;
                float p4_ones;
                p1_ones = float.Parse(input[0].ToString()) + float.Parse(input[1].ToString()) + float.Parse(input[3].ToString());
                p2_ones = float.Parse(input[0].ToString()) + float.Parse(input[2].ToString()) + float.Parse(input[3].ToString());
                p4_ones = float.Parse(input[1].ToString()) + float.Parse(input[2].ToString()) + float.Parse(input[3].ToString());
                p1 = parity(p1_ones);
                p2 = parity(p2_ones);
                p4 = parity(p4_ones);

                output = $"{p1}{p2}{input[0]}{p4}{input[1]}{input[2]}{input[3]}";
            }
            else
            {
                output = "wpisz poprawną wartość";
            }
            return output;
        }




    }
}

