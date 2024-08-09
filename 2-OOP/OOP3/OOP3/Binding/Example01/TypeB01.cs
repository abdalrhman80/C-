using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Binding.Example01
{
    internal class TypeB01 : TypeA01
    {
        public int B { get; set; }

        #region Constructor
        public TypeB01(int _A, int _B) : base(_A)
        {
            B = _B;
        }
        #endregion

        #region Methods
        public new void WhereAmI() // [Static / Early Binding]
        {
            Console.WriteLine("Iam In Child");
        }
        public override void Print() // [Dynamic / Late Binding]
        {
            Console.WriteLine($"TypeB : A = {A} , B = {B}");
        }
        #endregion
    }
}
