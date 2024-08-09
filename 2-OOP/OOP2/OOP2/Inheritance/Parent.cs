using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Inheritance
{
    internal class Parent
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructor
        //public Parent() { }

        public Parent(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"X = {X} \nY = {Y}";
        }
        #endregion
    }
}
