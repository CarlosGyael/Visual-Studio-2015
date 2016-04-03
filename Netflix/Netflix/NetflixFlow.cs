using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class NetflixFlow
    {
        Visual visual = new Visual();
        Menu menu = new Menu();
        Movie movie = new Movie();

        int turn;
        public void flow()
        {
            if (turn == 1) {
                menu.ScrollDesign();
            }
            
            visual.NetflixText();
            menu.startmenu();
            turn += 1;
        }



    }
}
