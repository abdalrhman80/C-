using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Interfaces.Example1
{
    internal class MyType : IMyType // Implement IMyType Interface
    {
        #region Properties
        //private decimal salary;
        //public decimal Salary
        //{
        //    get { return salary; }
        //    set { salary = value; }
        //}

        public decimal Salary { get; set; }
        #endregion

        #region Methods
        public void PrintSalary()
        {
            Console.WriteLine($"Salary = {Salary}");
        }
        public void PrintMessage()
        {

        }
        #endregion
    }
}
