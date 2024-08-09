using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Abstraction.Abstract_classes
{
    internal abstract class RectSquareBaseArea : Shape
    // ده عشان مكررش في الكود Class عملت ال
    // الاتنين ليهم نفس المساحة Rectangle و Square لان ال
    // abstract ده هيحسب المساحة بس وعشان كدا انا عملته Classوال
    // abstract members لل Implement تاني مش لازم يعمل abstract class لو وارث من abstract Class لان ال
    {
        public RectSquareBaseArea(decimal _Dimension01, decimal _Dimension02) : base(_Dimension01, _Dimension02) { }

        public override decimal GetArea()
        {
            return Dimension01 * Dimension02;
        }
    }
}
