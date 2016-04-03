using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotProgram
{
    class Data
    {

        string[] plotone;
        int x;
        int y;
        int fencelength = 0;
        int fencewidth = 2;
        int keepcount = 0;
        int fencetotal;
        int plot1;
        int plot2;
        int plot3;
        double soilplot1;
        double counttwo;
        double soilplot2;
        double soilplot3;
        int countsoil = 0;

        System.IO.StreamWriter file;

        List<int> list = new List<int>();
        List<int> plotfence = new List<int>();

        public void GeneratingFarm()
        {
            Console.WriteLine("Generating plots..");
            checkplots();
            userplots();
            entirefence();
            plotssoil();

            Console.WriteLine("Finished!");

        }

        public void checkplots()
        {
            file = new System.IO.StreamWriter("1plots.txt", true);
            file = new System.IO.StreamWriter("2plots.txt", true);
            file = new System.IO.StreamWriter("3plots.txt", true);
            file = new System.IO.StreamWriter("4plots.txt", true);
            file = new System.IO.StreamWriter("5plots.txt", true);
            file.Close();
            plotone = File.ReadAllLines("userplots.txt");

        }
        public void userplots()
        {
            System.IO.StreamWriter add = new System.IO.StreamWriter("overlapping_plots.txt", true);


            foreach (string array in plotone)
            {
                for (int i = 0; plotone.Length >= i; i++)
                {

                    string grabnumber = array.Split(',')[i];
                    int number = int.Parse(grabnumber);
                    list.Add(number);

                    if (list.Count == 1 || list.Count == 5 || list.Count == 9)
                    {
                        for (int HowManyTimes = 1; number >= HowManyTimes; HowManyTimes++)
                        {
                            y++;
                            add.WriteLine("");
                        }
                    }
                    else if (list.Count == 2 || list.Count == 6 || list.Count == 10)
                    {
                        for (int HowManyTimes = 1; number >= HowManyTimes; HowManyTimes++)
                        {
                            x++;
                            add.Write(" ");
                        }
                    }
                    else if (list.Count == 3 || list.Count == 7 || list.Count == 11)
                    {

                        add.Write("|");
                        for (int HowManyTimes = 1; number >= HowManyTimes; HowManyTimes++)
                        {
                            fencewidth++;
                            add.Write("-");
                            keepcount++;
                        }
                        add.Write("|");
                    }
                    else if (list.Count == 4 || list.Count == 8 || list.Count == 12)
                    {
                        add.WriteLine("");
                        for (int HowManyTimes = 1; y >= HowManyTimes; HowManyTimes++)
                        {
                            add.Write(" ");
                        }

                        for (int HowManyTimes = 3; number >= HowManyTimes; HowManyTimes++)
                        {
                            fencelength++;
                            add.Write("|");
                            for (int HowManyTimes2 = 1; keepcount >= HowManyTimes2; HowManyTimes2++)
                            {
                                add.Write(" ");
                                countsoil++;
                                
                                
                            }
                            if (HowManyTimes == 3) {counttwo = countsoil*2; }
                            add.Write("|");
                            add.Write("\n");
                            for (int HowManyTimes2 = 1; y >= HowManyTimes2; HowManyTimes2++)
                            {
                                add.Write(" ");
                            }
                        }

                        add.Write("|");
                        for (int HowManyTimes2 = 1; keepcount >= HowManyTimes2; HowManyTimes2++)
                        {

                            add.Write("-");
                        }
                        plotfence.Add(fencewidth + fencelength);
                        add.Write("|");
                        keepcount = 0;

                        if (list.Count == 4) { soilplot1 = (countsoil) + counttwo; plot1 = fencewidth + fencelength; }
                        else if (list.Count == 8) { soilplot2 = (countsoil ) + counttwo; plot2 = fencewidth + fencelength+2; }
                        else if (list.Count == 12) { soilplot3 = (countsoil) + counttwo; plot3 = fencewidth + fencelength+2; }

                        fencelength = 0;
                        fencewidth = 0;
                        countsoil = 0;
                        counttwo = 0;
                        x = 0;
                        y = 0;
                    }
                }
            }
            add.Close();
        }

        public void entirefence() {
            fencetotal = plotfence[0] + plotfence[1] + plotfence[2] + 4;
            System.IO.StreamWriter add = new System.IO.StreamWriter("total_fencing.txt", true);
            add.WriteLine("plot 1 fencing: {0}ft", plot1);
            add.WriteLine("plot 2 fencing: {0}ft", plot2);
            add.WriteLine("plot 3 fencing: {0}ft", plot3);
            add.WriteLine("Total fencing is: {0}ft", fencetotal);
            add.Close();
        }

        public void plotssoil() {
            System.IO.StreamWriter add = new System.IO.StreamWriter("total_fertilizer.txt", true);
            add.WriteLine("plot 1 soil: {0} bottles", soilplot1/2);
            add.WriteLine("plot 2 soil: {0} bottles", soilplot2/2);
            add.WriteLine("plot 3 soil: {0} bottles", soilplot3/2);
            add.Close();
        }





    }
}
