using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    public class Genre
    {

        ConsoleKeyInfo input;

        private string newtitle = null;
        Visual visual = new Visual();
        private List<string> list = new List<string>();
        private List<string> title = new List<string>();

        public void genremenu()
        {
            addgenrelist();
            startgenre();
        }

        public void startgenre()
        {
            foreach (string i in viewmenu(title.ToList()))
            {
                visual.left();
                Console.Write(i);
                visual.RightColored();
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.Enter && i == "Movie")
                {
                    Movies movie = new Movies();
                    movie.moviemenu();
                }
                else if (input.Key == ConsoleKey.Enter && i == "All")
                {
                    All all = new All();
                    all.menu();
                }
                else if (input.Key == ConsoleKey.Enter && i == "Show")
                {
                    Shows show = new Shows();
                    show.startshow();
                }
                else if (input.Key == ConsoleKey.Enter && i == "Comedy")
                {
                    Comedy comedy = new Comedy();
                    comedy.menu();
                }
                else if (input.Key == ConsoleKey.Enter && i == "Romance")
                {
                    Romance romance = new Romance();
                    romance.menu();
                }
                else if (input.Key == ConsoleKey.Enter && i == "Action")
                {
                    Action action = new Action();
                    action.menu();
                }
                else if (input.Key == ConsoleKey.Enter && i == "Add Genre")
                {
                    foreach (string j in title)
                    {
                        Console.WriteLine("choose your genre");
                        Console.WriteLine("");
                        Console.WriteLine(j);
                        input = Console.ReadKey();
                        Console.Clear();
                        if (input.Key == ConsoleKey.Enter)
                        {
                            All all = new All();
                            all.additems();
                            all.viewmenu(list);
                            foreach (string k in list)
                            {
                                Console.WriteLine("choose a title to add to it!");
                                Console.WriteLine("");
                                Console.WriteLine(k);
                                input = Console.ReadKey();
                                Console.Clear();
                                if (input.Key == ConsoleKey.Enter)
                                {
                                    title.Add(j +" " + k);
                                    startgenre();
                                }
                                
                            }
                            
                        }
                        
                    }
                }
                Console.Clear();
                
            }
        }

        public void addgenrelist()
        {
            title.Add("Movie");
            title.Add("Show");
            title.Add("Romance");
            title.Add("Comedy");
            title.Add("Action");
            title.Add("All");
            string romance = title[2];
            string comedy = title[3];
            string action = title[4];
            addtitles(ref romance, ref comedy, out newtitle);
            title.Add(newtitle);
            addtitles(ref romance, ref action, out newtitle);
            title.Add(newtitle);
            addtitles(ref action, ref comedy, out newtitle);
            title.Add(newtitle);
            title.Add("Add Genre");
            list.Add("Lion King");
            list.Add("Bad Boys");
            list.Add("Captain America");
            list.Add("Family Guy");
            list.Add("SpongeBob");
            list.Add("Pokemon");
        }

        public string addtitles(ref string a, ref string b, out string c)
        {
            c = a + " " + b;
            return c;
        }

        public IEnumerable viewmenu(List<string> a)
        {
            for (int j = 0; j < 1; j--)
            {
                foreach (string i in a)
                {
                    yield return i;
                }
            }
        }
    }
}
