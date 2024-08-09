using OOP4.Abstraction.Abstract_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Abstraction
{
    //internal class Rectangle : Shape /*Inherit and Implement*/
    internal class Rectangle /*Concert Class*/ : RectSquareBaseArea
    /*
     * Concert Class: Fully Implemented Class.
     * When Inherit Abstract Class We Need To Implement All Abstract Methods In Abstract Class.
    */
    {
        public Rectangle(decimal _Dimension01, decimal _Dimension02) : base(_Dimension01, _Dimension02) { }

        public override decimal Perimeter
        {
            get
            {
                return (Dimension01 + Dimension02) * 2;
            }
        }

        //public override decimal GetArea()
        //{
        //    return Dimension01 * Dimension02;
        //}
    }
}
