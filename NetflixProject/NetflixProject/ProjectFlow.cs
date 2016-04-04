using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class ProjectFlow
    {
        private Visual visual = new Visual();
        Genre genre = new Genre();
        
        

        public void flowstart()
        {
            visual.NetflixText();

            view();
            Console.ReadKey();
            Console.Clear();
            genre.genremenu();


        }

        private void view()
        {
            Console.WriteLine("netflix menu");
            visual.LeftColored();
            Console.Write("View");
            visual.RightColored();
            Console.WriteLine("");
            Console.WriteLine("press anything to enter");

        }

       
       
    }
}
