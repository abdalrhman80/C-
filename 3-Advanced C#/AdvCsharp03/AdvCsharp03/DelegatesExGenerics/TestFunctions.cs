using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCsharp03.DelegatesExGenerics
{
    internal class TestFunctions
    {
        public static bool CheckGreaterThanZero(int x)
        {
            return x > 0;
        }

        public static string ConvertNumberToString(int x)
        {
            return $"ToString: {x}";
        }

        public static void Print()
        {
            Console.WriteLine("Hello World");
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
