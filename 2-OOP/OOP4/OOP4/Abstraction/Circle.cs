using OOP4.Abstraction.Abstract_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Abstraction
{
    internal class Circle : Shape
    {
        //public Circle(decimal radius)
        //{
        //    Dimension01 = Dimension02 = radius;
        //}

        public Circle(decimal radius) : base(radius, radius)
        {
            //Dimension01 = Dimension02 = radius;
        }

        public override decimal Perimeter
        {
            get
            {
                return 2 * 3.14m * Dimension01;
            }
        }

        public override decimal GetArea()
        {
            //return 3.14m * Dimension01 * Dimension02;
            return (decimal)Math.PI * Dimension01 * Dimension01;
        }
    }
}
