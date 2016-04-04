using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Comedy
    {
        private List<string> list = new List<string>();

        private ConsoleKeyInfo input;

        private Visual visual = new Visual();
        Shows show = new Shows();

        public void menu()
        {
            additems();
            foreach (string i in viewmenu(list))
            {
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

                    break;
                }
                else if (input.Key == ConsoleKey.Enter && i == "SpongeBob")
                {
                    show.inputchange(i);
                }
                else if (input.Key == ConsoleKey.Enter && i == "FamilyGuy")
                {
                    show.inputchange(i);
                }
                else if (input.Key == ConsoleKey.Enter && i == "Pokemon")
                {
                    show.inputchange(i);
                }

                Console.Clear();
            }

        }

        public void additems()
        {
            list.Add("Bad Boys");
            list.Add("FamilyGuy");
            list.Add("SpongeBob");
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
