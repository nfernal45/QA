using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1

{
    public class Engine

    {
        /// <summary>
        /// Method for obtaining the path of a given array with a given step
        /// </summary>
        /// <param name="lenght">Array lenght</param>
        /// <param name="step">Interval</param>
        /// <returns></returns>
        public static int[] Arr(int lenght, int step)
        {
            //if (lenght < 0)
            //    lenght *= -1 ;

            int[] arr = new int[lenght];       
            for (int i = 0; i < lenght; i++)
            {
                arr[i] = i + 1;
            }

            int firstNumber = arr[0];
            int index = 0;
            var resultList = new List<int>();

            do
            {
                resultList.Add(arr[index]);
                if (step > 0)
                index += step - 1;
                else 
                index -= step + 1;
                if (index >= arr.Length)
                {
                    index %= arr.Length;
                }
            }

            while (arr[index] != firstNumber);


            return resultList.ToArray();


          

        }
    }
}


