using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    abstract class Arithmetic
    {
        public int sum;
        public int checkSign(int first, int second, string sign)
        {
            
            if (sign == "+")
            {
                sum = first + second;
            }
            else if (sign == "-")
            {
                sum = first - second;
            }
            else if (sign == "*")
            {
                sum = first * second;
            }
            else if (sign == "/")
            {
                sum = first / second;
            }
            else if (sign == "%")
            {
                sum = first % second;
            }
            return sum;
        }
    }
}
