using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Run مش ب class library project دا عباره عن
namespace Common
{
    public class TypeA
    //internal class TypeA
    {
        private int X; // بس class بتاع ال Scope هقدر اوصلها جوا ال
        internal int Y; // بس project عليها جوا ال access هقدر اعمل 
        public int Z; // عليها في اي مكان access هقدر

        public void print()
        {
            Console.WriteLine(X);
        }
    }
}
