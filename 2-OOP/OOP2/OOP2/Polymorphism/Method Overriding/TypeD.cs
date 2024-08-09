using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Polymorphism.Method_Overriding
{
    internal class TypeD
    {
        public int A { get; set; }

        #region Constructor
        public TypeD(int _A)
        {
            A = _A;
        }
        #endregion

        #region Methods
        public void WhereAmI()
        {
            Console.WriteLine("Iam In Parent");
        }
        public virtual void Print()
        {
            Console.WriteLine($"Type A = {A}");
        }
        #endregion
    }
}
