using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Binding.Example2
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        #region Constructor
        public TypeB(int _A, int _B) : base(_A)
        {
            B = _B;
        }
        #endregion

        #region Methods
        public new void WhereAmI() // [Static / Early Binding]
        {
            Console.WriteLine("Iam Type B");
        }
        public override void Print() // [Dynamic / Late Binding]
        {
            Console.WriteLine($"TypeB : A = {A} , B = {B}");
        }
        #endregion
    }
}
