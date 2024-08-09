using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Binding.Example1
{
    internal class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public new void WhoYouAre()
        {
            Console.WriteLine("Iam Full Time Employee\n");
        }
        public override void Print()
        {
            Console.WriteLine($"Employee ID : {Id} , Employee Name : {Name} , Age : {Age} , Salary : {Salary}");
        }
    }
}
