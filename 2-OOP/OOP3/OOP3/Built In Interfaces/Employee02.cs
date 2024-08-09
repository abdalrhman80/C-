using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.OOP3.Built_In_Interfaces
{
    internal class Employee02 : ICloneable, IComparable /*IComparable<Employee02>*/
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        #endregion

        #region Constructors
        public Employee02() { }

        // Copy Constructor : Is A Special Constructors Used Once For Make Deep Copy
        public Employee02(Employee02 EmployeeCopy)
        {
            this.Id = EmployeeCopy.Id;
            this.Name = EmployeeCopy.Name;
            this.Salary = EmployeeCopy.Salary;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Salary : {Salary}";
        }

        public object Clone()
        {
            //return new Employee02()
            //{
            //    // this For Caller
            //    Id = this.Id,
            //    Name = this.Name,
            //    Salary = this.Salary
            //};

            return new Employee02(this); // In Case Constructor Copy
        }

        public int CompareTo(object? OtherObject)
        {
            Employee02? OtherEmployee = (Employee02?)OtherObject; // Explicate Casting

            if (this.Salary > OtherEmployee?.Salary)
                return 1;
            else if (Salary < OtherEmployee?.Salary)
                return -1;
            else
                return 0;
        }
        #endregion
    }
}
