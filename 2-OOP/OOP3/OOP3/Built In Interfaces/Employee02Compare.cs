using OOP3.OOP3.Built_In_Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Built_In_Interfaces
{
    internal class Employee02Compare : IComparer
    {
        public int Compare(object? X, object? Y)
        {
            Employee02? Employee02X = (Employee02?)X;
            Employee02? Employee02Y = (Employee02?)Y;

            return Employee02X?.Id.CompareTo(Employee02Y?.Id) ?? (Employee02Y is null ? 0 : -1);
        }
    }
}
