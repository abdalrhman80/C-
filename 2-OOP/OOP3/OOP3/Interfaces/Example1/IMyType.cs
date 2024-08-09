using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Interfaces.Example1
{
    internal interface IMyType
    {
        // Default access Modifier Inside Interface is Public

        public decimal Salary { get; set; } // 1-Signature For Property
        public void PrintSalary(); // 2-Signature For Method
        void PrintMessage() // 3-Default Implemented Methods
        {
            Console.WriteLine("Iam IMyType Interface");
        }
    }
}
