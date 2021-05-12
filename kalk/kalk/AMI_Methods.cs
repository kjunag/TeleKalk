using System;
using System.Collections.Generic;
using System.Text;

namespace kalk
{
    class AMI_Methods
    {
        public static string ami_encode(string input)
        {
            int i = 0;
            char last_one = '-';
            var code = new StringBuilder();
            while (i <= input.Length - 1)
            {
                if (input[i] == '1')
                {
                    if (last_one == '-')
                    {
                        code.Append("+");
                        last_one = '+';
                    }
                    else
                    {
                        code.Append("-");
                        last_one = '-';
                    }
                }
                else
                {
                    code.Append("0");
                }
                i++;
            }
            return code.ToString();
        }
    }
}
