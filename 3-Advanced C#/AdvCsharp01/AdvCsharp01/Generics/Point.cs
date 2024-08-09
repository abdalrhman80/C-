using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCsharp01.Generics
{
    /*1*/ //internal class Point
    internal class Point : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X = {X} , Y = {Y}";
        }

        public int CompareTo(object? OtherObject)
        {
            Point? OtherPoint = (Point?)OtherObject; // Unsafe Casting => My Throw Exception (InvalidCastingException)

            if (X > OtherPoint?.X)
                return 1;
            else if (X < OtherPoint?.X)
                return -1;
            else
                return 0;
        }
    }
}
