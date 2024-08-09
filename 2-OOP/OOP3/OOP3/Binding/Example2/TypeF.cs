using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Binding.Example2
{
    internal class TypeF : TypeE
    {
        public int F { get; set; }

        #region Constructor
        public TypeF(int _A, int _B, int _C, int _D, int _E, int _F) : base(_A, _B, _C, _D, _F)
        {
            this.F = _F;
        }
        #endregion

        #region Methods
        public new void WhereAmI() // [Static / Early Binding]
        {
            Console.WriteLine("Iam Type F");
        }
        public override void Print()
        {
            Console.WriteLine($"TypeF : A = {A} , B = {B} , C = {C}, D = {D} , E = {E} , F = {F}");
        }
        #endregion
    }
}
