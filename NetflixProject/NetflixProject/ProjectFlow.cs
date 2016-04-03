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
        private List<string> title = new List<string>();
        private string newtitle = null;
        
        

        public void flowstart()
        {
            title.Add("Movie");
            title.Add("Show");
            title.Add("Romance");
            title.Add("Comedy");
            title.Add("Action");
            title.Add("All");
            string romance = title[2];
            string comedy = title[3];
            string action = title[4];
            addtitles(ref romance, ref comedy, out newtitle);
            title.Add(newtitle);
            addtitles(ref romance, ref action, out newtitle);
            title.Add(newtitle);
            addtitles(ref action, ref comedy, out newtitle);
            title.Add(newtitle);

            visual.NetflixText();

            view();
            Console.ReadKey();
            Console.Clear();

            genre.genremenu(title);


        }

        private void view()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("            ");
            visual.LeftColored();
            Console.Write("View");
            visual.RightColored();

        }

       private string addtitles(ref string a, ref string b, out string c)
        {
            c = a +" " + b;
            return c;
        }
        //967.75
       
    }
}
