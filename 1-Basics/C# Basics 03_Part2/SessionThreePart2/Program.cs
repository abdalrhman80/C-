///////////////////////////// 1 Control Statements (Loop Statements) /////////////////////////////

#region Loop Statements
/*
 * لانها بتقلل سطور الكود Developer مش احسن حاجة بس ميزتها ليا انا ك Performance كا Loops ال 
*/

#region For
/*
 * Collection(Array - ArrayList) انا عارف بدايته ونهايته ولما احتاج الف علي Block of code بستخدمها لما يكون عندي
 * Indexهنا انا اقدر اوصل لل
 
 * Syntax -> for (<CounterInitialization> ; <LoopCondition>; <CounterIncrement>)
             {
                 <Block Of Code>   
             }
*/
//Console.WriteLine(1);
//Console.WriteLine(2);
//Console.WriteLine(3);
//Console.WriteLine(4);
//Console.WriteLine(5);
//Console.WriteLine(6);
//Console.WriteLine(7);
//Console.WriteLine(8);
//Console.WriteLine(9);
//Console.WriteLine(10);
//// 10 Statements [10 step]
//Console.WriteLine("---------------------------");

////int[] NumbersArr1 = { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10 }; // Length = index + 1
////for (int i = 0; i < NumbersArr1.Length; i++)
////{
////    Console.WriteLine(NumbersArr1[i]);
////}

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i); // 32 Statements [32 step]
//    /*
//      * 1. i = 1
//      * 2. i <= 10 // true
//      * 3. print (1)
//      * 4. i ++ // i = 2
//      * 5. 2 <= 10 // true
//      * 6. print (2)
//        ........
//        ........
//        ........
//      * 32. i ++ // i = 11
//      * 33. 11 <= 10 // False
//    */
//}
#endregion


#region Foreach
/*
 * [Just For Print] -> Index في الاستخدام بس مختلفه في اني مفدرش اوصل لل For Loop زي ال
 * Syntax ميزتها انها سهله في ال
 * GetEnumerator اسمها Functionاللي من خلاله بوصل ل IEnumerable اسمه Interface يكون بينفذ Collectionعشان تطبع لازم ال 
   foreachازي عكس ال Elements واضح بوصل لل Forلان في ال Elements هيا اللي اوصل لل 
 
 * Syntax -> foreach (<Type> <Item> in <Iterable-item>)
             {
                 <Block Of Code>   
             }
*/
//int[] NumbersArr2 = { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10 };

//foreach (int num in NumbersArr2)
//{
//    Console.WriteLine(num);
//}
#endregion


#region Do While
/*
 * Condition علي ال Check هنا الكود علي الاقل هيتنفذ مره واحده وبعدين 
 
 * Syntax -> do
             {
               <Block of Code>
             } while (<True_Condition>)
*/

//int Number1;

// لغايت الرقم يبقي زوجي  Loop هل الرقم اللي دخلته رقم زوجي ولا فردي ولو فردي مش مش هطلع من ال Check هتتنفذ مره وبعدين  loopهنا ال
//do
//{
//    Console.WriteLine("Please Enter Even Number...");
//    Number1 = int.Parse(Console.ReadLine()); // Exception هيطلع  String هنا لو دخلت 
//} while (Number1 % 2 == 1);

//Console.WriteLine($"{Number1} Is Even");

#region TryParse
/*
 * Converts the string into various data types while avoiding exceptions.
 * IF Casting successful, returns true and the converted value.
 * IF Casting fails, it returns false without throwing an exception.

 * Syntax -> <CallerType>.TryParse(<StringInput>, out <OutputType> <Output>)
*/

//int Number2;
//bool flag;
//do
//{
//    Console.WriteLine("Please Enter Even Number...");
//    flag = int.TryParse(Console.ReadLine(), out Number2);
//} while (Number2 % 2 == 1 || !flag); // !flag -> false هتبقي Casting fails فا لو ال Condition = true هتشتغل طالما ال loop لان ال

//Console.WriteLine($"{Number2} Is Even");
#endregion

#endregion


#region While
/*
 * loopقبل ما يخش ال Check هيعمل doWhile هنا عكس ال 
 
 * Syntax -> while (<True_Condition>)
             {
               <Block of Code>
             } 
*/

//int num;
//Console.WriteLine("Please Enter Odd Number");
//num = int.Parse(Console.ReadLine());
//while (num % 2 == 0)
//{
//    Console.WriteLine("Please Enter Odd Number");
//}
//Console.WriteLine($"{num} Odd Number");

#endregion

#endregion


///////////////////////////// 2 String Vs String Builder /////////////////////////////
#region String Vs String Builder

#region String
/* 
 * String (Built in Class) is array of characters 
 * Reference Type, But Work as Value Type
*/

//string str1;
// * 1. Declare Reference of type string
// * 2. Allocate 4 Bytes at Stack for Reference str1 (Address)
// * 3. Allocate 0 Bytes at Heap
// * 4. Referring to Default Value For Reference Type => Null 
//*/

//str1 = new string("Abdo");
// * 1. Allocate Required Bytes At Heap For object => (4 char -> 4 * 2 = 8 Bytes)
// * 2. Initialize Value of object (Abdo)
// * 3. Call User-Defined Constructor
// * 4. Assign Reference to allocate object
//*/

//string str2 = "Ahmed"; //Syntax Surge

//str2 = str1; // Abdo

//Console.WriteLine(str1.GetHashCode()); // 68977644
//Console.WriteLine(str2.GetHashCode()); // 68977644

//Console.WriteLine("------------------------");

//str1 = "Ali";

//Console.WriteLine(str1); // Ali
//Console.WriteLine(str2); // Abdo (Why?) => [String Is Immutable (بمعني انه مش بيتغير)]
//                         // Ali بتاع object هتشاور علي ال str1 جديد فا object هوا عمل Ali وحط بدلها str1 اللي في Abdo يعني هوا ممسحش 

//Console.WriteLine(str1.GetHashCode()); // 1999241065
//Console.WriteLine(str2.GetHashCode()); // 627290750

//Console.WriteLine("-----------");

//string messageStr = "Iam ";
//Console.WriteLine(messageStr);
//Console.WriteLine(messageStr.GetHashCode()); // 1961316634

//messageStr += "String"; // New Object 
//Console.WriteLine(messageStr);
//Console.WriteLine(messageStr.GetHashCode()); // 634009782
#endregion


#region String Builder
/*
 * StringBuilder is Reference Type, and Work as Reference Type
 * Mutable (اقدر اعدل عليه)
*/

//using System.Text;


//StringBuilder SB = new StringBuilder();
////SB = "Iam"; // مش هينفعش
//SB.Append("Iam ");
//Console.WriteLine(SB); // Iam
//Console.WriteLine(SB.GetHashCode()); // 54267293
//SB.Append("StringBuilder"); 
//Console.WriteLine(SB);// Iam StringBuilder // Mutable
//Console.WriteLine(SB.GetHashCode()); // 54267293

#endregion

#endregion


///////////////////////////// 3 Arrays /////////////////////////////

#region Arrays /* Fixed Size */

#region 1D Array
/*
 * Syntax -> <Type>[] <ArrayName> = new <Type>[<ArraySize>]{.....};
             OR
             <Type>[] <ArrayName> = {.....};
             

 * Index Start from 0
 * Length = Indexes + 1
 * Use ForLoop To Print Array Items
*/

//int[] Numbers;
/*
  * Declare Reference From Type "Array of int"
  * Referring To The Default Value Reference Type => Null
  * CLR Will Allocates 4 Bytes At stack For Reference
  * CLR Will Allocates 0 Bytes At Heap
*/


//Numbers = new int[3]; /* 
//                       * Allocates 12 (4 Bytes * 3) Bytes At Heap
//                       * Initialize With Default Value for int => 0
//                      */

//Console.WriteLine(Numbers[0]); // 0

//Numbers[0] = 5;
//Numbers[1] = 20;
//Numbers[2] = 40;
////Numbers[3] = 80; // Exception -> Index was outside the bounds of the array (Size = 3 محددلها Numbers عشان ال)


//Console.WriteLine(Numbers[0]); // 5

//int[] Numbers2 = new int[] { 10, 20, 30, 40 };

//int[] Numbers3 = { 60, 70, 80 };

//Console.WriteLine($"Size Of Array = {Numbers3.Length}, Number of Dimension = {Numbers3.Rank}"); // 3, 1

//for (int i = 0; i < Numbers3.Length; i++)
//{
//    Console.WriteLine(Numbers3[i]);
//}
#endregion


#region 2D Array

#region Rectangular Array
/*
 * Syntax -> <Type>[,] <ArrayName> = {{.....}, {.....}, ....};
             OR
             <Type>[,] <ArrayName> = new <Type>[<Row> , <Columns>] {{.....}, {.....}, ....};

 *  Two Loops ب Two D Array بتعامل مع ال
     * Loop For Rows
     * Loop For Columns
*/

////int[,] Marks = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } }; 
////              // Allocate 60 (15 * 4) Bytes at Heap
////Console.WriteLine($"Size Of Array = {Marks.Length}, Number of Dimension = {Marks.Rank}"); // 15, 2
////Console.WriteLine($"Number of Rows = {Marks.GetLongLength(0)}"); //3
////Console.WriteLine($"Number of Columns = {Marks.GetLongLength(1)}"); // 5


/////////// ادخله درجات الطلاب و يطبعهم Program هعمل /////////


//int[,] Marks = new int[2, 4]; //2-> Students , 4 -> Subjects


////// Loop For Reading Data From User
//for (int i = 0; i < Marks.GetLength(0); i++) // Loop For Rows
//{
//    Console.WriteLine($"\nEnter Marks Of Student {i + 1}");
//    Console.WriteLine("-------------------------");

//    for (int j = 0; j < Marks.GetLength(1); j++) // Loop For Columns
//    {
//        Console.WriteLine($"\nEnter Subject Number {j + 1}");
//        Marks[i, j] = int.Parse(Console.ReadLine());
//    }
//}

//Console.WriteLine("--------------------------------------------");

////// Loop For Print Data
//for (int i = 0; i < Marks.GetLength(0); i++) // Loop For Rows
//{
//    Console.WriteLine($"\nGrades Of Student {i + 1}");
//    Console.WriteLine("------------------");

//    for (int j = 0; j < Marks.GetLength(1); j++) // Loop For Columns
//    {
//        Console.WriteLine($"Subject Number {j + 1} = {Marks[i, j]}");
//    }
//}

//Console.WriteLine($"\nStudent Number 2 : Subject Number 3 Grade = {Marks[1, 2]}");
#endregion


#region Judged Array

#endregion

#endregion


#region Array Methods

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
                 7- Array.IndexOf(<Array>, <Value>); -> [Return int] 
                 8- Array.LastIndexOf(<Array>, <Value>); -> [Return int] 

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
//// int من نوع array جوا assign ممكن يتغير وانا بعمل typeof عشان ال Explicit Casting لازم ال

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

#endregion


///////////////////////////// 4 Boxing Vs Unboxing /////////////////////////////

#region Boxing Vs Unboxing
/*
 * Boxing [Implicate Casting] => - Converting ValueType Into ReferenceType (Specifically, An Object).
 
                                 - Thereby Storing It On The Heap Instead Of The Stack.
 

 * Unboxing [Explicate Casting] => - Unboxing Is The Reverse Process, where The ValueType Is Extracted From The Object. 

                                   - This Involves Converting ReferenceType Back Into ValueType. 

                                   - During Unboxing, The System Checks That The Object Being Unboxed Is
                                     Indeed A Boxed Value Of The Specified Value Type.

                                   - If The Check Fails, An InvalidCastException Is Thrown.
*/

#region Ex1

//object obj; /*
//             * Declare Reference (obj) of Type Object
//             * This Reference (obj) Can Refer to An Instance Of Type Object Or Another DataType
//            */

//obj = new object();

//obj = new string("ABC");

//obj = 'A'; // Casting From Char (Value Type) To Object (Reference Type) -> Implicitly => [Boxing]
//Console.WriteLine(obj.GetType()); // System.Char

//obj = 1; // Casting From Int (Value Type) To Object (Reference Type) -> Implicitly => [Boxing]
//Console.WriteLine(obj.GetType()); // System.Int32

//obj = true; // Casting From bool (Value Type) To Object (Reference Type) -> Implicitly => [Boxing]
//Console.WriteLine(obj.GetType()); // System.Boolean

////bool flag = obj; // Cannot implicitly convert type 'object' to 'bool'. An explicit conversion exists 
//bool flag = (bool)obj; // Casting From Object (Reference Type) To bool (Value Type) -> Explicitly => [UnBoxing]
//Console.WriteLine(flag); // true

#endregion

#region Ex2

//int number1 = 123; // value type stored on the stack
//object boxedNumber1 = number1; // [Boxing], now stored on the heap
///*
// * In this example, the int value (number1) is converted into an object and assigned to (boxedNumber1).
// * The value 123 is now stored on the heap. => [123 -----------> new object (123)] => [Boxing]
//*/


//object boxedNumber2 = 123;  // boxed number stored on the heap
//int number2 = (int)boxedNumber2; // [UnBoxing], now stored on the stack
///*
// * In this example, the object (boxedNumber2) is cast back to an int and assigned to (number2).
// * [new object (123) -----------> 123] => [UnBoxing]
//*/


//object O2 = 10;
//O2 = "Abc";
//int Y = (int)O2;

//Console.WriteLine(O2); // InvalidCastException

#endregion

#endregion