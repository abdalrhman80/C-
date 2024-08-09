using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCsharp01.Generics.IComparableInterface
{
    internal class IComparableNormal02 : IComparableNormal
    {
        public int Z { get; set; }

        public IComparableNormal02(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
    }
}
