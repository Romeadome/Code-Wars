﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Your task is to make two functions ( max and min, or maximum and minimum, etc., depending on the language ) that receive a list of integers as input, and return the largest and lowest number in that list, respectively.
Examples (Input -> Output)

* [4,6,2,1,9,63,-134,566]         -> max = 566, min = -134
* [-52, 56, 30, 29, -54, 0, -110] -> min = -110, max = 56
* [42, 54, 65, 87, 0]             -> min = 0, max = 87
* [5]                             -> min = 5, max = 5

Notes

    You may consider that there will not be any empty arrays/vectors.

*/

namespace Min_Max_Values_In_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 4, 6, 2, 1, 9, 63, -134, 566 };
            Console.WriteLine("Max: {0}",Max(ints));
            Console.WriteLine("Min: {0}", Min(ints));
            Console.ReadLine();
        }

        public static int Max(int[] list)
        {
            return list.Max();
        }
        public static int Min(int[] list)
        {
            return list.Min();
        }
    }
}
