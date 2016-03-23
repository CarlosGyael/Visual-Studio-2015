using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryStore
{
    class Time
    {

        public Stopwatch stopWatch = new Stopwatch();


        public void OneSec()
        {
            Thread.Sleep(1000);
        }
        public void TwoSec()
        {
            Thread.Sleep(2000);
        }
        public void FiveSec()
        {
            Thread.Sleep(5000);
        }
        public void elapsed()
        {
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                             ts.Minutes, ts.Seconds,
                            ts.Milliseconds / 10);
            Console.WriteLine(elapsedTime);

        }
    }
}
