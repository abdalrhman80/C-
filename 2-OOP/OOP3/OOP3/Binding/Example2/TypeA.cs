using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Binding.Example2
{
    internal class TypeA
    {
        public int A { get; set; }

        #region Constructor
        public TypeA(int _A)
        {
            A = _A;
        }
        #endregion

        #region Methods
        public void WhereAmI()
        {
            Console.WriteLine("Iam Type A");
        }
        public virtual void Print()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
        #endregion
    }
}
