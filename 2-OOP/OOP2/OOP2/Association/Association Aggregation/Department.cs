using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Association_Aggregation
{
    internal class Department
    {
        // Departments has a Employees [Association Aggregation] 

        public int Id { get; set; }
        public string? Name { get; set; }
        public Employee[]? Employees { get; set; } // Employees مش شرط يكون فيها Department ال

        #region Constructor
        public Department(string _Name)
        {
            Name = _Name;
        }

        public Department(string _Name, Employee[]? _Employees) : this(_Name)
        {
            Employees = _Employees;
        }
        #endregion
    }
}
