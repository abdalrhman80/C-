using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Car
    {
        #region Attributes and Properties
        private int CarId { get; set; }
        private string CarModal { get; set; }
        private double Speed { get; set; }
        #endregion

        #region Constructor
        // If There Is No User-Defined Constructor, The Compiler Will Generate Parameterless Constructor Do Nothing
        // If Defined User-Defined Constructor, The Compiler Will No Longer Generate Parameterless Constructor

        //public Car() { }

        #region Constructor Channing
        /*
         * Properties لكل ال initialization واحد عامل Constructor الفكرة ان في 
         * constructor لل calling من جديد اقدر اعمل initialization بدل ما اعمل Constructor لل Overloading فا لو جيت اعمل
           Properties لكل ال initialization اللي عامل فيه 
        */
        public Car(int _CarId, string _CarModel, double _Speed)
        {
            CarId = _CarId;
            CarModal = _CarModel;
            Speed = _Speed;
            Console.WriteLine("Constructor 1");
        }

        // Overloading
        public Car(int _CarId, string _CarModel) : this(_CarId, _CarModel, 150)
        {
            //CarId = _CarId;
            //CarModal = _CarModel;
            //Speed = 150; // Default Value
            Console.WriteLine("Constructor 2");
        }

        public Car(int _CarId) : this(_CarId, "Ferrari", 200)
        {
            //CarId = _CarId;
            //CarModal = "Ferrari";
            //Speed = 200;
            Console.WriteLine("Constructor 3");
        }
        #endregion

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"CarId : {CarId} \nCar Modal : {CarModal} \nSpeed : {Speed}";
        }
        #endregion

    }
}
