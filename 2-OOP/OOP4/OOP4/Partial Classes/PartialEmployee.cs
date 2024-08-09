using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Partial_Class
{
    internal partial class PartialEmployee 
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public partial void Print();
    }
}
