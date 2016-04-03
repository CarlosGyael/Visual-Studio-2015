using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Details : Data
    {
        string details;
        int rate;
        bool turn;
        string kind;
        int track;
        ConsoleKeyInfo input;

        public List<int> listofrates = new List<int>();
        public void whichtitle(string list)
        {
            
            
            switch (list)
            {
                case "Captain America":
                    rate = listofrates[0];
                    track = 0;
                    getduration("146 min");
                    details = "Political interference in the Avengers' activities causes a rift between former allies Captain America and Iron Man.";
                    printdetail("Captain America");
                    kind = "Adventure";
                    break;
                case "Allegiant":
                    rate = listofrates[1];
                    getduration("234 min");
                    details = "Political interference in the Avengers' activities causes a rift between former allies Captain America and Iron Man.";
                    printdetail("Allegiant");
                    kind = "Action";
                    track = 1;
                    break;
                case "Batman Vs Superman":
                    rate = listofrates[2];
                    getduration("146 min");
                    details = "Political interference in the Avengers' activities causes a rift between former allies Captain America and Iron Man.";
                    printdetail("Captain America");
                    kind = "Adventure";
                    track = 2;
                    break;
                case "Deadpool":
                    rate = listofrates[3];
                    getduration("146 min");
                    details = "Political interference in the Avengers' activities causes a rift between former allies Captain America and Iron Man.";
                    printdetail("Captain America");
                    kind = "Adventure";
                    track = 3;
                    break;
            }
        }
        public void printdetail(string i)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("            " + i);
            Console.ResetColor();
            getratingstar(rate);
            Console.WriteLine("Rating: " + ratingstar);
            Console.WriteLine("");

            Console.WriteLine("Type:" + kind);

            Console.WriteLine("Duration: " + duration);
            Console.WriteLine("");

            Console.WriteLine("Details: " + details);
            Console.WriteLine("");
            Console.WriteLine("press F4 to change content or F3 to exit");
            input = Console.ReadKey();
            Console.Clear();
            inputcheck(i, input);

        }

        public void inputcheck(string i, ConsoleKeyInfo j)
        {
            if (j.Key == ConsoleKey.F1)
            {
                turn = true;
                rating(i);
            }
            else if (j.Key == ConsoleKey.F2)
            {
                turn = false;
                type(i);
            }
            else if (j.Key == ConsoleKey.F3)
                {
               Movie movie = new Movie();
                    Console.Clear();
                movie.startMovies();

                }
            else if (j.Key == ConsoleKey.F4)
            {
                if (turn == true)
                {
                    if (rate < 5)
                    {
                        rate += 1;
                        listofrates[track] += 1;
                    }
                    else if (rate == 5)
                    {
                        rate = 0;
                        listofrates[track] = 0;
                    }
                    rating(i);
                }
                else if (turn == false)
                {

                    type(i);
                }
                
                else {
                    inputcheck(i, input);
                }
            }

            Console.Clear();
            inputcheck(i, input);
        }





        public void rating(string i)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("            " + i);
            Console.ResetColor();
            getratingstar(rate);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Rating:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" " + ratingstar);
            Console.ResetColor();
            Console.WriteLine("");

            Console.WriteLine("Type: " + kind);

            Console.WriteLine("Duration: " + duration);
            Console.WriteLine("");

            Console.WriteLine("Details: " + details);
            input = Console.ReadKey();
        }

        public void type(string i)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("            " + i);
            Console.ResetColor();
            getratingstar(rate);
            Console.WriteLine("Rating: " + ratingstar);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Type:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" " + kind);
            Console.ResetColor();

            Console.WriteLine("Duration: " + duration);
            Console.WriteLine("");

            Console.WriteLine("Details: " + details);
            input = Console.ReadKey();
        }
    }
}
