using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Binding.Example1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public void WhoYouAre()
        {
            Console.WriteLine($"Iam Employee\n");
        }
        public virtual void Print() 
        {
            Console.WriteLine($"Employee ID : {Id} , Employee Name : {Name} , Age : {Age} ");
        }

    }
}
