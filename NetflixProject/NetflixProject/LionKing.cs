using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class LionKing : Title
    {
        Time time = new Time();
        private string Duration = "3:25";
        private ConsoleKeyInfo input;
        private string letters;
        private bool run = true;

        public void details()
        {
            settitle("Lion King");
            rating(2);

            while (run)
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Rating: " + rate);
                Console.WriteLine("Duration: " + Duration);
                Console.WriteLine("");
                Console.WriteLine("");
                time.OneSec();
                Console.WriteLine("press F1 to change rating press anything else to return");
                input = Console.ReadKey();
                changerating(input);
                if (run == false)
                {
                    break;
                }
            }

        }
        public bool changerating(ConsoleKeyInfo i)
        {
            if (i.Key == ConsoleKey.F1)
            {
                Console.Clear();
                Console.WriteLine("please enter a rate from 0-5");
                letters = Console.ReadLine();
                Int32.TryParse(letters, out rate);
                rating(rate);
                if (rate > 5)
                {
                    run = false;
                }
                else if (rate < 0)
                {
                    run = false;
                    return run;
                }
                else
                {
                    run = true;
                }


                return run;
            }
            else {
                run = false;
                return run;
            }
        }

    }


}
