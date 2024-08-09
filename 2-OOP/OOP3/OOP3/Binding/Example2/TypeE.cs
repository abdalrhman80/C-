using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Binding.Example2
{
    internal class TypeE : TypeD
    {
        public int E { get; set; }

        #region Constructor
        public TypeE(int _A, int _B, int _C, int _D, int _E) : base(_A, _B, _C, _D)
        {
            this.E = _E;
        }
        #endregion

        #region Methods
        public new void WhereAmI() // [Static / Early Binding]
        {
            Console.WriteLine("Iam Type E");
        }
        public override void Print()
        {
            Console.WriteLine($"TypeE : A = {A} , B = {B} , C = {C}, D = {D} , E = {E}");
        }
        #endregion
    }
}
