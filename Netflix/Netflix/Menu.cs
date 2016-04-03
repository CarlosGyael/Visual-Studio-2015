using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Menu : Data
    {
        Visual visual = new Visual();
        Time time = new Time();
        SubMenu submenu = new SubMenu();

        int count = 0;
        int genremax;
        bool run = true;
        bool leftclick = false;
        bool rightclick = false;
        string title;

        public List<List<string>> genrelist = new List<List<string>>();
        public List<string> Movies = new List<string>();
        public List<string> Shows = new List<string>();
        public List<string> Action = new List<string>();
        public List<string> Comedy = new List<string>();
        public List<string> Romance = new List<string>();
        public List<string> Adventure = new List<string>();
        public List<string> All = new List<string>();

        public void startmenu()
        {
            
            genrelist.Add(Movies);
            genrelist.Add(Shows);
            genrelist.Add(Comedy);
            genrelist.Add(Action);
            genrelist.Add(Romance);
            genrelist.Add(Adventure);
            genrelist.Add(All);

            Movies.Add("Allegiant");
            Movies.Add("Batman Vs Superman");
            Movies.Add("Captain America");
            Movies.Add("Deadpool");
            Movies.Add("Zootopia");
            Movies.Add("The Shallows");
            Movies.Add("Suicide Squad");
            Movies.Add("The Jungle Book");

            Shows.Add("Breaking Bad");
            Shows.Add("Pokemon");
            Shows.Add("Naruto");
            Shows.Add("Spongebob");
            Shows.Add("Power Rangers");

            ScrollDesign();
        }
        public void ScrollDesign()
        {
            while (run)
            {
                genremax = genrelist.Count - 1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("         Genre Menu");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("      ");
                getleftclick();
                listtoname(genrelist[count]);
                Console.Write(" " + title + " ");
                getrightclick();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("use F1 and F2 to scroll F3 to exit");
                Console.WriteLine("press enter to select");
                inputcheck();
                Console.Clear();
            }
        }

        public string listtoname(List<string> i )
        {
            if (i == Movies)
            {
                title = "Movies";
            }
            else if (i== Shows)
            {
                title = "Shows";
            }
            else if (i == Comedy)
            {
                title = "Comedy";
            }
            else if (i == Action)
            {
                title = "Action";
            }
            else if (i == Romance)
            {
                title = "Romance";
            }
            else if (i == Adventure)
            {
                title = "Adventure";
            }
            else if (i == All)
            {
                title = "All";
            }
            return title;
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
                    count = genremax;
                    run = true;
                }
                else if (count <= genremax)
                {
                    count--;
                    run = true;
                }
            }
            else if (input.Key == ConsoleKey.F2)
            {
                rightclick = true;
                leftclick = false;
                if (count < genremax)
                {
                    count++;
                    run = true;
                }
                else if (count == genremax)
                {
                    count = 0;
                    run = true;
                }

            }
            else if (input.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                listtoname(genrelist[count]);
                submenu.choose(title);
            }
            else if (input.Key == ConsoleKey.F3)
            {
                NetflixFlow flow = new NetflixFlow();
                Console.Clear();
                flow.flow();
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
