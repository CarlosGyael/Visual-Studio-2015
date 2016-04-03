using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Genre
    {

        ConsoleKeyInfo input;
        Visual visual = new Visual();

        public void genremenu(List<string> a)
        {
            foreach (string i in viewmenu(a))
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
                Console.Clear();
            }
        }

        private IEnumerable viewmenu(List<string> a)
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
