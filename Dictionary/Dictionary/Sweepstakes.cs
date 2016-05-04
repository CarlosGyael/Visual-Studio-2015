using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Sweepstakes
    {
        Dictionary<int , object> items = new Dictionary<int, object>();
        public string EventName;
        public string value;
        public Sweepstakes(string name)
        {
            EventName = name;
        }
        void RegisterContestant(Contestant contestant)
        {
            items.Add(0, new Contestant("carlos"));
            items.Add(1, new Contestant("adam"));
            items.Add(2, new Contestant("foo"));
            items.Add(3, new Contestant("christopher"));
        }
        string PickWinner()
        {
            Random rand = new Random();
            
            object getobject;

            items.TryGetValue(rand.Next(0, 3), out getobject);
            value = getobject.ToString();
            return value;
            
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
