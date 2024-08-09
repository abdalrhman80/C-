using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    internal class Car
    {
        #region What Can We Written inside class (Type Members)?
        /*
          * 1. Attributes [Fields]
          * 2. Property (Full Property - Automatic Property - Index)
          * 3. Methods (Constructor [Special Method With Same Name Of The Class] - Getter & Setter Methods)
          * 4. Event
        */
        #endregion

        #region Allowed Access Modifiers inside Class
        /*
          * 1. Privet (Default Access Modifiers)
          * 2. Privet Protected
          * 3. Protected
          * 4. Internal
          * 5. Internal Protected
          * 6. Public
        */
        #endregion

        #region Attributes and Properties
        private int CarId { get; set; }
        private string CarModal { get; set; }
        private double Speed { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"CarId : {CarId} \nCar Modal : {CarModal} \nSpeed : {Speed}";
        }
        #endregion

        #region Constructor
        // If There Is No User-Defined Constructor, The Compiler Will Generate Parameterless Constructor Do Nothing
        // If Defined User-Defined Constructor, The Compiler Will No Longer Generate Parameterless Constructor

        public Car() { } // Parameterless Constructor

        #region User-Defined Constructor
        public Car(int _CarId, string _CarModel, double _Speed)
        {
            CarId = _CarId;
            CarModal = _CarModel;
            Speed = _Speed;
        }

        #region Constructor Overloading
        public Car(int _CarId, string _CarModel)
        {
            CarId = _CarId;
            CarModal = _CarModel;
            Speed = 150; // Default Value
        }

        public Car(int _CarId)
        {
            CarId = _CarId;
            CarModal = "Ferrari";
            Speed = 200;
        }
        #endregion 

        #endregion

        #endregion

    }
}
