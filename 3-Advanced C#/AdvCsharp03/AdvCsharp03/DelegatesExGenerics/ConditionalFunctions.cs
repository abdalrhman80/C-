using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCsharp03.DelegatesExGenerics
{
    internal class ConditionalFunctions
    {
        public static bool CheckOdd(int number)
        {
            return number % 2 == 1;
        }
        public static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }
        public static bool CheckDividedBySeven(int number)
        {
            return number % 7 == 0;
        }
        public static bool CheckDividedByTen(int number)
        {
            return number % 10 == 0;
        }
        public static bool CheckStringMoreThan4(string str)
        {
            return str?.Length > 4;
        }
        public static bool CheckStringLessThan4(string str)
        {
            return str?.Length < 4;
        }
    }
}
