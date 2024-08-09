using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Polymorphism.Method_Overriding
{
    internal class TypeC : TypeD
    {
        public int B { get; set; }

        #region Constructor
        public TypeC(int _A, int _B) : base(_A)
        {
            B = _B;
        }
        #endregion

        #region Methods
        public new void WhereAmI()
        {
            Console.WriteLine("Iam In Child");
        }

        public override void Print()
        {
            Console.WriteLine($"Type A = {A} \nType B = {B}");
        }
        #endregion
    }
}
