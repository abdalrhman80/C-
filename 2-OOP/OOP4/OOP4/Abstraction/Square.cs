using OOP4.Abstraction.Abstract_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Abstraction
{
    //internal class Square : Shape
    internal class Square : RectSquareBaseArea
    {
        //public Square(decimal dimension)
        //{
        //    Dimension01 = Dimension02 = dimension;
        //}

        public Square(decimal dimension) : base(dimension, dimension)
        {
            //Dimension01 = Dimension02 = dimension;
        }

        public override decimal Perimeter
        {
            get
            {
                return Dimension01 * 4;
            }
        }

        //public override decimal GetArea()
        //{
        //    return Dimension01 * Dimension02;
        //}
    }
}
