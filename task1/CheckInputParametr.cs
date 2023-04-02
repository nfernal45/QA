using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class CheckInputParametr
    {
        public static bool StringOrNumber(string[] str2)
        {
            
            foreach (string str in str2)
            {
                if (!int.TryParse(str, out int num))
                {
                    return false;
                }               
            }
            return true;
        }

            

        public static bool NumberOfArguments(string[] str2, int NumberOfArgument )
        {

           if (str2.Length != NumberOfArgument)
           {
              return false;
           }
           else
           {
              return true;
           }     
               
        }
       
        //public static bool NegativeNumbers(string[] str2) 
        //{
        //    if ((!int.TryParse(str2[0], out int arg) || arg < 0))
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}
