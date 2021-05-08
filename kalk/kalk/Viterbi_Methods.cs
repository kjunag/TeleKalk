using System;
using System.Collections.Generic;
using System.Text;

namespace kalk
{
    class Viterbi_Methods
    {
        public static string coder_localiser(string code_segment)
        {
            string localisation = null;

            switch (code_segment)
            {
                case "000":
                    localisation = "a";
                    break;

                case "001":
                    localisation = "a";
                    break;

                case "010":
                    localisation = "b";
                    break;
                case "011":
                    localisation = "b";
                    break;
                case "111":
                    localisation = "c";
                    break;
                case "110":
                    localisation = "c";
                    break;
                case "101":
                    localisation = "d";
                    break;
                case "100":
                    localisation = "d";
                    break;

                default:
                    break;
            }
            return localisation;
        }
        public static string a_code(char bit)
        {
            string up = "000";
            string down = "111";
            string code_segment;
            code_segment = null;
            if (bit == '1')
            {
                code_segment = down;
            }
            else
            {
                code_segment = up;
            }
            return code_segment;
        }

        public static string b_code(char bit)
        {
            string up = "001";
            string down = "110";
            string code_segment;
            code_segment = null;
            if (bit == '1')
            {
                code_segment = down;
            }
            else
            {
                code_segment = up;
            }
            return code_segment;
        }

        public static string c_code(char bit)
        {
            string up = "010";
            string down = "100";
            string code_segment;
            code_segment = null;
            if (bit == '1')
            {
                code_segment = down;
            }
            else
            {
                code_segment = up;
            }
            return code_segment;
        }

        public static string d_code(char bit)
        {
            string up = "011";
            string down = "101";
            string code_segment;
            code_segment = null;
            if (bit == '1')
            {
                code_segment = down;
            }
            else
            {
                code_segment = up;
            }
            return code_segment;
        }

        public static string code(string input, string localisation)
        {
            int i = 0;
            string code_segment = null;
            string code = null;
            if (int.TryParse(input, out int result) == true) 
            {
                while (i <= (input.Length - 1))
                {

                    var bit = input[i];

                    if (localisation == "a")
                    {
                        code_segment = a_code(bit);
                    }
                    else if (localisation == "b")
                    {
                        code_segment = b_code(bit);
                    }
                    else if (localisation == "c")
                    {
                        code_segment = c_code(bit);
                    }
                    else
                    {
                        code_segment = d_code(bit);
                    }
                    code = code + " " + code_segment;
                    localisation = coder_localiser(code_segment);
                    i++;
                }
            }
            else
            {
                code = "wpisz poprawną wartość";
            }
            return code;
        }
    }
}
