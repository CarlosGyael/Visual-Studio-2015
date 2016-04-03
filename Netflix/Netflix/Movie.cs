using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Movie : Data
    {
        Visual visual = new Visual();
        Time time = new Time();
        Details detail = new Details();

        int count = 0;
        int moviemax;
        bool run = true;
        bool leftclick = false;
        bool rightclick = false;

        public List<string> movielist = new List<string>();

        public void startMovies()
        {
           movielist.Add("Allegiant");
           movielist.Add("Batman Vs Superman");
           movielist.Add("Captain America");
           movielist.Add("Deadpool");
           movielist.Add("Zootopia");
           movielist.Add("The Shallows");
           movielist.Add("Suicide Squad");
           movielist.Add("The Jungle Book");
            for (int i = 0; detail.listofrates.Count <= 8; i++)
            { detail.listofrates.Add(0); }
            ScrollDesign();
        }
        public void ScrollDesign()
        {
            while (run)
            {
                moviemax = movielist.Count - 1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("         Movie Menu");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("      ");
                getleftclick();
                Console.Write(" " + movielist[count] + " ");
                getrightclick();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("use F1 and F2 to scroll F3 to exit");
                Console.WriteLine("press enter to see details");
                inputcheck();
                Console.Clear();
            }
        }

        public void inputcheck()
        {
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.F1)
            {
                leftclick = true;
                rightclick = false;
                if (count == 0)
                {
                    count = moviemax;
                    run = true;
                }
                else if (count <= moviemax)
                {
                    count--;
                    run = true;
                }
            }
            else if (input.Key == ConsoleKey.F2)
            {
                rightclick = true;
                leftclick = false;
                if (count < moviemax)
                {
                    count++;
                    run = true;
                }
                else if (count == moviemax)
                {
                    count = 0;
                    run = true;
                }

            }
            else if (input.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                detail.whichtitle(movielist[count]);
            }
            else if (input.Key == ConsoleKey.F3)
            {
                Menu menu = new Menu();
                Console.Clear();
                menu.startmenu();
            }
        }

        public void getrightclick()
        {
            if (rightclick == true)
            {
                visual.RightColored();
            }
            else if (rightclick == false)
            {
                visual.Right();
            }
        }
        public void getleftclick()
        {
            if (leftclick == true)
            {
                visual.LeftColored();
            }
            else if (leftclick == false)
            {
                visual.left();
            }
        }
    }
}
