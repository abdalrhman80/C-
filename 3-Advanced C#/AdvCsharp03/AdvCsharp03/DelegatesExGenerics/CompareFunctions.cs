using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCsharp03.DelegatesExGenerics
{
    internal class CompareFunctions
    {
        public static bool CompareGrater(int x, int y)
        {
            return x > y;
        }

        public static bool CompareLesser(int x, int y)
        {
            return x < y;
        }

        public static bool SortingAscending(string x, string y)
        {
            return x?.Length > y?.Length;
        }

        public static bool SortingDescending(string x, string y)
        {
            return x?.Length < y?.Length;
        }

    }
}
