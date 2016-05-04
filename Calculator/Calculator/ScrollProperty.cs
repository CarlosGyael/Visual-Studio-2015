using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ScrollProperty
    {
        List<string> Properties;
        ConsoleKeyInfo input;
        public string Scroll()
        {
            int i = 0;
            bool run = true;
            while (run)
            {
                Properties = new List<string>();
                additems();

                Console.WriteLine("Please scroll by pressing any button,aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa select by pressing enter");
                Console.WriteLine("");
                Console.Write(Properties[i]);

                input = Console.ReadKey();
                if (input.Key == ConsoleKey.Enter)
                {
                    run = false;
                }
                else if (i == 4)
                {
                    i = 0;
                }
                else
                {
                    i++;
                }
                Console.Clear();
            }
            return Properties[i];

        }

        private void additems()
        {
            Properties.Add("+");
            Properties.Add("-");
            Properties.Add("*");
            Properties.Add("/");
            Properties.Add("%");
        }
    }
}
