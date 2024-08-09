using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Operator_Overloading.Example1
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Image { get; set; }

        //public Complex(int _Real,int _Image)
        //{
        //    Real = _Real;
        //    Image = _Image;
        //}

        public override string ToString()
        {
            return $"{Real} + {Image}i";
        }

        #region Binary Operators

        public static Complex operator +(Complex Left, Complex Right)
        {
            return new()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Image = (Left?.Image ?? 0) + (Right?.Image ?? 0)
            };

        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Image = (Left?.Image ?? 0) - (Right?.Image ?? 0)
            };

        }

        #endregion

        #region Unary Operators
        public static Complex operator ++(Complex Left)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + 1,
                Image = Left?.Image ?? 0,
            };
        }
        public static Complex operator --(Complex Left)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - 1,
                Image = Left?.Image ?? 0,
            };
        }
        #endregion

        #region Relational (Comparison) Operators
        public static bool operator >(Complex Left, Complex Right)
        {
            if (Left?.Real == Right?.Real)
                return Left?.Image > Right?.Image;
            else
                return Left?.Real > Right?.Real;
        }
        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left?.Real == Right?.Real)
                return Left?.Image < Right?.Image;
            else
                return Left?.Real < Right?.Real;
        }
        #endregion

        #region Casting Operators

        #region Explicit Casting
        public static /*int*/ explicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }
        #endregion

        #region Implicit Casting
        public static /*string*/ implicit operator string(Complex C)
        {
            return C?.ToString() ?? string.Empty;
        }
        #endregion

        #endregion
    }
}
