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
        Game game = new Game();
        Items items = new Items();
        CropOptions cropoptions = new CropOptions();
        Instructions instructions = new Instructions();
        RandomeName name = new RandomeName();

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
        string cropname;
        public double money = 500;
        double test;
        int appcount;
        int randnum2;



        public void greeting()
        {

            Console.WriteLine("Hello, and welcome to day 1 of your Grocery Store.");

            time.OneSec();



            while (incorrect)
            {
                Console.WriteLine("Would you like to skip the instructions of the game?");
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


            special.Add(0);
            special.Add(0);
            special.Add(0);
            special.Add(0);
            special.Add(0);
            special.Add(0);

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

                    line = Console.ReadLine();


                    res = int.TryParse(line, out choice);
                    if (res == false)
                    {
                        Console.WriteLine("{0} is not an integer", line);

                    }
                    else if (res == true)

                        
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

            for (int j = 0; j < Items.Count; j++)
            {
                Items[j] = 0;
                shoplist[j] = 500;
                special[j] = 0;
            }

            application();
            if (randnum2 == 1)
            {
                time.OneSec();
                Console.WriteLine("You got a application!");
                time.TwoSec();
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
            }
            else if (money <= 500)
            {
                Console.WriteLine("Your store ended up " + (money - 500) + " in debt!");
                time.OneSec();
                Console.WriteLine("Your time: ");
                time.elapsed();

                HighScore();
            }
        }

        public void application()
        {
            randnum2 = rand.Random(2);
            if (randnum2 == 2)
            {

            }
            else if (randnum2 == 1)
            {
                applicants.Add(name.random());

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

            Console.WriteLine("Would you like to hire someone?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            line = Console.ReadLine();



            bool res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }
            else if (res == true)

                if (choice == 1)
                {
                    Console.WriteLine("who would you like to hire?");
                    for (int j = 0; j < applicants.Count; j++)
                    {
                        int i = 1;
                        Console.WriteLine(i + ". " + applicants[j]);
                        i++;
                    }
                    line = Console.ReadLine();



                    res = int.TryParse(line, out choice);
                    if (res == false)
                    {
                        Console.WriteLine("{0} is not an integer", line);

                    }
                    else if (res == true)

                        if (choice == 1)
                        {
                            applicants.Remove(applicants[0]);
                            Console.WriteLine("Applicant hired! you will now make more money");
                        }
                        else if (choice == 2)
                        {
                            applicants.Remove(applicants[1]);
                            Console.WriteLine("Applicant hired! you will now make more money");
                        }
                        else if (choice == 3)
                        {
                            applicants.Remove(applicants[2]);
                            Console.WriteLine("Applicant hired! you will now make more money");
                        }
                        else if (choice == 4)
                        {
                            applicants.Remove(applicants[3]);
                            Console.WriteLine("Applicant hired! you will now make more money");
                        }
                        else if (choice == 5)
                        {
                            applicants.Remove(applicants[4]);
                            Console.WriteLine("Applicant hired! you will now make more money");
                        }
                        else if (choice == 6)
                        {
                            applicants.Remove(applicants[5]);
                            Console.WriteLine("Applicant hired! you will now make more money");
                        }
                        else if (choice == 7)
                        {
                            applicants.Remove(applicants[6]);
                            Console.WriteLine("Applicant hired! you will now make more money");
                        }
                        else if (choice == 8)
                        {
                            applicants.Remove(applicants[7]);
                            Console.WriteLine("Applicant hired! you will now make more money");
                        }
                        else if (choice == 9)
                        {
                            applicants.Remove(applicants[8]);
                            Console.WriteLine("Applicant hired! you will now make more money");
                        }
                        else if (choice == 10)
                        {
                            applicants.Remove(applicants[9]);
                            Console.WriteLine("Applicant hired! you will now make more money");
                        }

                    menu();
                }
                else if (choice == 2)
                {
                    menu();
                }


        }
        public void HighScore()
        {
            double recordedtime = time.stopWatch.Elapsed.TotalMinutes;
            double score = recordedtime - money;
            Console.WriteLine("Your high score is: " + score);


            Console.WriteLine("Please enter your name: ");

            line = Console.ReadLine();

            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\Owner\\Documents\\Visual Studio 2015\\Projects\\GroceryStore\\GroceryStore\\bin\\Debug\\HighScores.txt", true);
            file.WriteLine(line + ":" + score);
            file.Close();

            string[] scorearray = File.ReadAllLines("HighScores.txt");
            var orderedScores = scorearray.OrderByDescending(x => double.Parse(x.Split(':')[1]));

            Console.WriteLine("HighScore List");
            Console.WriteLine("--------------------");
            int i = 0;
            foreach (var finalscore in orderedScores)
            {

                Console.WriteLine(i + ". " + finalscore);

                i++;
            }
            file.Close();
            greeting();
        }
        bool res;

        public void cornspecial() {
            cropname = "corn";
            Console.WriteLine("{0} value is now high due to the news", cropname);
            Console.WriteLine("how much {0} do you want to buy?                      my money: ${1}", cropname, money);
            cropoptions.valueable();
            line = Console.ReadLine();



            res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }
            else if (res == true)
                if (choice == 1)
                {
                    if (money < 200 || shoplist[0] < 50)
                    {
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
                        menu();
                    }
                    shoplist[0] -= 500;
                    money -= 1000;
                    Items[0] += 500;
                    special[0] += 1;
                }
        }

        public void potatoespecial() {
            cropname = "potatoe";
            Console.WriteLine("{0} value is now high due to the news", cropname);
            Console.WriteLine("how much {0} do you want to buy?                      my money: ${1}", cropname, money);
            cropoptions.valueable();
            line = Console.ReadLine();



            res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }
            else if (res == true)

                if (choice == 1)
                {
                    if (money < 200 || shoplist[1] < 50)
                    {
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
                        menu();
                    }
                    shoplist[1] -= 500;
                    money -= 1000;
                    Items[1] += 500;
                    special[1] += 2;
                }
        }


        public void flourspecial() {
            cropname = "flour";
            Console.WriteLine("{0} value is now high due to the news", cropname);
            Console.WriteLine("how much {0} do you want to buy?                      my money: ${1}", cropname, money);
            cropoptions.valueable();
            line = Console.ReadLine();



            res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }
            else if (res == true)
                if (choice == 1)
                {
                    if (money < 200 || shoplist[2] < 50)
                    {
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
                        menu();
                    }
                    shoplist[2] -= 500;
                    money -= 1000;
                    Items[2] += 50;
                    special[2] += 3;
                }
        }


        public void tomatoespecial() {
            cropname = "tomatoes";
            Console.WriteLine("{0} value is now high due to the news", cropname);
            Console.WriteLine("how much {0} do you want to buy?                      my money: ${1}", cropname, money);
            cropoptions.valueable();
            line = Console.ReadLine();



            res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }
            else if (res == true)

                if (choice == 1)
                {
                    if (money < 200 || shoplist[3] < 50)
                    {
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
                        menu();
                    }
                    shoplist[3] -= 500;
                    money -= 1000;
                    Items[3] += 500;
                    special[3] += 4;
                }
        }

        public void lettucespecial() {
            cropname = "lettuce";
            Console.WriteLine("{0} value is now high due to the news", cropname);
            Console.WriteLine("how much {0} do you want to buy?                      my money: ${1}", cropname, money);
            cropoptions.valueable();
            line = Console.ReadLine();



            res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }
            else if (res == true)
                if (choice == 1)
                {
                    if (money < 200 || shoplist[4] < 50)
                    {
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
                        menu();
                    }
                    shoplist[4] -= 500;
                    money -= 1000;
                    Items[4] += 500;
                    special[4] += 5;
                }
        }

        public void beansspecial() {
            cropname = "beans";
            Console.WriteLine("{0} value is now high due to the news", cropname);
            Console.WriteLine("how much {0} do you want to buy?                      my money: ${1}", cropname, money);
            cropoptions.valueable();
            line = Console.ReadLine();



            res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }
            else if (res == true)
                if (choice == 1)
                {
                    if (money < 200 || shoplist[5] < 50)
                    {
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
                        menu();
                    }
                    shoplist[5] -= 500;
                    money -= 1000;
                    Items[5] += 500;
                    special[5] += 6;
                }
        }

        public void corn() {
            cropname = "corn";

            Console.WriteLine("how much {0} do you want to buy?                      my money: ${1}", cropname, money);
            cropoptions.normal();
            line = Console.ReadLine();



            res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }
            else if (res == true)
                if (choice == 1)
                {
                    if (money < 100 || shoplist[0] < 50)
                    {
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
                        menu();
                    }
                    shoplist[0] -= 500;
                    money -= 550;
                    Items[0] += 500;
                }
        }

        public void potatoe() {
            cropname = "potatoe";

            Console.WriteLine("how much {0} do you want to buy?                      my money: ${1}", cropname, money);
            cropoptions.normal();
            line = Console.ReadLine();



            res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }
            else if (res == true)
                if (choice == 1)
                {
                    if (money < 100 || shoplist[1] < 50)
                    {
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
                        menu();
                    }
                    shoplist[1] -= 500;
                    money -= 550;
                    Items[1] += 500;
                }
        }

        public void flour() {
            cropname = "flour";

            Console.WriteLine("how much {0} do you want to buy?                      my money: ${1}", cropname, money);
            cropoptions.normal();
            line = Console.ReadLine();



            res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }
            else if (res == true)

                if (choice == 1)
                {
                    if (money < 100 || shoplist[2] < 50)
                    {
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
                        menu();
                    }
                    shoplist[2] -= 500;
                    money -= 550;
                    Items[2] += 500;
                }
        }

        public void tomatoe() {
            cropname = "tomatoe";

            Console.WriteLine("how much {0} do you want to buy?                      my money: ${1}", cropname, money);
            cropoptions.normal();
            line = Console.ReadLine();



            res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }
            else if (res == true)
                if (choice == 1)
                {
                    if (money < 100 || shoplist[3] < 50)
                    {
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
                        menu();
                    }
                    shoplist[3] -= 500;
                    money -= 550;
                    Items[3] += 500;
                }

        }

        public void lettuce() {
            cropname = "lettuce";

            Console.WriteLine("how much {0} do you want to buy?                      my money: ${1}", cropname, money);
            cropoptions.normal();
            line = Console.ReadLine();



            res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }
            else if (res == true)
                if (choice == 1)
                {
                    if (money < 100 || shoplist[4] < 50)
                    {
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
                        menu();
                    }
                    shoplist[4] -= 500;
                    money -= 550;
                    Items[4] += 500;
                }
        }
        public void beans() {
            cropname = "beans";

            Console.WriteLine("how much {0} do you want to buy?                      my money: ${1}", cropname, money);
            cropoptions.normal();
            line = Console.ReadLine();



            res = int.TryParse(line, out choice);
            if (res == false)
            {
                Console.WriteLine("{0} is not an integer", line);

            }
            else if (res == true)
                if (choice == 1)
                {
                    if (money < 100)
                    {
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
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
                        Console.WriteLine("you dont have enough money or item amount is out of stock!");
                        menu();
                    }
                    shoplist[5] -= 500;
                    money -= 550;
                    Items[5] += 500;
                }

        }
    }
}
