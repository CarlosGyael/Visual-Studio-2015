using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Assignment
{
    class Program
    {


        static void Main(string[] args)

        {

            Console.WriteLine("want to convert 1. to binary or 2. to int?");
            Console.WriteLine("1.to binary");
            Console.WriteLine("2. to number");
           int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {



                Console.WriteLine("Please entter a decimal number: ");

                int firstNumber = int.Parse(Console.ReadLine());


                var result = Convert.ToString(firstNumber, 2);

                Console.WriteLine("first binary: " + result);






                Console.WriteLine("Please enter second decimal numnber:");



                int secondNumber = int.Parse(Console.ReadLine());

                var result2 = Convert.ToString(firstNumber, 2);

                Console.WriteLine("first binary: " + result);
            }
            else if (choice == 2) {
                Console.WriteLine("please enter a binary code");
                string input =Console.ReadLine();
                string result = Convert.ToInt32(input, 2).ToString();
                Console.WriteLine("your result is: " + result);
            }


        }


       
       

    }
}
    
