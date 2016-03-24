using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    class backwardstriangle
    {
        List<string> list = new List<string>();
        public void output()
        {
            list.Add(" ");
            list.Add(" ");
            list.Add(" ");
            list.Add(" ");
            list.Add("*");

            for (int i = 0; list.Count > i; i++)
            {
                Console.WriteLine(list[0]);
                Console.Write(list[1]);
                Console.Write(list[2]);
                Console.Write(list[3]);
                Console.Write(list[4]);

                if (list[0] == "*") {
                    break;
                }

                list.Remove(list[i]);
                list.Add("*");


            }


        }


    }
}
