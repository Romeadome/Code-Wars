using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 This kata is from check py.checkio.org

You are given an array with positive numbers and a non-negative number N. You should find the N-th power of the element in the array with the index N. If N is outside of the array, then return -1. Don't forget that the first element has the index 0.

Let's look at a few examples:

    array = [1, 2, 3, 4] and N = 2, then the result is 3^2 == 9;
    array = [1, 2, 3] and N = 3, but N is outside of the array, so the result is -1.

*/
namespace N_th_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output should be: 9\n Result: {0}",Index (new int[] {1,2,3,4}, 2));
            Console.WriteLine("Output should be: 1000000\n Result: {0} ",Index(new int[] { 1, 3, 10, 100 }, 3));
            Console.ReadLine();
        }
        public static double Index(int[] array, int n)
        {
            if (n >= array.Length)
            {
                return -1;
            }
            return Math.Pow(array[n], n);

        }
    }
}
