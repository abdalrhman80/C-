namespace SessionFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 Intro To Functions
            /*
             * بستدعيها لما اعوذ استخدمها Block of code عباره عن 
                * (DRY) -> [Don't Repeat yourself] 
                * Single-responsibility 
                * Maintainability

             * Two Components => 
                              * 1- Prototype :
                                           ** Signature : [Return Type, Name, Parameters]
                                           ** Function Body 

                              * 2- Calling 
             
             * Two Types => 
                          * 1- Class Member Function (Static) [<className>.<FunctionName>]=>  classمن خلال ال call بعملها
                          * 2- Object Member Function [<objectName>.<FunctionName>]=>  objectمن خلال ال call بعملها
                          
             * Syntax => 
                       Signature -> <Access Modifier> <Function Type> <Return Type | Void> <FunctionName> (<Parameter>,...)
                                    {
                                      <Function Body>
                                    }
                         
                       Calling -> FunctionName(<Argument>,..) // Passing By Order
                                  OR
                                  FunctionName(<Argument> : <Value>,..) // Passing By Name

              
             * (Standalone Function) مفيش class لازم تكون تبع Function ال 
             * Main Function (Entry Point) جوا ال call هعملها 
             * Parameters و لازم افرقهم عن بعض بال (Overloading) بنفس الاسم دا اسمه Methods ينفع يكون في اكتر من
            
             * Default Value For Parameters => Default Value Parametersاو احط لكل ال Parameter لازم تكون لأخر 
            */

            //// Program.PrintPattern(); // مختلف مش هينفع class اصلا لو في Program انا جوا ال
            //PrintPattern(); // Default Value
            //Console.WriteLine("----------------------");
            //PrintPattern("@");
            //Console.WriteLine("----------------------");
            //PrintPattern("%", 9); // Passing By Order
            //Console.WriteLine("----------------------");
            ////PrintPattern(11,"$"); // مش هينفع
            //PrintPattern(Size: 2, Pattern: "$"); // Passing By Name
            #endregion


            #region 2 Passing Parameters (Value, Reference) Type
            /*
              * Stack جوا ال Stack Frame حاجة اسمها Function بيروح يعمل لكل Project ال Run ب CLR لما ال
                  * Function مع ال Parameters او لو باعت Local Variables بتيخزن فيه ال Stack كل 
                  * بيتمسح Stack Frame بتخلص ال Function ولما ال
           */

            #region Value Type Parameters

            #region Passing By Value
            /*
             * When a parameter is passed by value, a copy of the actual parameter's value is made and passed to the method. 
             * Any changes made to the parameter within the method do not affect the original value outside the method. 
            */

            //int A = 3; int B = 5;
            //Console.WriteLine($"A = {A}, B = {B}"); // A = 3, B = 5

            //Swap(A, B); // Functionجوا ال Swap وهما بيحصلهم Function لل A , B من ال (Copy) هنا انا باعت 
            //            // بينتهي Functionبتاع ال Stack Frame وبمجرد ما اطلع ال
            //            // Function فا اي تغير حصل انتهي بنتهاء ال

            //Console.WriteLine($"A = {A}, B = {B}"); // A = 3, B = 5

            #endregion


            #region Passing By Reference /* ref KeyWord */
            /*
             * When a parameter is passed by reference, a reference (or pointer) to the actual parameter is passed to the method. 
             * Any changes made to the parameter within the method will affect the original value outside the method.

            * This can be achieved using the ref or out keywords in C#.
            */

            //int C = 10, D = 20;
            //Console.WriteLine($"C = {C}, D = {D}"); // C = 10, D = 20

            //SwapWithRef(ref D, ref C); // C,D من ال Reference جديده لاني باعت Variables مش هيروح يعمل SwapWithRef بتاع ال Stack Frame هنا جوا ال    
            //                          // Main اللي جوا ال Variables فا اي تغير هيحصل هيسمع في ال

            //Console.WriteLine("\nAfter Swap .........\n");

            //Console.WriteLine($"C = {C}, D = {D}"); // C = 20, D = 10
            #endregion

            #endregion


            #region Reference Type Parameters

            #region Passing By Value
            /*
             * For reference types, passing by value means that the method receives a copy of the reference to the object,
               but not the object itself. 
             
             * Any changes to the object within the method affect the original object, 
               but reassigning the parameter to a new object does not affect the original reference.
            */

            //int[] NumbersArr = { 1, 2, 3, 4 };

            //Console.WriteLine(NumbersArr[0]); // 1

            //int Summation = SumArray(NumbersArr); 
            ///*
            // * NumbersArr بتاع ال Value (object) ال Function انا بعت لل
            // * Parameter اللي باعته ك object جديد يكون بيشاور علي نفس ال array بيروح يعمل Stack Frame في ال method هوا جوا ال 
            //*/

            //Console.WriteLine(NumbersArr[0]); // 101

            //Console.WriteLine(Summation); // 110

            #endregion


            #region Passing By Reference
            /*
             * For both value and reference types, passing by reference means that the method can modify
               the original value or reference.
             
             * Any changes to the object within the method affect the original object, 
               but reassigning the parameter to a new object affect the original reference.
            */

            //int[] NumbersArr02 = { 1, 2, 3, 4 };

            //int Summation02 = SumArrayWithRef(ref NumbersArr02);
            ///*
            // * (Address) اللي هوا NumbersArr بتاعت ال reference ال Function انا بعت لل
            // * parameter اللي  بعته ك Array بتاع ال object جديد ويكون بيشاور علي نفس ال array يكريت Stack Frame مش بيروح في ال method فا جوا ال
            // * Array فا بيشتغل علي نفس ال (Passing By Reference) لاني عامل  
            //*/
            //Console.WriteLine(Summation02); // 110
            #endregion

            #endregion


            #region Passing By Reference Vs Passing By Value (Difference)
            /*
              * array elements لو انا بعدل علي ال Passing By Reference و Passing By Value مفيش فرق هنا بين ال
              * نفسه array الفرق هيظهر لو بعدل علي ال
            */

            //int[] newArrNumbers01 = { 1, 2, 3, 4 };

            //Console.WriteLine(newArrNumbers01.GetHashCode()); // 54267293
            //Console.WriteLine(newArrNumbers01[0]); // 1

            //int newSummationArray01 = SumNewArray(newArrNumbers01);
            ///*
            // * اللي باعته object مختلف عن ال Identity ب new object بعمل SumNewArray جوا ال
            // * بيشاور عايه Main اللي في ال array اللي ال object بيشاور علي نفس ال parameter اللي باعته ك array فا بعد ما كان ال
            //   method الجديد اللي عملته جوا ال object فا هيشاور علي

            // * تخلص method هتخذف لما ال method اللي عملته جوا ال new object فا ال Passing By Value و بما ان انا هنا عامل 
            //*/

            //Console.WriteLine(newArrNumbers01.GetHashCode()); // 54267293
            //Console.WriteLine(newArrNumbers01[0]); // 1

            //Console.WriteLine(newSummationArray01); // 22

            //Console.WriteLine("/////////////////////////////////////////////////////////////////////");

            //int[] newArrNumbers02 = { 11, 12, 13, 14 };

            //Console.WriteLine(newArrNumbers02.GetHashCode()); // 18643596
            //Console.WriteLine(newArrNumbers02[0]); // 11

            //int newSummationArray02 = SumNewArrayWithRef(ref newArrNumbers02);
            ///*
            // * new object هيكريت SumNewArrayWithRef وجوا ال Passing By Reference هنا انا عامل
            //   SumNewArrayWithRef اللي كريته جوا ال new object اللي باعته هيشاور علي ال array فا ال
            //   Reference لاني باعت Main بتاع ال Stack Frame والكلام ده هيتم جوا ال
            //*/

            //Console.WriteLine(newArrNumbers02.GetHashCode()); // 33574638
            //Console.WriteLine(newArrNumbers02[0]); // 4

            //Console.WriteLine(newSummationArray02); // 22

            #endregion


            #endregion


            #region 3 Nullable
            /*
             * Null Is Valid Value For Reference Type Only
             * Nullable => Allows Null For Value Types + All Values Of it's underlying Type
             
             * Syntax => Nullable <Value Type> <VarName>;
                         OR
                         <Value Type>? <VarName>; // Syntax Sugar
            */


            #region Nullable - Value Types

            //int age = 22;
            //age = 23;
            ////age = null; // Cannot convert null to 'int' because it is a non - nullable value type

            //int? x = 10; // Nullable Integer : Allows Null For 'int' Values  (int values + null)
            //x = null;

            //Nullable<int> y;
            //y = 10;
            //y = null;

            //double? Salary = 2200.53; // Nullable Integer : Allows Null For 'double' Values  (double values + null)
            //Salary = null; 

            #region Work with Nullable Value Type /* Casting */

            #region 1-Implicit Casting
            //int A = 5;
            //int? B
            //B = A; // B May Have Null or int
            #endregion

            #region 2- Explicit Casting
            //int? C = 10;
            //int D = 30;
            //D = (int)C;

            //int? N = null;
            //int I = 30;
            //I = (int)N; // InvalidOperationException // Nullable object must have a value.
            #endregion

            #region 3- Nullable<T>.HasValue + Nullable<T>.Value
            /*
            * Nullable<T>.HasValue => Return 'True' If Nullable<T> object has value, 
                                      Return 'False' If Nullable<T> object has no value (null)

            * Nullable<T>.Value => The value of the Nullable<T> object if the HasValue property is true 
           */
            //int? X = null;
            //int Y = 20;
            //Y = X.HasValue ? X.Value : Y;
            //Console.WriteLine(Y); // 20
            #endregion

            #region 4- Coalescing Operator (??) /* Syntax Suger */
            /*
             * The null-coalescing operator (??) returns the value of its left-hand operand if it isn't null; 
             * otherwise, it evaluates the right-hand operand and returns its result. 
            */
            //int? Q = null;
            //int U;
            //U = Q ?? 0; // Will return the value of Q if Q is not null else return 0
            //Console.WriteLine(U); // 0
            #endregion

            #endregion

            #endregion

            #region Nullable - Reference Types (C# 8)
            /*
             * By default, reference types in C# are nullable, meaning they can hold null values.
             * This flexibility, while convenient, can lead to runtime null reference exceptions that can be difficult to debug. 
             * Nullable String مثلا هيكون فاضي مفهومش قيمه خلي String لو انا عارف ان 
             * Warning بس Exception هوا مش هيطلع 
            */

            //string message01 = "Hello";
            //message01 = null;
            //Console.WriteLine(message01); //

            //string? message02 = null;
            //Console.WriteLine(message02); //

            //message01 = message02!; /* Null Forgives (!) */
            #endregion

            #region Null Propagation Operator


            #endregion

            #endregion

        }

        /* Prototype */
        public static void PrintPattern(string Pattern = "#", int Size = 5)
        {
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(Pattern);
            }
        }

        public static void Swap(int x, int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }

        public static void SwapWithRef(ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }

        public static int SumArray(int[] arr)
        {
            int Sum = 0;

            arr[0] = 101;

            if (arr != null)
                for (int i = 0; i < arr.Length; i++)
                    Sum += arr[i];

            return Sum;
        }

        public static int SumArrayWithRef(ref int[] arr)
        {
            int Sum = 0;

            arr[0] = 101;

            if (arr != null)
                for (int i = 0; i < arr.Length; i++)
                    Sum += arr[i];

            return Sum;
        }

        public static int SumNewArray(int[] arr)
        {
            int Sum = 0;

            arr = new int[] { 4, 5, 6, 7 };

            if (arr != null)
                for (int i = 0; i < arr.Length; i++)
                    Sum += arr[i];

            return Sum;
        }

        public static int SumNewArrayWithRef(ref int[] arr)
        {
            int Sum = 0;

            arr = new int[] { 4, 5, 6, 7 };

            if (arr != null)
                for (int i = 0; i < arr.Length; i++)
                    Sum += arr[i];

            return Sum;
        }
    }
}
