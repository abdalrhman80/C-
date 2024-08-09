using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCsharp03.DelegatesExGenerics
{
    #region Delegate(Non-Generic)
    public delegate bool ConditionalFuncDelegate(int number);
    #endregion

    #region Delegate(Generic)
    public delegate bool ConditionalFuncDelegateGeneric<T>(T element);
    #endregion

    internal static class Helper
    {
        #region Non-Generic Methods
        public static List<int> GetOddNumbers(List<int> list)
        {
            List<int> oddList = new List<int>();

            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 1)
                        oddList.Add(list[i]);
                }

                return oddList;
            }

            return oddList;
        }

        public static List<int> GetEvenNumbers(List<int> list)
        {
            List<int> evenList = new List<int>();

            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                        evenList.Add(list[i]);
                }

                return evenList;
            }

            return evenList;
        }

        public static List<int> GetNumbersDividedBy7(List<int> list)
        {
            List<int> numberBy7List = new List<int>();

            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 7 == 0)
                        numberBy7List.Add(list[i]);
                }

                return numberBy7List;
            }

            return numberBy7List;
        }

        public static List<int> GetNumbersBasedOnRefMethod(List<int> list, ConditionalFuncDelegate conditionalFunc)
        {
            List<int> resultList = new List<int>();

            if (list is not null && conditionalFunc is not null) // null فا وارد يكون ب reference هيكون شايل conditionalFunc
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (conditionalFunc(list[i]))
                        resultList.Add(list[i]);
                }

                return resultList;
            }

            return resultList;
        }
        #endregion

        #region Generic Methods
        public static List<T> GetElementsBasedOnRefMethod<T>(List<T> list, ConditionalFuncDelegateGeneric<T> conditionalFunc)
        {
            List<T> resultList = new List<T>();

            if (list is not null && conditionalFunc is not null) // null فا وارد يكون ب reference هيكون شايل conditionalFunc
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (conditionalFunc(list[i]))
                        resultList.Add(list[i]);
                }

                return resultList;
            }

            return resultList;
        }
        #endregion

        #region Built-in Delegate (Predicate)
        public static List<T> GetElementsUsingPredicateDelegate<T>(List<T> list, Predicate<T> conditionalFunc)
        {
            List<T> resultList = new List<T>();

            if (list is not null && conditionalFunc is not null) // null فا وارد يكون ب reference هيكون شايل conditionalFunc
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (conditionalFunc(list[i]))
                        resultList.Add(list[i]);
                }

                return resultList;
            }

            return resultList;
        }
        #endregion
    }
}
