using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {

        public TypeB()
        {
            TypeA obj = new TypeA();
            //obj.X = 10; // X => privet ('TypeA.X' is inaccessible due to its protection level)
            obj.Y = 20;
            obj.Z = 30;
        }
    }
}
