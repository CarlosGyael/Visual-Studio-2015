using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Romance
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
                if (input.Key == ConsoleKey.Enter )
                {
                    break;
                }
                

                Console.Clear();
            }

        }

        public void additems()
        {
            list.Add("no romantic movies");
           
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
