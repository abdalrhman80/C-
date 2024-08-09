using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Static_And_Constants
{
    internal /*static*/ class Utility
    {
        public int X { get; set; }
        public int Y { get; set; }

        #region Constructors

        public Utility(int x, int y)
        {
            X = x;
            Y = y;
            //pi = 3.14; // Is Not The Right Place For Initialize static attribute 
            // object هتبقي دي قيمتها لما اعمل pi كدا ال
            // class من ال object من غير ما اعمل Pi في 3 طرق اني اثبت القيمه بتاعت ال
            // 1- Static Constructor
            // 2- readonly attribute
            // 3- constant attribute ✔
        }

        #region Static Constructor
        //static Utility()
        //{
        //    pi = 3.14;
        //}
        #endregion

        #endregion

        #region Static Attribute & Property

        #region Static Attribute
        //private double pi; 

        //private static double pi; // Static Attribute
        // Compiler Will Initialize The Static Attributes With The Default Value Of Attribute Type

        //private readonly static double pi = 3.14; // readonly Attribute

        private const double pi = 3.14; // Constant Attribute
        #endregion

        #region Static Property
        //public  double Pi
        //{
        //    get { return pi; }
        //    set { pi = value; }
        //}

        public static double Pi // Static Property : ClassName من اي مكان من خلال ال Call اقدر اعملها 
        {
            get { return /*Utility.*/ pi; } // Inside Class we can access static members without using the class name.
            //set { pi = value; }
        }
        #endregion

        #endregion

        #region Methods

        #region Static Methods
        // We can call the static methods using the class name
        public static double CmToInch(double Cm)
        {
            return Cm / 2.54;
        }

        public static double GetCircleArea(double r)
        {
            //return 3.14 * r * r;

            //return Pi * r * r; // An object reference is required for the non-static field, method, or property 'Utility.Pi'
            //Utility U = new Utility(1,3);
            //return U.Pi * r * r;

            return Pi * r * r;
        }
        #endregion

        public override string ToString()
        {
            return $"X = {X} , Y = {Y}";
        }

        #endregion
    }
}
