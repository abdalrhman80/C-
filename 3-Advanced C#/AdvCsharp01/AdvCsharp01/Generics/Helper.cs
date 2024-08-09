using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCsharp01.Generics
{
    /*1*/ //internal class Helper
    /*2*/ //internal class Helper<T>
    /*3*/ //internal class Helper<T> where T : IComparable /*Constrains*/
    internal class Helper<T> where T : IComparable<T> /*Constrains*/
        // T Must Be Class Or Struct That Implementing interface IComparable<T>
    {
        #region Swap Example

        #region Before Generics
        public static void SwapWithFixedTypes(ref int X, ref int Y)
        {
            //Console.WriteLine("\nAfter Swap\n");
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        public static void SwapWithFixedTypes(ref double X, ref double Y)
        {
            Console.WriteLine("\nAfter Swap\n");
            double Temp = X;
            X = Y;
            Y = Temp;
        }
        public static void SwapWithFixedTypes(ref Point X, ref Point Y)
        {
            Console.WriteLine("\nAfter Swap\n");
            Point Temp = X;
            X = Y;
            Y = Temp;
        }
        public static void SwapWithObjectType(ref object X, ref object Y)
        {
            Console.WriteLine("\nAfter Swap\n");
            object Temp = X;
            X = Y;
            Y = Temp;
        }
        #endregion

        #region After Generics
        public static void SwapWithGenerics<T>(ref T Left, ref T Right)
        /*
         * Compiler Can Detect The Type Of <T> Based On (The Type Of Method Input Parameters),
           In Case GenericType <T> Is Declared On [method] Level Not [class-struct-interface] Level.
        */
        {
            //Console.WriteLine("\nAfter Swap\n");
            T Temp = Left;
            Left = Right;
            Right = Temp;
        }
        #endregion

        #endregion

        #region Search Example

        #region Before Generics
        public static int LinerSearchIntegersArray(int[] Array, int Value)
        {
            if (Array is not null) // To Avoid System.NullReferenceException
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] == Value)
                        return i;
                }
            }
            return -1;
        }
        #endregion

        #region After Generics
        public static int LinerSearchArrayByGeneric(T[] Array, T Value)
        {
            if (Array is not null)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    //if (Array[i] == Value) // Operator '==' cannot be applied to operands of type 'T' and 'T'
                    if (Array[i].Equals(Value))
                        return i;
                }
            }
            return -1;
        }
        #endregion

        #endregion

        #region Bubble Sort Example

        #region Before Generics
        public static void BubbleSortIntegersArray(int[] Array)
        {
            //5, 3, 6, 10, 1, 2
            if (Array is not null)
            {
                for (int i = 0; i < Array.Length; i++) // Loop On All Array Members
                {
                    for (int j = 0; j < Array.Length - i - 1; j++) // Loop To Compare Values
                    {
                        if (Array[j] > Array[j + 1])
                            Helper<int>.SwapWithGenerics(ref Array[j], ref Array[j + 1]);
                    }
                }
            }
        }
        #endregion

        #region After Generics
        public static void BubbleSortArrayByGeneric(T[] Array)
        {
            //5, 3, 6, 10, 1, 2
            if (Array is not null)
            {
                for (int i = 0; i < Array.Length; i++) // Loop On All Array Members
                {
                    for (int j = 0; j < Array.Length - i - 1; j++) // Loop To Compare Values
                    {
                        //if (Array[j] > Array[j + 1]) // Operator '>' cannot be applied to operands of type 'T' and 'T'
                        if (Array[j].CompareTo(Array[j + 1]) == 1)
                            Helper<int>.SwapWithGenerics(ref Array[j], ref Array[j + 1]);
                    }
                }
            }
        }
        #endregion

        #endregion
    }
}
