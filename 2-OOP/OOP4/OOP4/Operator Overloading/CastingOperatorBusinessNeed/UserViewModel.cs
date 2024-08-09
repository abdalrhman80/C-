using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Operator_Overloading.CastingOperatorBusinessNeed
{
    internal class UserViewModel
    // View Model: Is A Class Represent The Data That Will Rendered In View (HTML)
    // View (HTML) اللي عايزها تتعرض في ال Data ال
    {
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public static explicit operator UserViewModel(User model)
        {
            string[]? names = model?.FullName?.Split(" ");

            return new UserViewModel()
            {
                FName = names?.Length > 0 ? names[0] : string.Empty,
                LName = names?.Length > 1 ? names[1] : string.Empty,
                Email = model?.Email ?? string.Empty,
                Password = model?.Password ?? string.Empty,
            };
        }
    }
}
