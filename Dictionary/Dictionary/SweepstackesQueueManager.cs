﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class SweepstackesQueueManager : ISweepstakesManager
    {
        public string winner;
        public Sweepstakes GetNextSweepstakesWinner()
        {
            Sweepstakes sweepstakes = new Sweepstakes("Color");
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakes = new Sweepstakes("Best Color");
            winner = sweepstakes.value;
        }
    }
}
