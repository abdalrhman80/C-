using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCsharp01.Generics.IComparableInterface
{
    internal class IComparableNormal : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public IComparableNormal(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"IComparable Normal: X = {X} , Y = {Y}";
        }

        public int CompareTo(object? Obj)
        {
            #region Unsafe Casting
            // My Throw Exception (InvalidCastingException)
            IComparableNormal? Other01 = (IComparableNormal?)Obj;
            #endregion

            #region Safe Casting

            #region 1- is Conditional Operator [Casting]
            /*
              * The "is" operator is used to check if an object is of a specific type.
              * Syntax => (<object> is <type>)
              * Returns True In 3 Cases:
                * 1. Object (obj) Is Object Of Type Class "IComparableNormal".
                * 1. Object (obj) Is Object Of Type Inherits Form Class "IComparableNormal".
                * 3. Object (obj) Is Null.
            */

            //if (Obj is IComparableNormal Other02) // checks if "Obj" is a IComparableNormal and, if true, assigns "Obj" to the variable "Other02".
            //{
            //    if (Other02 is null)
            //        return 1;

            //    if (X == Other02.X)
            //        return Y.CompareTo(Other02.Y);
            //    else
            //        return X.CompareTo(Other01.X);
            //}
            //else
            //    return 1;

            #endregion

            #region 2- as Casting Operator 
            /*
              * The "as" operator is used for casting an object to a specific type.
              * Syntax => (<object> as <type>) 
              * Casting will succeed If and only if "Obj" is "IComparableNormal"
              * If the cast is fails, "as" will returns 'null' instead of throwing an exception,.
            */

            IComparableNormal? Other03 = Obj as IComparableNormal;

            if (Other03 is null)
                return 1;

            if (X == Other03.X)
                return Y.CompareTo(Other03.Y);
            else
                return X.CompareTo(Other03.X);

            #endregion

            #endregion
        }
    }
}
