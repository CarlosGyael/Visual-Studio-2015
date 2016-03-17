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
            Functions functions = new Functions();
            Console.WriteLine("want to convert 1. to binary or 2. to int?");
            Console.WriteLine("1.to binary");
            Console.WriteLine("2. to number");
            int choice = int.Parse(Console.ReadLine());
            
            if (choice == 1)
            {



                Console.WriteLine("Please enter a number");

                int firstNumber = int.Parse(System.Console.ReadLine());
           

               string answer= functions.makebinary(firstNumber);
                
                    Console.WriteLine(answer);
                
             

            }
            else if (choice == 2)
            {
                Console.WriteLine("please enter a binary code");

                string firstNumber = System.Console.ReadLine();

                string result = Convert.ToInt32(firstNumber, 2).ToString();

                Console.WriteLine("now converted back to int:  {0}", result);
                
            }


        }





    }
}

