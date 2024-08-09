using OOP4.Abstraction.Abstract_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Abstraction
{
    internal class Triangle : Shape
    {
        public decimal Dimension03 { get; set; }

        public Triangle(decimal _Dim01, decimal _Dim02, decimal _Dim03) : base(_Dim01, _Dim02)
        {
            Dimension03 = _Dim03;
        }

        public override decimal Perimeter
        {
            get
            {
                return Dimension01 + Dimension02 + Dimension03;
            }
        }

        public override decimal GetArea()
        {
            return .5m * Dimension01 * Dimension02;
        }
    }
}
