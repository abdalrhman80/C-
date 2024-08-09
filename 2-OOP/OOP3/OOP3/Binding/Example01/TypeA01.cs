using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Binding.Example01
{
    internal class TypeA01
    {
        public int A { get; set; }

        #region Constructor
        public TypeA01(int _A)
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
            Console.WriteLine($"TypeA : A = {A}");
        }
        #endregion
    }
}
