using AdvCsharp01.Generics;
using AdvCsharp01.Generics.IComparableInterface;

namespace AdvCsharp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics

            #region Waht is Generics?
            /*
             * Generic means the general form, not specific.
             
             * Powerful feature allow us to create a single class or method that can be used with 
               different types of data. This helps us to reuse our code.

             * Generic Classes:- A generics class is used to create an instance of any data type. 
                                 The type is specified when the class is instantiated.

                                 (generics كلهم Members في حالة ان generic يبقي class يفضل ان ال)
               
                     Syntax =>  class (ClassName)<T>
                                {
                                  // block of code 
                                }

             * Generic Methods: A generic method allows you to define a method with a type parameter,
                                which can be specified when the method is called.
               
                     Syntax =>  (AccessModifier) (ReturnType | T) (MethodName)<T> (T (parameter),....)
                                {
                                  // block of code 
                                }

             * Constraints: You can specify constraints on the type parameters to restrict the types that can be used.
                         
                     Syntax =>  GenericTypeName<T> where T  : constraint1, constraint2
            */
            #endregion

            #region Examples

            #region Swap Example

            #region Before Generics
            //Console.WriteLine("-----------Before Generics-----------\n");

            //int A = 3, B = 5;
            //Console.WriteLine("Int Values: \n");
            //Console.WriteLine($"A = {A} , B = {B}");
            //Helper.SwapWithFixedTypes(ref A, ref B);
            //Console.WriteLine($"A = {A} , B = {B}");

            //Console.WriteLine("-------------------");

            //double C = 3, D = 5;
            //Console.WriteLine("Double Values: \n");
            //Console.WriteLine($"C = {C} , D = {D}");
            //Helper.SwapWithFixedTypes(ref C, ref D);
            //Console.WriteLine($"C = {D} , B = {D}");

            //Console.WriteLine("-------------------");

            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(3, 4);
            //Console.WriteLine("Point Values: \n");
            //Console.WriteLine($"P1 : {P1} \nP2 : {P2}");
            //Helper.SwapWithFixedTypes(ref P1, ref P2);
            //Console.WriteLine($"P1 : {P1} \nP2 : {P2}");

            //Console.WriteLine("-------------------");

            //object P3 = new Point(5, 6);
            //object P4 = new Point(7, 8);
            //Console.WriteLine("Object (Point) Values: \n");
            //Console.WriteLine($"P3 : {P3} \nP4 : {P4}");
            //Helper.SwapWithObjectType(ref P3, ref P4);
            //Console.WriteLine($"P3 : {P3} \nP4 : {P4}");

            //Console.WriteLine("-------------------");

            //object D1 = 3.5m, D2 = 2.7m; // Boxing
            //Console.WriteLine("Object (Decimal) Values: \n");
            //Console.WriteLine($"D1 : {D1} , D2 : {D2}");
            //Helper.SwapWithObjectType(ref D1, ref D2);
            //Console.WriteLine($"D1 : {D1} , D2 : {D2}");
            #endregion

            #region After Generics
            //Console.WriteLine("-----------After Generics-----------\n");

            //int A = 3, B = 5;
            //Console.WriteLine("Int Values: \n");
            //Console.WriteLine($"A = {A} , B = {B}");
            //Helper.SwapWithGenerics<int>(ref A, ref B);
            //Console.WriteLine($"A = {A} , B = {B}");

            //Console.WriteLine("-------------------");

            //double C = 3, D = 5;
            //Console.WriteLine("Double Values: \n");
            //Console.WriteLine($"C = {C} , D = {D}");
            //Helper.SwapWithGenerics<double>(ref C, ref D);
            //Console.WriteLine($"C = {D} , B = {D}");

            //Console.WriteLine("-------------------");

            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(3, 4);
            //Console.WriteLine("Point Values: \n");
            //Console.WriteLine($"P1 : {P1} \nP2 : {P2}");
            //Helper.SwapWithGenerics<Point>(ref P1, ref P2);
            //Console.WriteLine($"P1 : {P1} \nP2 : {P2}");
            #endregion

            #endregion

            #region Search Example
            //int[] Numbers = { 5, 3, 9, 1, 2 };

            #region Before Generics
            ////int Index1 = Helper.LinerSearchIntegersArray(Numbers, 9);
            ////Console.WriteLine($"The Index Of Value 9 : {Index1}"); 
            #endregion

            #region After Generics
            //int Index2 = Helper<int>.LinerSearchArrayByGeneric(Numbers, 2);
            //Console.WriteLine($"The Index Of Value 2 : {Index2}");

            //Point Point1 = new Point(3, 12);
            //Point Point2 = new Point(1, 9);
            //Point Point3 = new Point(6, 13);

            //Point[] Points = { Point1, Point2, Point3 };

            //int Index3 = Helper<Point>.LinerSearchArrayByGeneric(Points, Point2);
            //Console.WriteLine($"The Index Of Value Object [{Point2}] : {Index3}");  
            #endregion

            #endregion

            #region BubbleSort Example

            #region Before Generics
            //int[] RandomNumbers = { 10, 3, 6, 9, 1, 2 };
            //Helper<int>.BubbleSortIntegersArray(RandomNumbers);
            //Console.Write("Array After Sort: ");
            //foreach (int i in RandomNumbers)
            //{
            //    Console.Write($"{i} "); // Array After Sort: 1 2 3 5 6 10
            //}
            #endregion

            #region After Generics
            //int[] RandomNumbers2 = { 10, 3, 6, 9, 1, 2 };
            //Helper<int>.BubbleSortArrayByGeneric(RandomNumbers2);

            //Console.Write("Array of Integers After Sort: \n");
            //foreach (int i in RandomNumbers2)
            //{
            //    Console.Write($"{i} "); // 1 2 3 5 6 10
            //}

            //Console.WriteLine("\n-------------------------------\n");

            //Point Point1 = new Point(3, 12);
            //Point Point2 = new Point(1, 9);
            //Point Point3 = new Point(6, 13);

            //Point[] Points = { Point1, Point2, Point3 };
            ////Helper<Point>.BubbleSortArrayByGeneric(Points); // Point Don't Implement CompareTo Method

            //Console.Write("Array of Points After Sort: \n");
            //Helper<Point>.BubbleSortArrayByGeneric(Points); // After Implement CompareTo Method
            //foreach (Point i in Points)
            //{
            //    Console.Write($"{i} | "); // X = 1 , Y = 9 | X = 3 , Y = 12 | X = 6 , Y = 13 |
            //}
            #endregion

            #endregion

            #endregion

            #endregion

            #region IComparable Vs IComparable Generic

            #region IComparableNormal
            //IComparableNormal[] Normals = 
            //{ new IComparableNormal(1, 2), new IComparableNormal(5,6),  new IComparableNormal(3,4)};

            //Helper<IComparableNormal>.BubbleSortArrayByGeneric(Normals);

            //foreach (IComparableNormal normal in Normals)
            //{
            //    Console.WriteLine(normal);
            //    // IComparable Normal: X = 1 , Y = 2
            //    // IComparable Normal: X = 3 , Y = 4
            //    // IComparable Normal: X = 5 , Y = 6
            //} 
            #endregion

            #region IComparableGeneric
            //IComparableGeneric[] Generics =
            //{ new IComparableGeneric(1, 2), new IComparableGeneric(5,6), new IComparableGeneric(3,4) };

            ////Helper<IComparableGeneric>.BubbleSortArrayByGeneric(Generics); // Generic يكون Helperجوا ال IComparableلازم ال
            //Helper<IComparableGeneric>.BubbleSortArrayByGeneric(Generics);

            //foreach (IComparableGeneric generic in Generics)
            //{
            //    Console.WriteLine(generic);
            //    // IComparable Generic: X = 1 , Y = 2
            //    // IComparable Generic: X = 3 , Y = 4
            //    // IComparable Generic: X = 5 , Y = 6
            //} 
            #endregion

            #endregion
        }
    }
}
