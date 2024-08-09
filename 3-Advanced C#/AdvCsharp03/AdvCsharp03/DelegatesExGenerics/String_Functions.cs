using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCsharp03.DelegatesExGenerics
{
    internal class String_Functions
    {
        public static int GetCountOfUpperChars(string str)
        {
            int Count = 0;

            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsUpper(str[i]))
                        Count++;
                }
            }

            return Count;
        }

        public static int GetCountOfLowerChars(string str)
        {
            int Count = 0;

            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLower(str[i]))
                        Count++;
                }
            }

            return Count;
        }
    }
}
