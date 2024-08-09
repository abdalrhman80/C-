using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCsharp01.Generics.IComparableInterface
{
    internal class IComparableGeneric : IComparable<IComparableGeneric>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public IComparableGeneric(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public override string ToString()
        {
            return $"IComparable Generic: X = {X} , Y = {Y}";
        }

        public int CompareTo(IComparableGeneric? Other)
        {
            if (Other == null)
                return 1;

            if (Other.GetType() == typeof(IComparableGeneric))
                return X == Other.X ? Y.CompareTo(Other.Y) : X.CompareTo(Other.X);
            else
                return 1;
        }
    }
}
