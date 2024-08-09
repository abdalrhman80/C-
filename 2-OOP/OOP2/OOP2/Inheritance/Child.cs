using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Inheritance
{
    internal class Child : Parent
    {
        #region Properties
        public int Z { get; set; }
        #endregion

        #region Constructor
        /*
         * Base Class لل  Constructor مع ال Constructor Channing لازم يعمل Child Class جوا ال Constructor اي 
        */

        public Child(int _X, int _Y, int _Z) : base(_X, _Y) // Constructor Channing 
        {
            Z = _Z;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"X = {X} \nY = {Y} \nZ = {Z}";
        }
        #endregion
    }
}
