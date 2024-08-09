using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Abstraction.Abstract_classes 
{
    internal abstract class Shape
    {
        public decimal Dimension01 { get; set; }
        public decimal Dimension02 { get; set; }
        public abstract decimal Perimeter { get; } // Abstract property (accessors)

        public abstract decimal GetArea(); // Abstract method

        public Shape(decimal dimension01, decimal dimension02)
        {
            Dimension01 = dimension01;
            Dimension02 = dimension02;
        }

        public void Display() // Regular method
        {
            Console.WriteLine("This is a shape.");
        }
    }
}
