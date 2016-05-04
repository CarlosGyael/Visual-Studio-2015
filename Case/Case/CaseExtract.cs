using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case
{
    class CaseExtract
    {

        string list;
        public void run()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("Case.txt", true);
            file.Close();

            string[] scorearray = File.ReadAllLines("Case.txt");


            foreach (string line in scorearray)
            {

                if (line.Contains("::"))
                {
                    list = list +" " +line;
                    file.Close();

                }
            }

            System.IO.StreamWriter add = new System.IO.StreamWriter("newCase.txt", true);

            
                add.WriteLine(list);
            

            add.Close();
        }
    }
}
