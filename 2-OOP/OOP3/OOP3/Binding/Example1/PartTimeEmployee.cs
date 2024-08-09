using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Binding.Example1
{
    internal class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }

        public new void WhoYouAre()
        {
            Console.WriteLine("Iam Part Time Employee\n");
        }
        public override void Print()
        {
            Console.WriteLine($"Employee ID : {Id} , Employee Name : {Name} , Age : {Age} , HourRate : {HourRate}");
        }
    }
}
