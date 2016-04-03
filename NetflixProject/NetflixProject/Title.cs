using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    abstract class Title
    {
        protected string title;
        protected int rate;
        
        protected string settitle(string i)
        {
            title = i;
            return this.title;
        }

        protected int rating(int i)
        {
            rate = i;
            return this.rate;
        }

        

    }
}
