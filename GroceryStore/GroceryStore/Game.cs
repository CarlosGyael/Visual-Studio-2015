using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        News game = new News();
        Items items = new Items();
        CropOptions cropoptions = new CropOptions();
        Instructions instructions = new Instructions();
        Interface user = new Interface();

        public List<int> Items = new List<int>();
        public List<int> shoplist = new List<int>();
        public List<string> croplistname = new List<string>();
        public List<string> applicants = new List<string>();
        public List<int> special = new List<int>();

        public int day = 1;
        string line;
        bool incorrect = true;
        int choice;
        int randnum;
        int randnum2;
        public double money = 500;
        double test;
        int appcount;
        double score;



        public void greeting()
        {

            Console.WriteLine("Hello, and welcome to day 1 of your Grocery Store.");

            time.OneSec();



            while (incorrect)
            {
                Console.WriteLine("Would you like to skip the instructions of the game?");
                user.yesno();

                choice = choice = user.input();
                {

                }


                if (choice == 1)
                {
                    string CurrentTime = Start.ToString();
                    time.stopWatch.Start();
                    randnum = rand.Random(6);
                    foodlist();
                    menu();


                }
                else if (choice == 2)
                {

                    instructions.startinstructions();
                    menu();

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


            }
        }


        public void start()
        {
            while (incorrect)
            {
                Console.WriteLine("Are you ready to start?");
                user.yesno();

                choice = user.input();
                if (choice == 1)
                {

                    string CurrentTime = Start.ToString();
                    time.stopWatch.Start();
                    randnum = rand.Random(6);
                    foodlist();
                    menu();

                }
                else if (choice == 2)
                {

                    break;
                }
                else {
                    Console.WriteLine("Im sorry the options are 1 or 2");

                    time.TwoSec();

                }


            }
        }

        public void foodlist()
        {

            for (int j = 0; j <= 5; j++)
            {
                Items.Add(0);
                shoplist.Add(500);
                special.Add(0);
            }

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

                    Console.WriteLine(croplistname[j] + ": " + shoplist[j]);

                }
            }
            Console.WriteLine("Would you like to buy anything?");
            user.yesno();

            choice = user.input();

            if (choice == 1)
            {
                if (money == 0)
                {
                    Console.WriteLine("you dont have any money!");
                    menu();
                }
                Console.WriteLine("what product would you like to buy?");
                for (int j = 0; j < croplistname.Count; j++)
                {
                    Console.WriteLine(j + 1 + ". " + croplistname[j]);

                }

                choice = user.input();


                if (choice == 1 && game.keepnum == 1)
                {
                    cornspecial();

                }
                else if (choice == 2 && game.keepnum == 2)
                {
                    potatoespecial();


                }
                else if (choice == 3 && game.keepnum == 3)
                {
                    flourspecial();
                }
                else if (choice == 4 && game.keepnum == 4)
                {
                    tomatoespecial();
                }
                else if (choice == 5 && game.keepnum == 5)
                {
                    lettucespecial();
                }
                else if (choice == 6 && game.keepnum == 6)
                {
                    beansspecial();
                }
                else if (choice == 1)
                {
                    corn();
                }
                else if (choice == 2)
                {
                    potatoe();

                }
                else if (choice == 3)
                {
                    flour();

                }
                else if (choice == 4)
                {
                    tomatoe();
                }
                else if (choice == 5)
                {
                    lettuce();

                }
                else if (choice == 6)
                {
                    beans();
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

                Console.WriteLine("");

                Console.WriteLine("Grocery Store Menu");
                Console.WriteLine("------------------");
                Console.WriteLine("Day:  {1}                                          Money:  ${0}", money, day);
                time.stopWatch.Stop();
                Console.Write("Time: ");
                time.elapsed();
                time.stopWatch.Start();
                Console.WriteLine("News: ");
                game.news(randnum);

                Console.WriteLine("");
                Console.WriteLine("1. Start day");
                Console.WriteLine("2. Buy crops");
                Console.WriteLine("3. My crops");
                Console.WriteLine("4. Look at applications");
                Console.WriteLine("5. Start over");

                if (day == 10)
                {
                    Console.WriteLine("This is your last day!");
                }

                choice = user.input();

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
                    viewapplication();
                }
                else if (choice == 5)
                {
                    Over();
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
                for (int j = 0; j < Items.Count; j++)
                {

                    test = rand.normal(0);

                    if (test > 55 && Items[j] > 0)
                    {
                        if (special[j] == game.keepnum)
                        {
                            test = Items[j] * 3 * 3;
                        }
                        else {
                            test = Items[j] * 3;
                        }
                    }
                    else if (appcount > 0 && test > 55)
                    {
                        if (special[j] == game.keepnum)
                        {
                            test = Items[j] * 3 * (appcount / 2) * 3;
                        }
                        else {
                            test = Items[j] * 3 * (appcount / 2);
                        }

                    }
                    else if (appcount > 0 && test < 55)
                    {
                        if (special[j] == game.keepnum)
                        {
                            test = Items[j] * 1 * (appcount / 2) * 3;
                        }
                        else {
                            test = Items[j] * 1 * (appcount / 2);
                        }

                    }
                    else
                    {
                        if (special[j] == game.keepnum)
                        {
                            test = Items[j] * 1 * 3;
                        }
                        else {
                            test = Items[j] * 1;
                        }

                    }

                    Console.WriteLine(croplistname[j] + " made: $" + test);
                    money += test;
                }


            }

            time.OneSec();
            Console.WriteLine("your crops have gone to waste for the next day!");
            time.OneSec();

            randnum = rand.Random(6);

            application();

            for (int j = 0; j < Items.Count; j++)
            {
                Items[j] = 0;
                shoplist[j] = 500;
                special[j] = 0;
            }

            if (day == 10)
            {
                Over();
            }

            day += 1;
            menu();
        }

        public void Over()
        {
            time.stopWatch.Stop();
            Console.WriteLine("Game over!");
            if (money >= 500)
            {
                Console.WriteLine("Your store made: " + (money - 500));
                time.OneSec();
                Console.WriteLine("Your time: ");
                time.elapsed();
                HighScore();
                time.TwoSec();
            }
            else if (money <= 500)
            {
                Console.WriteLine("Your store ended up " + (money - 500) + " in debt!");
                time.OneSec();
                Console.WriteLine("Your time: ");
                time.elapsed();
                time.TwoSec();

                HighScore();
            }
        }

        public int application()
        {
            randnum2 = rand.Random(2);
            if (randnum2 == 2)
            {

                randomname();
                time.OneSec();
                Console.WriteLine("You got a application!");
                time.TwoSec();

            }
            return randnum2;
        }

        public void randomname()
        {
            randnum2 = rand.Random(10);
            switch (randnum2)
            {
                case 1:
                    applicants.Add("Steve");
                    break;
                case 2:
                    applicants.Add("Wanda");
                    break;
                case 3:
                    applicants.Add("Carlos");
                    break;
                case 4:
                    applicants.Add("Tony");
                    break;
                case 5:
                    applicants.Add("Samantha");
                    break;
                case 6:
                    applicants.Add("Adam");
                    break;
                case 7:
                    applicants.Add("Andrew");
                    break;
                case 8:
                    applicants.Add("Lion");
                    break;
                case 9:
                    applicants.Add("Penguin");
                    break;
                case 10:
                    applicants.Add("Fillip");
                    break;
            }
        }

        public void viewapplication()
        {

            Console.WriteLine("List");
            Console.WriteLine("-----------------");
            for (int j = 0; j < applicants.Count; j++)
            {
                Console.WriteLine(applicants[j]);
                appcount = j;

            }
            time.OneSec();
            if (applicants.Count == 0)
            {
                menu();
            }
            Console.WriteLine("Would you like to hire someone?");
            user.yesno();

            choice = user.input();

            if (choice == 1)
            {

                Console.WriteLine("who would you like to hire?");
                Console.WriteLine("");
                for (int j = 0; j < applicants.Count; j++)
                {
                    int i = 1;
                    Console.WriteLine(i + ". " + applicants[j]);
                    i++;
                }
                choice = user.input();

                applicants.Remove(applicants[choice - 1]);
                Console.WriteLine("Applicant hired! you will now make more money");


                menu();
            }
            else if (choice == 2)
            {
                menu();
            }


        }
        public void HighScore()
        {
            double recordedtime = time.stopWatch.Elapsed.TotalMilliseconds;
            score = recordedtime - money;
            Console.WriteLine("Your high score is: " + score);


            namechecker();



            greeting();
        }

        
        public void namechecker()
        {
            Console.WriteLine("Please enter your name: ");

            line = Console.ReadLine();

System.IO.StreamWriter file = new System.IO.StreamWriter("HighScores.txt", true);
            file.Close();

            string[] scorearray = File.ReadAllLines("HighScores.txt");



            foreach (string array in scorearray)
            {
                var vals = array.Split(':')[0];
                if (vals == line)
                {
                    Console.WriteLine("Name already exist!");
                    file.Close();
                    namechecker();
                    
                }
            }

            System.IO.StreamWriter add = new System.IO.StreamWriter("HighScores.txt", true);
            
            add.WriteLine(line + ":" + score);
           add.Close();
            string[] scorearray2 = File.ReadAllLines("HighScores.txt");

            var orderedScores = scorearray2.OrderByDescending(x => double.Parse(x.Split(':')[1]));

            Console.WriteLine("HighScore List");
            Console.WriteLine("--------------------");
            int i = 1;
            foreach (var finalscore in orderedScores)
            {

                Console.WriteLine(i + ". " + finalscore);

                i++;
            }
            time.OneSec();
            Console.WriteLine("");
            file.Close();
        }

        public void cornspecial()
        {
            Console.Write("corn");
            user.givecropname();
            Console.WriteLine(money);
            cropoptions.valueable();

            choice = user.input();
            if (choice == 1)
            {
                if (money < 200 || shoplist[0] < 50)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[0] -= 50;
                money -= 200;
                Items[0] += 50;
                special[0] += 1;
            }
            else if (choice == 2)
            {
                if (money < 400 || shoplist[0] < 100)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[0] -= 100;
                money -= 400;
                Items[0] += 100;
                special[0] += 1;
            }
            else if (choice == 3)
            {
                if (money < 750 || shoplist[0] < 200)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[0] -= 200;
                money -= 700;
                Items[0] += 200;
                special[0] += 1;
            }
            else if (choice == 4)
            {
                if (money < 900 || shoplist[0] < 400)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[0] -= 400;
                money -= 900;
                Items[0] += 400;
                special[0] += 1;
            }
            else if (choice == 5)
            {
                if (money < 1000 || shoplist[0] < 500)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[0] -= 500;
                money -= 1000;
                Items[0] += 500;
                special[0] += 1;
            }
        }

        public void potatoespecial()
        {
            Console.Write("Potatoe");
            user.givecropname();
            Console.WriteLine(money);
            cropoptions.valueable();
            choice = user.input();

            if (choice == 1)
            {
                if (money < 200 || shoplist[1] < 50)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[1] -= 50;
                money -= 200;
                Items[1] += 50;
                special[1] += 2;
            }
            else if (choice == 2)
            {
                if (money < 400 || shoplist[1] < 100)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[1] -= 100;
                money -= 400;
                Items[1] += 100;
                special[1] += 2;
            }
            else if (choice == 3)
            {
                if (money < 750 || shoplist[1] < 200)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[1] -= 200;
                money -= 700;
                Items[1] += 200;
                special[1] += 2;
            }
            else if (choice == 4)
            {
                if (money < 900 || shoplist[1] < 400)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[1] -= 400;
                money -= 900;
                Items[1] += 400;
                special[1] += 2;
            }
            else if (choice == 5)
            {
                if (money < 1000 || shoplist[1] < 500)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[1] -= 500;
                money -= 1000;
                Items[1] += 500;
                special[1] += 2;
            }
        }


        public void flourspecial()
        {
            Console.Write("Flour");
            user.givecropname();
            Console.WriteLine(money);
            cropoptions.valueable();
            choice = user.input();
            if (choice == 1)
            {
                if (money < 200 || shoplist[2] < 50)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[2] -= 50;
                money -= 200;
                Items[2] += 50;
                special[2] += 3;
            }
            else if (choice == 2)
            {
                if (money < 400 || shoplist[2] < 100)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[2] -= 100;
                money -= 400;
                Items[2] += 100;
                special[2] += 3;
            }
            else if (choice == 3)
            {
                if (money < 750 || shoplist[2] < 200)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[2] -= 200;
                money -= 700;
                Items[2] += 200;
                special[2] += 3;
            }
            else if (choice == 4)
            {
                if (money < 900 || shoplist[2] < 400)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[2] -= 400;
                money -= 900;
                Items[2] += 400;
                special[2] += 3;
            }
            else if (choice == 5)
            {
                if (money < 1000 || shoplist[2] < 500)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[2] -= 500;
                money -= 1000;
                Items[2] += 50;
                special[2] += 3;
            }
        }


        public void tomatoespecial()
        {
            Console.Write("Tomatoes");
            user.givecropname();
            Console.WriteLine(money);
            cropoptions.valueable();
            choice = user.input();

            if (choice == 1)
            {
                if (money < 200 || shoplist[3] < 50)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[3] -= 50;
                money -= 200;
                Items[3] += 50;
                special[3] += 4;
            }
            else if (choice == 2)
            {
                if (money < 400 || shoplist[3] < 100)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[3] -= 100;
                money -= 400;
                Items[3] += 100;
                special[3] += 4;
            }
            else if (choice == 3)
            {
                if (money < 750 || shoplist[3] < 200)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[3] -= 200;
                money -= 700;
                Items[3] += 200;
                special[3] += 4;
            }
            else if (choice == 4)
            {
                if (money < 900 || shoplist[3] < 400)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[3] -= 400;
                Items[3] += 400;
                money -= 900;
                special[3] += 4;
            }
            else if (choice == 5)
            {
                if (money < 1000 || shoplist[3] < 500)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[3] -= 500;
                money -= 1000;
                Items[3] += 500;
                special[3] += 4;
            }
        }

        public void lettucespecial()
        {
            Console.Write("lettuce");
            user.givecropname();
            Console.WriteLine(money);
            cropoptions.valueable();
            choice = user.input();
            if (choice == 1)
            {
                if (money < 200 || shoplist[4] < 50)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[4] -= 50;
                money -= 200;
                Items[4] += 50;
                special[4] += 5;
            }
            else if (choice == 2)
            {
                if (money < 400 || shoplist[4] < 100)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[4] -= 100;
                money -= 400;
                Items[4] += 100;
                special[4] += 5;
            }
            else if (choice == 3)
            {
                if (money < 750 || shoplist[4] < 200)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[4] -= 200;
                money -= 700;
                Items[4] += 200;
                special[4] += 5;
            }
            else if (choice == 4)
            {
                if (money < 900 || shoplist[4] < 400)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[4] -= 400;
                money -= 900;
                Items[4] += 400;
                special[4] += 5;
            }
            else if (choice == 5)
            {
                if (money < 1000 || shoplist[4] < 500)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[4] -= 500;
                money -= 1000;
                Items[4] += 500;
                special[4] += 5;
            }
        }

        public void beansspecial()
        {
            Console.Write("beans");
            user.givecropname();
            Console.WriteLine(money);
            cropoptions.valueable();
            choice = user.input();
            if (choice == 1)
            {
                if (money < 200 || shoplist[5] < 50)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[5] -= 50;
                money -= 200;
                Items[5] += 50;
                special[5] += 6;
            }
            else if (choice == 2)
            {
                if (money < 400 || shoplist[4] < 100)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[5] -= 100;
                money -= 400;
                Items[5] += 100;
                special[5] += 6;
            }
            else if (choice == 3)
            {
                if (money < 750 || shoplist[4] < 200)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[5] -= 200;
                money -= 700;
                Items[5] += 200;
                special[5] += 6;
            }
            else if (choice == 4)
            {
                if (money < 900 || shoplist[4] < 400)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[5] -= 400;
                money -= 900;
                Items[5] += 400;
                special[5] += 6;
            }
            else if (choice == 5)
            {
                if (money < 1000 || shoplist[4] < 500)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[5] -= 500;
                money -= 1000;
                Items[5] += 500;
                special[5] += 6;
            }
        }

        public void corn()
        {
            Console.Write("corn");
            user.givecropname();
            Console.WriteLine(money);
            cropoptions.normal();
            choice = user.input();
            if (choice == 1)
            {
                if (money < 100 || shoplist[0] < 50)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[0] -= 50;
                money -= 100;
                Items[0] += 50;
            }
            else if (choice == 2)
            {
                if (money < 150 || shoplist[0] < 100)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[0] -= 100;
                money -= 150;
                Items[0] += 100;
            }
            else if (choice == 3)
            {
                if (money < 250 || shoplist[0] < 200)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[0] -= 200;
                money -= 250;
                Items[0] += 200;
            }
            else if (choice == 4)
            {
                if (money < 450 || shoplist[0] < 400)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[0] -= 400;
                money -= 450;
                Items[0] += 400;
            }
            else if (choice == 5)
            {
                if (money < 550 || shoplist[0] < 500)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[0] -= 500;
                money -= 550;
                Items[0] += 500;
            }
        }

        public void potatoe()
        {
            Console.Write("potatoe");
            user.givecropname();
            Console.WriteLine(money);
            cropoptions.normal();
            choice = user.input();
            if (choice == 1)
            {
                if (money < 100 || shoplist[1] < 50)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[1] -= 50;
                money -= 100;
                Items[1] += 50;
            }
            else if (choice == 2)
            {
                if (money < 150 || shoplist[1] < 100)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[1] -= 100;
                money -= 150;
                Items[1] += 100;
            }
            else if (choice == 3)
            {
                if (money < 250 || shoplist[1] < 200)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[1] -= 200;
                money -= 250;
                Items[1] += 200;
            }
            else if (choice == 4)
            {
                if (money < 450 || shoplist[1] < 400)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[1] -= 400;
                money -= 450;
                Items[1] += 400;
            }
            else if (choice == 5)
            {
                if (money < 550 || shoplist[1] < 500)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[1] -= 500;
                money -= 550;
                Items[1] += 500;
            }
        }

        public void flour()
        {
            Console.Write("flour");
            user.givecropname();
            Console.WriteLine(money);
            cropoptions.normal();
            choice = user.input();

            if (choice == 1)
            {
                if (money < 100 || shoplist[2] < 50)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[2] -= 50;
                money -= 100;
                Items[2] += 50;

            }
            else if (choice == 2 || shoplist[2] < 100)
            {
                if (money < 150)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[2] -= 100;
                money -= 150;
                Items[2] += 100;
            }
            else if (choice == 3 || shoplist[2] < 200)
            {
                if (money < 250)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[2] -= 200;
                money -= 250;
                Items[2] += 200;
            }
            else if (choice == 4)
            {
                if (money < 450 || shoplist[2] < 400)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[2] -= 400;
                money -= 450;
                Items[2] += 400;
            }
            else if (choice == 5)
            {
                if (money < 550 || shoplist[2] < 500)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[2] -= 500;
                money -= 550;
                Items[2] += 500;
            }
        }

        public void tomatoe()
        {
            Console.Write("tomatoe");
            user.givecropname();
            Console.WriteLine(money);
            cropoptions.normal();
            choice = user.input();
            if (choice == 1)
            {
                if (money < 100 || shoplist[3] < 50)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[3] -= 50;
                money -= 100;
                Items[3] += 50;
            }
            else if (choice == 2)
            {
                if (money < 150 || shoplist[3] < 100)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[3] -= 100;
                money -= 150;
                Items[3] += 100;
            }
            else if (choice == 3)
            {
                if (money < 250 || shoplist[3] < 200)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[3] -= 200;
                money -= 250;
                Items[3] += 200;
            }
            else if (choice == 4)
            {
                if (money < 450 || shoplist[3] < 400)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[3] -= 400;
                money -= 450;
                Items[3] += 400;
            }
            else if (choice == 5)
            {
                if (money < 550 || shoplist[3] < 500)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[3] -= 500;
                money -= 550;
                Items[3] += 500;
            }

        }

        public void lettuce()
        {
            Console.Write("lettuce");
            user.givecropname();
            Console.WriteLine(money);
            cropoptions.normal();
            choice = user.input();
            if (choice == 1)
            {
                if (money < 100 || shoplist[4] < 50)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[4] -= 50;
                money -= 100;
                Items[4] += 50;
            }
            else if (choice == 2)
            {
                if (money < 150 || shoplist[4] < 100)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[4] -= 100;
                money -= 150;
                Items[4] += 100;
            }
            else if (choice == 3)
            {
                if (money < 250 || shoplist[4] < 200)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[4] -= 200;
                money -= 250;
                Items[4] += 200;
            }
            else if (choice == 4)
            {
                if (money < 450 || shoplist[4] < 400)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[4] -= 400;
                money -= 450;
                Items[4] += 400;
            }
            else if (choice == 5)
            {
                if (money < 550 || shoplist[4] < 500)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[4] -= 500;
                money -= 550;
                Items[4] += 500;
            }
        }
        public void beans()
        {
            Console.Write("beans");
            user.givecropname();
            Console.WriteLine(money);
            cropoptions.normal();
            choice = user.input();
            if (choice == 1)
            {
                if (money < 100)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[5] -= 50;
                money -= 100;
                Items[5] += 50;

            }
            else if (choice == 2)
            {
                if (money < 150)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[5] -= 100;
                money -= 150;
                Items[5] += 100;
            }
            else if (choice == 3)
            {
                if (money < 250)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[5] -= 200;
                money -= 250;
                Items[5] += 200;
            }
            else if (choice == 4)
            {
                if (money < 450)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[5] -= 400;
                money -= 450;
                Items[5] += 400;
            }
            else if (choice == 5)
            {
                if (money < 550)
                {
                    user.outofstock();
                    menu();
                }
                shoplist[5] -= 500;
                money -= 550;
                Items[5] += 500;
            }

        }
    }
}
