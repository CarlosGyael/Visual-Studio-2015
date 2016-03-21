using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Assignment
{
    class main
    {
        public main()
        {
            
        }
        bool binary;
        



        public List<bool> list = new List<bool>();

        public bool toBoolean(int anynum)
        {

            while (anynum > 0 || anynum > 1)
            {

                int mod = anynum % 2;
                anynum = anynum / 2;

                if (mod == 0)
                {

                    list.Add(false);

                }
                else if (mod == 1)
                {

                    list.Add(true);

                }


            }
            return binary;
        }

        public void Add()
        {
            
            string answer = String.Join("", list);
            Console.WriteLine(answer);
        }
       /* public int binaryToInteger()
        {

            toBoolean(newlist);
            return newlist;

            string answer = String.Join("", list);
        }
        */
     
        

    }
}
