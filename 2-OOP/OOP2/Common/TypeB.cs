using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB : TypeA
    {
        public void Test()
        {
            TypeA objA1 = new TypeA();
            //objA1.X = 10; // Private Protected // 'TypeA.X' is inaccessible due to its protection level
            //objA1.Y = 20; // Protected // 'TypeA.Y' is inaccessible due to its protection level
            objA1.Z = 30; // internal Protected 
        }
    }
}
