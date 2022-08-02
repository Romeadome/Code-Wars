using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Given three integers a ,b ,c, return the largest number obtained after inserting the following operators and brackets: +, *, ()
In other words , try every combination of a,b,c with [*+()] , and return the Maximum Obtained

EXAMPLE: 

With the numbers are 1, 2 and 3 , here are some ways of placing signs and brackets:
    1 * (2 + 3) = 5
    1 * 2 * 3 = 6
    1 + 2 * 3 = 7
    (1 + 2) * 3 = 9

*/

namespace Expressions_Matter
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine($"Test Case: 1, Expected: 6 \n\tResult: {ExpressionsMatter(2, 1, 2)}");
            Console.WriteLine($"Test Case: 2, Expected: 3 \n\tResult: {ExpressionsMatter(1, 1, 1)}");
            Console.WriteLine($"Test Case: 3, Expected: 4 \n\tResult: {ExpressionsMatter(2, 1, 1)}");
            Console.WriteLine($"Test Case: 4, Expected: 9 \n\tResult: {ExpressionsMatter(1, 2, 3)}");
            Console.WriteLine($"Test Case: 5, Expected: 5 \n\tResult: {ExpressionsMatter(1, 3, 1)}");
            Console.WriteLine($"Test Case: 6, Expected: 8 \n\tResult: {ExpressionsMatter(2, 2, 2)}");
            Console.ReadLine();
           
        }

        public static int ExpressionsMatter(int a, int b, int c)
        {
            int[] sum = new int[6];

            sum[0] = a * b * c;
            sum[1] = a + b + c;
            sum[2] = a * b + c;
            sum[3] = a * (b + c);
            sum[4] = (a + b) * c;
            sum[5] = a + b * c;


            return sum.Max();
        }
    }
}
