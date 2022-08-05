using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 This kata is about multiplying a given number by eight if it is an even number and by nine otherwise.
*/
namespace Simple_Multiplication
{
    internal class Multiplier
    {
        public static int Multiply(int x)
        {
            return x % 2 == 0 ? x * 8 : x * 9;
        }
    }
}
