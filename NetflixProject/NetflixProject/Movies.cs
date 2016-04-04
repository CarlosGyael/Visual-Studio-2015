using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Movies
    {
        Visual visual = new Visual();
        private ConsoleKeyInfo input;
        bool? back = null;

        private string[] title = new string[] { "Lion King", "Captain America", "Bad Boys" };

        public void moviemenu()
        {
            for (int j = 0; j < 1; j--)
            {
                foreach (string i in movielist())
                {
                    Console.WriteLine("movie menu");
                    visual.left();
                    Console.Write(i);
                    visual.RightColored();
                    input = Console.ReadKey();
                    if (input.Key == ConsoleKey.Enter && i == "Lion King")
                    {
                        LionKing lion = new LionKing();
                        lion.details();
                    }
                    else if (input.Key == ConsoleKey.Enter && i == "Captain America")
                    {
                        CaptainAmerica ameica = new CaptainAmerica();
                        ameica.details();
           
                    }
                    else if (input.Key == ConsoleKey.Enter && i == "Bad Boys")
                    {
                        BadBoys boys = new BadBoys();
                        boys.details();
                    }
                    else if (input.Key == ConsoleKey.Backspace)
                    {

                        back = true;
                        break;
                    }
                    Console.Clear();

                }
                if (back == true)
                {
                    break;
                }
            }
        }

        private IEnumerable movielist()
        {
            foreach (string i in title)
            {

                yield return i;
            }

        }


    }
}
