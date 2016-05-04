using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcFlow : Arithmetic
    {
        public int firstNum;
        public int secondNum;
        public string sign;
        bool run = true;
        string line;
        public void Output()
        {
            while (run)
            {
                Console.WriteLine("Please type a first number");
                Console.WriteLine("");
                line = Console.ReadLine(); 
                Int32.TryParse(line, out firstNum);
                Console.Clear();
                ScrollProperty property = new ScrollProperty();
                sign = property.Scroll();
                
                Console.Clear();
                Console.WriteLine("Please type a second number");
                Console.WriteLine("");
                line = Console.ReadLine();
                Int32.TryParse(line, out secondNum);
                Console.Clear();
                checkSign(firstNum, secondNum, sign);
                Console.WriteLine("{0} {1} {2} = {3}", firstNum, sign, secondNum, sum);
                Console.WriteLine("");
                run = true;
            }
        }
        
        
    }
}
