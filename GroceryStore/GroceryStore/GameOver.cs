using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class GameOver
    {

        public void Over()
        {
            Options options = new Options();
            Console.WriteLine("Game over!");
            if (options.Money >= 500)
            {
                Console.WriteLine("Your store made: "+ (options.Money - 500) );
            }
            else if (options.Money <= 500) {
                Console.WriteLine("Your store ended up " + (options.Money - 500)+" in debt!");
            }
            

        }

    }
}
