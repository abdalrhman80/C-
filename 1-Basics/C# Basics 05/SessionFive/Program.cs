using System.Drawing;
using System.Reflection;

namespace SessionFive
{
    #region 5 Enum

    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Gender EmpSex { get; set; } // enum هوا كدا مش هيقبل اي قيمه غير اللي موجودين في ال
    }

    enum Gender
    {
        Male = 1, M = 1, Female = 2, F = 2
    }

    enum Grads
    {
        //0  1  2  3
        A, B, C, F
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1 Array Methods

            #region 1. class Member methods [static]
            /*
             * 1. class Member methods [static] 
                * static -> عشان اقدر استخدمها class من ال object علي طول يعني مش محتاج اعمل classدي من خلال ال methods يعني بنده ال

                * Methods => 1- Array.Sort(<1D Array>); -> [Return void]
                             2- Array.Reverse(<Array>); -> [Return void]
                             3- Array.Copy(<Source Array>, <Destination Array>, <Length>); -> [Return void] 
                             4- Array.ConstrainedCopy(<Source Array>, <Source Index>, <Destination Array>, <Destination Index>, <Length>); -> [Return void] 
                             5- Array.Clear(<Array>); -> [Return void] 
                             6- Array.CreateInstance(typeof(<ArrayType>), <Length>) -> [Return Array] 
                             7- Array.IndexOf(<Array>, <Index>); -> [Return int] 
                             8- Array.LastIndexOf(<Array>, <Index>); -> [Return int] 

            */

            //int[] numTest = { 5, 2, 6, 1, 4 };
            //int[] numTest2 = new int[5];

            ///*1*/
            //Array.Sort(numTest);

            //Console.WriteLine("1-Sort :");

            //foreach (int i in numTest)
            //{
            //    Console.Write($"{i} "); // 1 2 4 5 6
            //}
            //Console.WriteLine("\n");

            ///*2*/
            //Array.Reverse(numTest);

            //Console.WriteLine("2-Reverse :");

            //foreach (int i in numTest)
            //{
            //    Console.Write($"{i} "); // 4 1 6 2 5
            //}
            //Console.WriteLine("\n");

            ///*3*/
            //Array.Copy(numTest, numTest2, 3);

            //Console.WriteLine("3-Copy :");

            //foreach (int i in numTest2)
            //{
            //    Console.Write($"{i} "); // 5 2 6 0 0
            //}
            //Console.WriteLine("\n");

            ///*4*/
            //Array.ConstrainedCopy(numTest, 2, numTest2, 1, 2);

            //Console.WriteLine("4-ConstrainedCopy :");

            //foreach (int i in numTest2)
            //{
            //    Console.Write($"{i} "); // 0 6 1 0 0 
            //}
            //Console.WriteLine("\n");

            ///*5*/
            //Array.Clear(numTest);

            //Console.WriteLine("5-Clear :");

            //foreach (int i in numTest)
            //{
            //    Console.Write($"{i} "); // 0 0 0 0 0
            //}
            //Console.WriteLine("\n");

            ///*6*/
            //int[] arr3 = (int[])Array.CreateInstance(typeof(int), 3);
            //// int من نوع array  جوا assign ممكن يتغير وانا بعمل typeof عشان ال Explicit Casting لازم ال

            ////int[] arr3 = new int[3];

            //Console.WriteLine("6-CreateInstance :");

            //foreach (int i in arr3)
            //{
            //    Console.Write($"{i} "); // 0 0 0
            //}
            //Console.WriteLine("\n");

            ///*7*/
            //Console.WriteLine("7-IndexOf :");
            //Console.WriteLine(Array.IndexOf(numTest, 4)); // 4

            #endregion

            #region 2. object Member methods
            /*
             * 2. object Member methods
                * عشان اقدر استخدمها class من ال object محتاج اعمل 

                * Methods => 1- <array object>.Length() -> [Return array Length]
                             2- <array object>.Rank() -> [Return array Dimension]
                             3- <array object>.CopyTo(<Destination Array>, <StartIndex>) -> [Return void]
                             4- <2D array object>.GetLength(<0>) -> [Return Rows Number]
                             5- <2D array object>.GetLength(<1>) -> [Return Columns Number]
                             6- <array object>.GetValue(<Value>) -> [Return int]
                             6- <array object>.SetValue(<Value>, <Index>) -> [Return void]

             */

            //int[] numTest3 = { 1, 2, 3 };
            //int[] numTest4 = new int[5];

            ///*3*/
            //numTest3.CopyTo(numTest4, 1);

            //Console.WriteLine("3-CopyTo:");
            //foreach (int i in numTest4)
            //{
            //    Console.Write($"{i} "); // 0 1 2 3 0
            //}
            //Console.WriteLine("\n");

            ///*4*/
            //Console.WriteLine("4-GetLength:");
            //Console.WriteLine(numTest3.GetLength(0)); // 3
            //Console.WriteLine("\n");


            ///*5*/
            //Console.WriteLine("5-GetValue:");
            //Console.WriteLine(numTest3.GetValue(1)); // 2
            //Console.WriteLine("\n");


            ///*6*/
            //Console.WriteLine("6-SetValue:");
            //numTest3.SetValue(9, 2); // => numTest3[2] = 9

            //foreach (int i in numTest3)
            //{
            //    Console.Write($"{i} "); // 1 2 9
            //}
            //Console.WriteLine("\n");

            #endregion

            #endregion


            #region 2 Functions - Passing By out /* out KeyWord */
            /*
             * The out keyword is used for the passing the arguments to methods as a reference type. 
             * It is generally used when a method returns multiple values.
             * The difference between (ref and out) keyword is that ref needs that the variable must be initialized before it passed to the method. 
               But out parameter doesn't require the variables to be initialized before it passed to the method.
             
             * Variables في Function اللي راجعة من ال Data من خلالها هخزن ال KeyWord هي out ال
             * Call وانا بعمل Prototype وانا بعمل ال out لازم اكتب ال
            */

            //int sumResult, mulResult;
            //SumMul(4, 5, out sumResult, out mulResult);
            //Console.WriteLine($"Summation = {sumResult}, Multiplication = {mulResult}"); // 9, 20

            #endregion


            #region 3 Functions - Params
            /*
             * Params => It's allows you to pass a variable number of arguments to a method. 
             * The params keyword must be used in the method declaration before the parameter array.
             * Only one params keyword is allowed in a method.
             * It must be the last parameter.
             * If no arguments are passed, the method receives an empty array.
            */

            //int[] Numbers = { 1, 2, 3, 5, 6, 7, 8, 9 };

            //int Total01 = SumArray(Numbers); // نفسه array انا كد باعت ال
            //Console.WriteLine($"The Summation Of Array Numbers = {Total01}"); // 41


            //int Total02 = SumArrayWithParams(1, 2, 3, 5, 6, 7, 8, 9); // parameters من خلالها اقدر ابعت اي عدد من ال params ال 
            //Console.WriteLine($"The Summation Of Array Numbers = {Total02}"); // 40 => x اللي parameter اول قيمة هوا معتبرها اول

            #endregion


            #region 4 Exception Handling and Protective Code

            #region Exception Handling
            /* An exception is an unexpected event that occurs during program execution. */

            #region Type Of Exception
            /*
             * C# provides a base class named Exception which is derived into 2 classes :
             
               * 1- SystemException [built-in exceptions] : (This class handles all the system-related exceptions.)
                                    * 1. FormatException
                                    * 2. IndexOutOfRange
                                    * 3. NullReferenceException
                                    * 4. InvalidOperationException
                                    * 5. ArithmeticException
                                         * 5.1. DividedByZeroException 
                                   
               * 2- ApplicationException [user-defined exceptions] 
            */
            #endregion

            //DoSomeCode();

            /*
             * دي انا بدخل رقمين وبجيب حاصل القسمه بتاعهم method في ال
             * (System.FormatException: 'Input string was not in a correct format.') int مش  ممكن تتحول الي Value في احتمال ان ادخل اي من الارقام ب
             * (System.DivideByZeroException: 'Attempted to divide by zero.') وفي احتمال اني ادخل اي من الارقام ب 0
             * (System.IndexOutOfRangeException: 'Index was outside the bounds of the array.') تالت هيطلع وهوا Exception وفي 
            */

            /* try catch عن طريق ال Exceptions للكلام لكل ال Handling ممكن اعمل */

            #region try catch Blocks
            /*
             * Syntax => try
                         {
                            <Code May Case Exception>
                         }
                         catch (Exception <object>)
                         {
                         
                             <Code Handel That Exception>
                         }
            */

            //DoSomeCodeWithTryCatch();

            //// try في Code ومش هيكمل باقي ال Catch اللي في Code هينفذ ال try في  Exception انه اول ما يلاقي try catch من عيووب ال
            #endregion

            #endregion


            #region Protective Code

            /* Protective Code لازم اكتب  Exceptions من الاساس مينفعش اكتب كود عارف انه ممكن يطلع */

            //ProtectiveCode();

            #endregion

            #endregion


            #region 5 Enum
            /*
             * Enum (enumerations) => User-defined data type that represents a group of constants (unchangeable) variables. 
             
             * Syntax => enum <EnumName>: <NumericType> {
                                                          <Label1> = <Value>,
                                                          <Label2> = <Value>,
                                                          ...
                                                        }

             * We use enum names along with (.) operator to access enum members.
             
             * We can assign numeric values to the enum members.
             
             * If we have not assigned any value to the members of enum, by default 0 is assigned to the first memberو
               Then the value of other members is increased by 1.

             * To print enum values, we need to convert enum members to its corresponding values using explicit casting.
             
             * By default, the enum members are of int type.
             
             * The numeric value that we assign to the members can be of any of the integral numeric data types like
               (byte, int, short, long, ushort, or so on).
             
             * To specify the data type of enum members, we use (: typeName) after enum name.
            */

            //Grads myGrade = Grads.A; // Value واوصل لل Gradsلازم من خلال ال Value وعشان احط فيه Grads عرفت متغير من نوع
            ////myGrade = 2; // Cannot implicitly convert type 'int' to 'SessionFive.Grads'.

            //myGrade = (Grads)2; // Explicit Casting From 'int' To 'Grads'

            //if (myGrade == Grads.A || myGrade == Grads.B)
            //    Console.WriteLine($"{myGrade} => :)");
            //else
            //    Console.WriteLine($"{myGrade} => :(");


            //int sexNum;
            ////sexNum = Gender.Female; // Cannot implicitly convert type'SessionFive.Grads' to 'int'.
            //sexNum = (int)Gender.Female; // Explicit Casting From 'Gender' To 'int'
            //Console.WriteLine(sexNum); // 2 // convert string value "Female" to int

            #endregion


            #region 6 Struct
            /*
             * Struct => The struct (structure) is like a class in C# that is used to store data. 
             
             * A class is a reference type whereas a struct is a value type. 

             * Syntax => <AccessModifier> struct <StructName>
                                          {
                                              <StructBody>
                                          }
                                   
             * Type of Struct :
                               1. Built-in Struct [Pre-Defined] (int, bool, float,..)
                               2. User-defined Struct  

             * Struct Don't Support Inheritance  
            */

            //StructPoint P1; // Declare For Variable Of Type StructPoint
            //                // CLR Will Allocate & Initialize Bytes At Stack

            ////Console.WriteLine(P1.X); // Use of possibly unassigned field 'X'

            //P1.X = 6; // مباشره Attribute هنا انا بكلم ال
            //Console.WriteLine(P1.X); // 6  


            //P1 = new StructPoint(); // new => just for Constructor Selection, not take an object
            //                        // Parameterless Constructor هنا انا بكلم ال

            //Console.WriteLine(P1.X); // 5

            //P1 = new StructPoint(20,40); // Parameterized Constructor هنا انا بكلم ال
            //Console.WriteLine(P1.X); // 20
            #endregion

        }

        public static void SumMul(int x, int y, out int Sum, out int Mul)
        {
            Sum = x + y;
            Mul = x * y;
        }

        public static int SumArray(int[] arr)
        {
            int sum = 0;

            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];
            }

            return sum;
        }

        public static int SumArrayWithParams(int x = 5, params int[] arr)
        {
            int sum = 0;

            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];
            }

            return sum;
        }

        public static void DoSomeCode()
        {
            int X, Y, Z;
            Console.WriteLine("Enter X: ");
            X = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Y: ");
            Y = int.Parse(Console.ReadLine());

            Z = X / Y;

            Console.WriteLine($"{X} / {Y} = {Z}");

            int[] testArr = { 1, 2, 3 };

            testArr[100] = 1;
        }

        public static void DoSomeCodeWithTryCatch()
        {
            try
            {
                DoSomeCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }

        public static void ProtectiveCode()
        {
            int X, Y, Z;

            // 1 - تاني value يدخل رقم فا لازم اهدل جته انه لو دخل اي user انا عارف ان لازم ال
            bool flag;

            do
            {
                Console.WriteLine("Enter X: ");
                flag = int.TryParse(Console.ReadLine(), out X); // لو متمش false تم و cast لو ال true هتبقي ب flag1 ال
            } while (!flag);

            do
            {
                // 2- ممكن الرقم ده يبقي 0 فا لازم اهندل الجزء ده
                Console.WriteLine("Enter Y: ");
            } while (!int.TryParse(Console.ReadLine(), out Y) || Y == 0);
            // تاني loop ب 0 خش في ال Y او لو ال False ب Casting هنا انا بقله لو ال 


            Z = X / Y;

            Console.WriteLine($"{X} / {Y} = {Z}");

            int[] testArr = { 1, 2, 3 };

            //3- index 100 في value في ارقام اكتر من 100 رقم ولو فيه هحط testArr عايز اتأكد الاول ان ال
            if (testArr?.Length > 100)
                /* testArr?.Length will evaluate to null هيبقي testArr equal null بتتأكد لو null-conditional operator (?) ال
                 testArr?.Length will return the length of the array هيبقي ال testArr not equal nul ولو
                */
                testArr[100] = 1;
        }
    }
}
