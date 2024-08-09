using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01.Encapsulation
{
    // بس Polymorphism (Overloading) و ال Encapsulation بيطبق ال Struct ال
    internal struct Employee
    {
        #region Attributes

        public int Id; // Default => 0
        public decimal salary; // Default => 0
        private /*public*/ string Name; // Default => null

        #region Getter & Setter
        public string GetName() /*Getter*/
        {
            return Name;
        }
        public void SetName(string Value) /*Setter*/
        {
            //Name = Value;
            Name = Value.Length > 5 ? Value.Substring(0, 5) : Value ?? String.Empty; // Data Validation
        }
        #endregion

        #region Property

        #region 1.Full Property
        public decimal Salary /* Small اول حرف Attribute وال Capital بتبقي اول حرف Property ال*/
        {
            get { return salary; }
            set { salary = value; }
        }
        #endregion

        #region 2.Automatic Property 
        // بس set, get استخدمها لو هعمل  
        public int Age { get; set; } // Attribute ال Property دي ال Attribute دي كدا مش ال
                                     // CLR Will Generate Backing Filed (.il file) [Hidden Privet Attribute] 
        #endregion

        #endregion

        #endregion

        #region Constructor
        public Employee(int _Id, string _Name, decimal _salary, int _Age)
        {
            Id = _Id;
            Name = _Name;
            salary = _salary;
            Age = _Age;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id : {Id}\nName : {Name}\nsalary : {salary}";
        }
        #endregion
    }
}
