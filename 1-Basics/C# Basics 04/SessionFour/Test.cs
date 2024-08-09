using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionFour
{
    internal class Test
    {
        public static void PrintPattern(string Pattern = "#", int Size = 5)
        {
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(Pattern);
            }
        }

        public static void Swap(int x, int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }

        public static void SwapWithRef(ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }

        public static int SumArray(int[] arr)
        {
            int Sum = 0;

            arr[0] = 101;

            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                    Sum += arr[i];
            }

            return Sum;
        }

        public static int SumArrayWithRef(ref int[] arr)
        {
            int Sum = 0;

            arr[0] = 101;

            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                    Sum += arr[i];
            }

            return Sum;
        }

        public static int SumNewArray(int[] arr)
        {
            int Sum = 0;

            arr = new int[] { 4, 5, 6, 7 };

            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                    Sum += arr[i];
            }
            return Sum;
        }

        public static int SumNewArrayWithRef(ref int[] arr)
        {
            int Sum = 0;

            arr = new int[] { 4, 5, 6, 7 };

            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                    Sum += arr[i];
            }
            return Sum;
        }
    }
}
