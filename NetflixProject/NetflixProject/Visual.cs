using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Visual
    {
        Time time = new Time();
        private string[] Text;
        public void NetflixText()
        {
            Text = File.ReadAllLines("NetflixIntro.txt");
            foreach (string array in Text)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(array);
                time.OneSec();
            }
            time.OneSec();
            Console.ResetColor();
            Console.Clear();

        }

        public void Right()
        {
            Console.Write(" >> ");

        }
        public void RightColored()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" >> ");
            Console.ResetColor();
        }

        public void left()
        {
            Console.Write(" << ");

        }

        public void LeftColored()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" << ");
            Console.ResetColor();
        }


    }
}
