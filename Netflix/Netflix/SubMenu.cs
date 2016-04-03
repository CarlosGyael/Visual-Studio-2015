using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class SubMenu
    {
        Movie movie = new Movie();
        public void choose(string line)
        {
            switch (line)
            {
                case "Movies":
                    movie.startMovies();
                    return;
                case "Show":

                    return;
                case "Romance":

                    return;
                case "Comedy":

                    return;
                case "Adventure":

                    return;
                case "AdventureRomance":

                    return;
                case "ComedyRomance":

                    return;
                //case "":

                //    return;
                //case "":

                //    return;
                //case "":

                //    return;
                    
            }
        }

        

    }
}
