using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionFive
{
    internal struct StructPoint
    {
        // Attributes
        public int X;
        public int Y;

        /*
         * Constructor : Is A Special Function
            * 1. Always Named With It's Owned Class or Struct
            * 2. Has No Return
         
         * Struct Constructor only used To Initialize Attributes
         * By Default In Struct Compiler Will Always Generate Parameterless Constructor 
           (Attributesلل Default Value = 0 ممكن مكتبوش وهوا هيحط)
         * Inside Parameterized Constructor, We must assign the value for every field of struct.
        */

        public StructPoint() // Parameterless Constructor
        {
            X = 5;
            Y = 10;
        }

        public StructPoint(int _X, int _Y) // Parameterized Constructor
        {
            //this.X = _X;
            X = _X;
            Y = _Y;
        }
    }
}
