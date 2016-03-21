using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class Items
    {
        int getcorn;
        int getpotatoes;
        int getflour;
        int gettomatoes;
        int getlettuce;
        int getbeans ;


        public int Corn(int newint) {
            getcorn = newint;
            return getcorn;
        }
        public int Potatoes(int newint)
        {
            getpotatoes = newint;
            return getpotatoes;
        }
        public int Tomatoes(int newint)
        {
            gettomatoes = newint;
            return gettomatoes;
        }
        public int Flour(int newint)
        {
            getflour = newint;
            return getflour;
        }
        public int Lettuce(int newint)
        {
            getlettuce = newint;
            return getlettuce;
        }
        public int Beans(int newint)
        {
            getbeans = newint;
            return getbeans;
        }

    }
}
