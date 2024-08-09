using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Partial_Class 
{
    internal partial class PartialEmployee
    {
        public int Salary { get; set; }
        public partial void Print()
        {
            Console.WriteLine($"ID = {ID} , Name = {Name} , Age = {Salary} ,  Salary = {Salary}");
        }
    }
}
