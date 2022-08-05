using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 "c" -> False
"C" -> True
"hello I AM DONALD" -> False
"HELLO I AM DONALD" -> True
"ACSKLDFJSgSKLDFJSKLDFJ" -> False
"ACSKLDFJSGSKLDFJSKLDFJ" -> True

In this Kata, a string is said to be in ALL CAPS whenever it does not contain any lowercase letter so any string 

containing no letters at all is trivially considered to be in ALL CAPS.*/
namespace Is_the_string_uppercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "hello I AM DonaD";
            Console.WriteLine(StringExtensions.IsUpperCase(text));
            Console.ReadLine();
        }

    }
}
