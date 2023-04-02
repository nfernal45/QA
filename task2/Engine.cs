using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Engine
    {
        public static void Engine1(int[] numb) 
        {

            int[] arr = numb;
            int sum = 0;
            int moves = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            int target = sum / arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                moves += Math.Abs(arr[i] - target);
            }

            Console.WriteLine("Minimum number of moves: " + moves);

        }
    }
}
