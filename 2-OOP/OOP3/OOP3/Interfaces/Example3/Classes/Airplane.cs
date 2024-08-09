using OOP3.Interfaces.Example3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Interfaces.Example3.Classes
{
    internal class Airplane : Vehicle, IMovable, IFlyable
    {
        // Implement Interfaces Members Explicitly 
        void IMovable.Backward()
        {
            Console.WriteLine("Airplane Move Backward On Ground");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("Airplane Fly Backward On Are");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("Airplane Move Forward On Ground");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane Fly Forward On Are");
        }
    }
}
