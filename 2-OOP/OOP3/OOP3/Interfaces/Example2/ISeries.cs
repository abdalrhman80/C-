using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Interfaces.Example2
{
    internal interface ISeries
    {
        int Current { get; set; }
        void GetNext();
        void Reset();
    }
}
