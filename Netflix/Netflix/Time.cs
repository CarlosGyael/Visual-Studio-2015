using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Netflix
{
    class Time
    {


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
      
    }
}
