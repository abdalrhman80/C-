using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Operator_Overloading.CastingOperatorBusinessNeed
{
    internal class User
    // Model: Is A Class That Represent Table Exits In Database
    // Tableفي ال Columns دي هيا Properties و ال Database First وانا شغال SQL في ال Table هفترض ان دا 
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid? SecuritySmp { get; set; }
    }
}
