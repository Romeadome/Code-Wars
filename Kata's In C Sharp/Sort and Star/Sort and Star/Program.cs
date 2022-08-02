using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 You will be given a vector of strings. You must sort it alphabetically (case-sensitive, and based on the ASCII values of the chars) and then return the first value.

The returned value must be a string, and have "***" between each of its letters.

You should not remove or add elements from/to the array.
*/
namespace Sort_and_Star
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoSort( new string[] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps" }));
            Console.WriteLine(TwoSort(new string[] { "car", "apple", "banana", "Car" }));
            Console.ReadLine();
        }

        public static string TwoSort(string[] s)
        {
            //string[] sortedString = s;
            Array.Sort(s, StringComparer.Ordinal);
            string sortedStarString = "";

            for (int i = 0; i < s[0].Length; i++)
            {

                sortedStarString += $"{s[0][i]}***";
            }
            sortedStarString = sortedStarString.Remove(sortedStarString.Length - 3);
            return sortedStarString;
        }
    }
}
