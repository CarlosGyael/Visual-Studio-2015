using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary
    {
        public void Flow()
        {
            SweepstakesStackManager Stack = new SweepstakesStackManager();
            Stack.GetNextSweepstakesWinner();
            Console.WriteLine(Stack.winner);

        }
    }
}
