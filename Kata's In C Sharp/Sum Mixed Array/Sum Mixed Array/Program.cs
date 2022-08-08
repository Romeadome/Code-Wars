using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.

Return your answer as a number.
*/
namespace Sum_Mixed_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Expected Result : 22 \nResult: {0}", SumMix(new object[] { 9, 3, "7", "3" }));
            Console.WriteLine("Expected Result : 42 \nResult: {0}", SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
            Console.WriteLine("Expected Result : 41 \nResult: {0}", SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
            Console.ReadLine();
        }

        public static int SumMix(object[] x)
        {
            int[] newObj = x.Select(Convert.ToInt32).ToArray();
            return newObj.Sum();
        }
    }
}
