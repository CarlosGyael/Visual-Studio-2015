using System;
using System.Collections.Generic;

namespace Binary_Assignment
{
    internal class Functions
    {
        bool data;
        public List<int> list = new List<int>();



        public string makebinary(int convert)
        {


            while (convert > 0 || convert >1)
            {

                int mod = convert % 2;
                convert = convert / 2;

                if (mod == 0)
                {
                    data = false;
                }
                else if (mod == 1)
                {
                    data = true;

                }
                if (data == true)
                {
                    list.Add(1);
                }
                else if (data == false) {
                    list.Add(0);
                }

            }
            string answer = String.Join("", list);
            return answer;
        }
            
                
             
            
     


        public void BinaryAdder(int convert)
        {
            
            
          


            
        }



        //private int ConvertToInteger(Bool[] binary)
        //{



    }
    // private Bool[] ConvertToBinary(int)
    //{

    //}
    //Bool[] Add(Bool[] newvalues)
    //{
    //}
}
   