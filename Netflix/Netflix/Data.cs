using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    abstract class Data
    {
        

        public string duration { get; set; }

        public string ratingstar;


        public string getratingstar(int rating)
        {
            if (rating == 0)
            {
                ratingstar = "";
                
            }
            else if (rating == 1) {
                ratingstar = "*";
            }
            else if (rating == 2)
            {
                ratingstar = "**";
            }
            else if (rating == 3)
            {
                ratingstar = "***";
            }
            else if (rating == 4)
            {
                ratingstar = "****";
            }
            else if (rating == 5)
            {
                ratingstar = "*****";
            }
            return this.ratingstar;
        }

        public string getduration(string i)
        {
            i = duration;
            return this.duration;
        }
        int rate;
        
        public int changerate
        {
            get
            {
                return this.rate;
            }
            set
            {
                this.rate = value;
            }
        }
    }
}
