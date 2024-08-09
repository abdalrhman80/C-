using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCsharp03.DelegatesExGenerics
{
    #region Delegate 
    public delegate bool CompareFuncDelegate(int x, int y);
    #endregion

    #region Generic-Delegate
    //public delegate bool CompareFuncDelegateGeneric<T>(T x, T y); // class بيتعامل زي ال delegateال 
    public delegate TResult CompareFuncDelegateGeneric<in T, out TResult>(T x, T y);
    #endregion

    internal class SortingAlgorithms<T>
    {
        #region Non-Generic Methods
        public static void BubbleSort(int[] array, CompareFuncDelegate compareFunc)
        // وبناء عليه هحدد انا هرتب تصاعدي ولا تنازلي methodمن ال reference انا هبعت
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (compareFunc.Invoke(array[j], array[j + 1]))
                            Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region Generic Methods
        public static void BubbleSortGeneric(T[] array, CompareFuncDelegateGeneric<T, bool> compareFunc)
        // وبناء عليه هحدد انا هرتب تصاعدي ولا تنازلي methodمن ال reference انا هبعت
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (compareFunc(array[j], array[j + 1]))
                            Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region Built-in Delegate (Func)
        public static void BubbleSortGenericUsingFuncDelegate(T[] array, Func<T, T, bool> compareFunc)
        // وبناء عليه هحدد انا هرتب تصاعدي ولا تنازلي methodمن ال reference انا هبعت
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (compareFunc(array[j], array[j + 1]))
                            Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
        #endregion
    }
}
