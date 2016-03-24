using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    class samestring
    {

        public void userinput()
        {

            List<string> list = new List<string>();
            List<string> list2 = new List<string>();

            bool run = true;
            string input;

            while (run)
            {
                Console.WriteLine("Enter a word");

                input = Console.ReadLine();

                list.Add(input);

                for (int i = 0; list.Count > 0; i++)
                {

                    if (list2.Contains(input))
                    {
                        Console.WriteLine("Bark!");
                        list.Remove(list[0]);
                        break;
                    }
                    else {
                        Console.WriteLine("accepted!");
                    }
                    
                    list2.Add(input);
                    list.Remove(list[0]);
                }



            }



        }
    }
}
