using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Binding.Example2
{
    internal class TypeD : TypeC
    {
        public int D { get; set; }

        #region Constructor
        public TypeD(int _A, int _B, int _C, int _D) : base(_A, _B, _C)
        {
            this.D = _D;
        }
        #endregion

        #region Methods
        public new void WhereAmI() // [Static / Early Binding]
        {
            Console.WriteLine("Iam Type D");
        }
        public new virtual void Print()
        // new virtual => TypeD وبدئت سلسله جديده هتبدء من TypeA كدا انا كسرت السلسله اللل كانت بدئه في 
        {
            Console.WriteLine($"TypeD : A = {A} , B = {B} , C = {C}, D = {D}");
        }
        #endregion
    }
}
