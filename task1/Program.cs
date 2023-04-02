//using System;

namespace task1
{
    internal class Program
    {
        const int NumberOfArgument = 2;
        static void Main(string[] str)
        {
            
            if (CheckInputParametr.StringOrNumber(str) != true) { Console.WriteLine("Any of the arguments is not a number."); Environment.Exit(0); }
            if (CheckInputParametr.NumberOfArguments(str, NumberOfArgument) != true) { Console.WriteLine("Invalid number of parameters entered."); Environment.Exit(0); }
            //if (CheckInputParametr.NegativeNumbers(str) != true) { Console.WriteLine("Array cannot be negative length"); Environment.Exit(0); }

            Console.WriteLine(string.Join("", Engine.Arr(int.Parse(str[0]), int.Parse(str[1]))));

        }



     }

 
}

