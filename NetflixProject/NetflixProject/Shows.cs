using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Shows
    {
        List<List<string>> showlist = new List<List<string>>();
        List<string> listname = new List<string>();
        List<string> pokemon = new List<string>();
        List<string> spongebob = new List<string>();
        List<string> familyguy = new List<string>();
        List<int> familyguyrate = new List<int>();
        List<int> spongebobrate = new List<int>();
        List<int> pokemonrate = new List<int>();

        Time time = new Time();
        Visual visual = new Visual();

        ConsoleKeyInfo input;
        double pokemonr;
        double familyguyr;
        double spongebobr;
        string letters;
        int rate;
        int track=0;
        int times=0;
        
            

        public void startshow()
        {
            addlist();
            showmenu();
        }

        public void showmenu()
        {
            foreach (string i in viewmenu(listname))
            {
                Console.WriteLine("show menu");
                totalrate();
                visual.left();
                Console.Write(i);
                visual.RightColored();
                Console.WriteLine("");
                
                if (track == 0)
                {
                    Console.WriteLine("overall rate: " + pokemonr);
                    
                }
                else if (track == 1)
                {
                    Console.WriteLine("overall rate: " + familyguyr);
                    
                }
                else if (track == 2)
                {
                    Console.WriteLine("overall rate: " + spongebobr);
                    track = -1;
                }
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    break;
                }
                else if (input.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    inputchange(i);
                }
                Console.Clear();
                track++;
            }
        }

        public void inputchange(string i)
        {
            addepisodes();
            if (i == "SpongeBob")
            {
                foreach (string a in viewmenu(spongebob))
                {

                    visual.left();
                    Console.Write(a);
                    visual.RightColored();
                    input = Console.ReadKey();
                    Console.Clear();
                    if (input.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        detailspongebob(a);
                    }
                    else if (input.Key == ConsoleKey.Backspace)
                    {

                        break;
                    }
                    if (times >= 7)
                    {
                        times = 0;
                    }
                    else
                    {
                        times++;
                    }
                }

            }
            else if (i == "FamilyGuy")
            {
                foreach (string a in viewmenu(familyguy))
                {
                    visual.left();
                    Console.Write(a);
                    visual.RightColored();
                    input = Console.ReadKey();
                    Console.Clear();
                    if (input.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        detailfamilyguy(a);
                    }
                    else if (input.Key == ConsoleKey.Backspace)
                    {

                        break;
                    }
                    if (times >= 3)
                    {
                        times = 0;
                    }
                    else
                    {
                        times++;
                    }
                }
            }
            else if (i == "Pokemon")
            {
                foreach (string a in viewmenu(pokemon))
                {
                    visual.left();
                    Console.Write(a);
                    visual.RightColored();
                    input = Console.ReadKey();
                    Console.Clear();
                    if (input.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        detailpokemon(a);
                    }
                    else if (input.Key == ConsoleKey.Backspace)
                    {

                        break;
                    }
                    if (times >= 5)
                    {
                        times = 0;
                    }
                    else
                    {
                        times++;
                    }
                }
            }
            else if (input.Key == ConsoleKey.Backspace)
            {

            }
            Console.Clear();
        }
        private void addlist()
        {
            for (int i = 0; familyguyrate.Count <= 3; i++)
            {
                familyguyrate.Add(0);
            }
            for (int i = 0; spongebobrate.Count <= 7; i++)
            {
                spongebobrate.Add(0);
            }
            for (int i = 0; pokemonrate.Count <= 5; i++)
            {
                pokemonrate.Add(0);
            }



            listname.Add("Pokemon");
            listname.Add("FamilyGuy");
            listname.Add("SpongeBob");

            showlist.Add(pokemon);
            showlist.Add(familyguy);
            showlist.Add(spongebob);

        }

        public void addepisodes()
        {
            pokemon.Add("Episode 1");
            pokemon.Add("Episode 2");
            pokemon.Add("Episode 3");
            pokemon.Add("Episode 4");
            pokemon.Add("Episode 5");

            familyguy.Add("Episode 1");
            familyguy.Add("Episode 2");
            familyguy.Add("Episode 3");

            spongebob.Add("Episode 1");
            spongebob.Add("Episode 2");
            spongebob.Add("Episode 3");
            spongebob.Add("Episode 4");
            spongebob.Add("Episode 5");
            spongebob.Add("Episode 6");
            spongebob.Add("Episode 7");
        }

        public void totalrate()
        {
            spongebobr = spongebobrate.Average();
            familyguyr = familyguyrate.Average();
            pokemonr = pokemonrate.Average();
        }

        public void detailpokemon(string b)
        {
            Console.WriteLine(b);
            Console.WriteLine("");
            Console.WriteLine("Rate :" + pokemonrate[times]);
            Console.WriteLine("");
            time.OneSec();
            Console.WriteLine("press F1 to change rate, anything else to back");
            input = Console.ReadKey();
            Console.Clear();
            if (input.Key == ConsoleKey.F1)
            {
                Console.WriteLine("rate this from 0-5");
                letters = Console.ReadLine();
                Int32.TryParse(letters, out rate);
                if (rate <= 5 && rate >= 0)
                {
                    pokemonrate.Insert(times, rate);
                    totalrate();
                }
            }
        }
        public void detailfamilyguy(string b)
        {
            Console.WriteLine(b);
            Console.WriteLine("");
            Console.WriteLine("Rate :" + familyguyrate[times]);
            Console.WriteLine("");
            time.OneSec();
            Console.WriteLine("press F1 to change rate, anything else to back");
            input = Console.ReadKey();
            Console.Clear();
            if (input.Key == ConsoleKey.F1)
            {
                Console.WriteLine("rate this from 0-5");
                letters = Console.ReadLine();
                Int32.TryParse(letters, out rate);
                if (rate <= 5 && rate >= 0)
                {
                    familyguyrate.Insert(times, rate);
                    totalrate();
                }
            }
        }
        public void detailspongebob(string b)
        {
            Console.WriteLine(b);
            Console.WriteLine("");
            Console.WriteLine("Rate :" + spongebobrate[times]);
            Console.WriteLine("");
            time.OneSec();
            Console.WriteLine("press F1 to change rate, anything else to back");
            input = Console.ReadKey();
            Console.Clear();
            if (input.Key == ConsoleKey.F1)
            {
                Console.WriteLine("rate this from 0-5");
                letters = Console.ReadLine();
                Int32.TryParse(letters, out rate);
                if (rate <= 5 && rate >= 0)
                {
                    spongebobrate.Insert(times, rate);
                    totalrate();
                }
            }
        }

        public IEnumerable viewmenu(List<string> a)
        {
            for (int j = 0; j < 1; j--)
            {
                foreach (string i in a)
                {
                    yield return i;
                }
            }
        }
    }
}
