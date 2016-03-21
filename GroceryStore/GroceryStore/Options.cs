using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryStore
{
    class Options
    {

        Time time = new Time();
        TimeSpan Start = new TimeSpan(0, 0, 0);
        RandomInt rand = new RandomInt();
        GameOver GameOver = new GameOver();
        Game game = new Game();
        Items items = new Items();
        CropOptions cropoptions = new CropOptions();
        Instructions instructions = new Instructions();
        private int day = 1;

        public List<int> Items = new List<int>();
        public List<int> shoplist = new List<int>();
        public List<string> croplistname = new List<string>();

        public int Money = 500;
        string line;
        bool incorrect = true;
        int secondchoice;
        int randnum;
        string cropname;
       




        public void greeting()
        {

            Console.WriteLine("Hello, and welcome to day 1 of your Grocery Store.");

            time.OneSec();

            while (incorrect)
            {
                Console.WriteLine("Would you like to skip the instructions of the game?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                string CurrentTime = Start.ToString();
                time.stopWatch.Start();
                randnum = rand.Random(6);
                foodlist();

                string line = Console.ReadLine();

                int choice;

                bool res = int.TryParse(line, out choice);
                if (res == false)
                {
                    Console.WriteLine("{0} is not an integer", line);
                    incorrect = false;
                }
                else if (res == true) 
                

                if (choice == 1)
                {
                    menu();
                    

                }
                else if (choice == 2)
                {

                    instructions.startinstructions();
                    
                }
                else if (line == "")
                {
                    Console.WriteLine("please enter something.");
                    incorrect = false;
                }

                else {
                    Console.WriteLine("Im sorry the options are 1 or 2");

                    time.TwoSec();
                        incorrect = false;
                }

                incorrect = true;
            }
        }


        public void start()
        {
            while (incorrect)
            {
                Console.WriteLine("Are you ready to start?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                string line = Console.ReadLine();

                int choice;

                bool res = int.TryParse(line, out choice);
                if (res == false)
                {
                    Console.WriteLine("{0} is not an integer", line);
                    incorrect = false;
                }
                else if (res == true)

                    if (choice == 1)
                {


                    menu();
                    incorrect = true;
                }
                else if (choice == 2)
                {

                    break;
                }
                else {
                    Console.WriteLine("Im sorry the options are 1 or 2");

                    time.TwoSec();

                }

                incorrect = true;
            }
        }

        public void foodlist()
        {
            Items.Add(0);
            Items.Add(0);
            Items.Add(0);
            Items.Add(0);
            Items.Add(0);
            Items.Add(0);

            shoplist.Add(500);
            shoplist.Add(500);
            shoplist.Add(500);
            shoplist.Add(500);
            shoplist.Add(500);
            shoplist.Add(500);

            croplistname.Add("corn");
            croplistname.Add("potatoes");
            croplistname.Add("flour");
            croplistname.Add("tomatoes");
            croplistname.Add("lettuce");
            croplistname.Add("beans");


        }

        public void shop()
        {

            Console.WriteLine(" Crop     Amount");
            Console.WriteLine("------------------");
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < croplistname.Count; j++)
                {

                    Console.WriteLine(croplistname[j] + ": " + shoplist[i]);

                }
            }
            Console.WriteLine("Would you like to buy anything?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

             line = Console.ReadLine();

            int choice;

            bool res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);
                
            }
            else if (res == true)

                if (choice == 1)
            {
                Console.WriteLine("what product would you like to buy?");
                for (int j = 0; j < croplistname.Count; j++)
                {
                    Console.WriteLine(j + 1 + ". " + croplistname[j]);

                }

                line = Console.ReadLine();

                secondchoice = Int32.Parse(line);

                    if (secondchoice == 1 && game.keepnum == 1)
                    {
                        cropname = "corn";
                        Console.WriteLine("{0} value is now high due to the news", cropname);
                        Console.WriteLine("how much {0} do you want to buy?                      my money: {1}", cropname, Money);
                        cropoptions.valueable();
                        line = Console.ReadLine();



                        res = int.TryParse(line, out choice);
                        if (res == false)
                        {
                            Console.WriteLine("{0} is not an integer", line);

                        }
                        else if (res == true)
                            game.cornspec();
                    }
                    else if (secondchoice == 2 && game.keepnum == 2)
                    {
                        cropname = "potatoe";
                        Console.WriteLine("{0} value is now high due to the news", cropname);
                        Console.WriteLine("how much {0} do you want to buy?                      my money: {1}", cropname, Money);
                        cropoptions.valueable();
                        line = Console.ReadLine();



                        res = int.TryParse(line, out choice);
                        if (res == false)
                        {
                            Console.WriteLine("{0} is not an integer", line);

                        }
                        else if (res == true)
                            game.potatoespec();
                    }
                    else if (secondchoice == 3 && game.keepnum == 3)
                    {
                        cropname = "flour";
                        Console.WriteLine("{0} value is now high due to the news", cropname);
                        Console.WriteLine("how much {0} do you want to buy?                      my money: {1}", cropname, Money);
                        cropoptions.valueable();
                        line = Console.ReadLine();



                        res = int.TryParse(line, out choice);
                        if (res == false)
                        {
                            Console.WriteLine("{0} is not an integer", line);

                        }
                        else if (res == true)
                            game.specflour(); 
                    }
                    else if (secondchoice == 4 && game.keepnum == 4)
                    {
                        cropname = "tomatoes";
                        Console.WriteLine("{0} value is now high due to the news", cropname);
                        Console.WriteLine("how much {0} do you want to buy?                      my money: {1}", cropname, Money);
                        cropoptions.valueable();
                        line = Console.ReadLine();



                        res = int.TryParse(line, out choice);
                        if (res == false)
                        {
                            Console.WriteLine("{0} is not an integer", line);

                        }
                        else if (res == true)

                            game.tomatoesspec();
                    }
                    else if (secondchoice == 5 && game.keepnum == 5)
                    {
                        cropname = "lettuce";
                        Console.WriteLine("{0} value is now high due to the news", cropname);
                        Console.WriteLine("how much {0} do you want to buy?                      my money: {1}", cropname, Money);
                        cropoptions.valueable();
                        line = Console.ReadLine();



                        res = int.TryParse(line, out choice);
                        if (res == false)
                        {
                            Console.WriteLine("{0} is not an integer", line);

                        }
                        else if (res == true)
                            game.lettucespec();
                    }
                    else if (secondchoice == 6 && game.keepnum == 6)
                    {
                        cropname = "beans";
                        Console.WriteLine("{0} value is now high due to the news", cropname);
                        Console.WriteLine("how much {0} do you want to buy?                      my money: {1}", cropname, Money);
                        cropoptions.valueable();
                        line = Console.ReadLine();



                        res = int.TryParse(line, out choice);
                        if (res == false)
                        {
                            Console.WriteLine("{0} is not an integer", line);

                        }
                        else if (res == true)
                            game.specbeans();
                    }
                    else if (secondchoice == 1)
                    {
                        cropname = "corn";

                        Console.WriteLine("how much {0} do you want to buy?                      my money: {1}", cropname, Money);
                        cropoptions.normal();
                        line = Console.ReadLine();



                        res = int.TryParse(line, out choice);
                        if (res == false)
                        {
                            Console.WriteLine("{0} is not an integer", line);

                        }
                        else if (res == true)
                            cropoptions.corn();
                    }
                    else if (secondchoice == 2)
                    {
                        cropname = "potatoe";

                        Console.WriteLine("how much {0} do you want to buy?                      my money: {1}", cropname, Money);
                        cropoptions.normal();
                        line = Console.ReadLine();



                        res = int.TryParse(line, out choice);
                        if (res == false)
                        {
                            Console.WriteLine("{0} is not an integer", line);

                        }
                        else if (res == true)
                            cropoptions.potatoe();

                    }
                    else if (secondchoice == 3)
                    {
                        cropname = "flour";

                        Console.WriteLine("how much {0} do you want to buy?                      my money: {1}", cropname, Money);
                        cropoptions.normal();
                        line = Console.ReadLine();



                        res = int.TryParse(line, out choice);
                        if (res == false)
                        {
                            Console.WriteLine("{0} is not an integer", line);

                        }
                        else if (res == true)

                            cropoptions.flour();

                    }
                    else if (secondchoice == 4)
                    {
                        cropname = "tomatoe";

                        Console.WriteLine("how much {0} do you want to buy?                      my money: {1}", cropname, Money);
                        cropoptions.normal();
                        line = Console.ReadLine();



                        res = int.TryParse(line, out choice);
                        if (res == false)
                        {
                            Console.WriteLine("{0} is not an integer", line);

                        }
                        else if (res == true)
                            cropoptions.tomatoe();

                    }
                    else if (secondchoice == 5)
                    {
                        cropname = "lettuce";

                        Console.WriteLine("how much {0} do you want to buy?                      my money: {1}", cropname, Money);
                        cropoptions.normal();
                        line = Console.ReadLine();



                        res = int.TryParse(line, out choice);
                        if (res == false)
                        {
                            Console.WriteLine("{0} is not an integer", line);

                        }
                        else if (res == true)
                            cropoptions.lettuce();

                    }
                    else if (secondchoice == 6)
                    {
                        cropname = "beans";

                        Console.WriteLine("how much {0} do you want to buy?                      my money: {1}", cropname, Money);
                        cropoptions.normal();
                        line = Console.ReadLine();



                        res = int.TryParse(line, out choice);
                        if (res == false)
                        {
                            Console.WriteLine("{0} is not an integer", line);

                        }
                        else if (res == true)
                            cropoptions.beans();

                    }



                        }
                        else if (choice == 2)
                        {
                            menu();
                        }

        }
        public void mycrops()
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < croplistname.Count; j++)
                {
                    Console.WriteLine(croplistname[j] + ": " + Items[j]);

                }


            }

        }

        public void menu()
        {
            while (incorrect)
            {
                Console.WriteLine("..... returning to menu");

                time.TwoSec();

                Console.WriteLine("Grocery Store Menu");
                Console.WriteLine("------------------");
                Console.WriteLine("Day:  {1}                                          Money:  ${0}", Money, day);
                time.stopWatch.Stop();
                Console.WriteLine("Time: ");
                time.elapsed();
                time.stopWatch.Start();
                Console.WriteLine("News: ");
                game.news(randnum);
                randnum = rand.Random(6);
                Console.WriteLine("");
                Console.WriteLine("1. Start day");
                Console.WriteLine("2. Buy crops");
                Console.WriteLine("3. My crops");
                Console.WriteLine("4. Look at applications");
                Console.WriteLine("5. Start over");

                line = Console.ReadLine();

                int choice;

               bool res = int.TryParse(line, out choice);
                if (res == false)
                {
                    Console.WriteLine("{0} is not an integer", line);
                    
                }
                else if (res == true)

                    if (choice == 1)
                {
                    startGame();
                }
                else if (choice == 2)
                {
                    shop();
                }
                else if (choice == 3)
                {
                    mycrops();
                }
                else if (choice == 4)
                {
                }
                else if (choice == 5)
                {
                    GameOver.Over();
                }


            }


        }

        public void startGame()
        {
            Console.WriteLine("Starting Day....");
            time.TwoSec();

            Console.WriteLine("Day : " + day);






            for (int i = 0; i < 1; i++)
            {
                int newMoney = Money;
                for (int j = 0; j < Items.Count; j++)
                {

                    randnum = rand.normal(0);
                    if (randnum > 50 && Items[j] > 0)
                    {
                        randnum = newMoney - 500 * -1 * 2;
                    }
                    else
                    {
                        randnum = 0;
                    }
                    Console.WriteLine(croplistname[j] + " made: " + randnum);
                    Money += randnum;
                }


            }

            Console.WriteLine("your crops have gone to waste for the next day!");
            time.OneSec();

            for (int j = 0; j < Items.Count; j++)
            {
                Items[j] = 0;
                shoplist[j] = 500;

            }

            menu();
            day += 1;
        }



    }
}
