using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Binding.Example2
{
    internal class TypeC : TypeB
    {
        public int C { get; set; }

        #region Constructor
        public TypeC(int _A, int _B, int _C) : base(_A, _B)
        {
            this.C = _C;
        }
        #endregion

        #region Methods
        public new void WhereAmI() // [Static / Early Binding]
        {
            Console.WriteLine("Iam Type C");
        }
        public override void Print() // [Dynamic / Late Binding]
        {
            Console.WriteLine($"TypeC : A = {A} , B = {B} , C = {C}");
        }
        #endregion
    }
}
