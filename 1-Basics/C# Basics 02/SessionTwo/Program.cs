using SessionTwo;
///////////////////// 1 Project Hierarchy /////////////////////
#region Project_Hierarchy

#region  .Net 5 Hierarchy

/*
  *** namespace : Project وبيكون بنفس اسم ال Project بحط جواه اي حاجه خاصة بال
                  (Struct - Interface - Class -  Enumn)
                                
    ** class : * class بمعني اي حاجة هكتبها لازم تكون تبع OOP الاساسية في ال Unit ال
               * Functions او Variables  بقدر احط  class جوا ال   
               * Program في الغالب بيكون اسمه main class ال 
     
       * Main Function (Entry Point) : Function فا لازم احط الكود جوا ال Per Function Call بتحصل Jitting عمليه ال
                                       من عندها Run ان دي النقطة اللي هتبدأ تعمل Compiler واعرف اال     
*/


// using System; // System class: Using عملها .net 6 في  Built in بيبقي  
// using static System.Console; // class ل using مش بروح اعمل
//namespace SessionTwo
//{
//    class Program
//    {
//        static void Main()
//        {
//            // System.Console.WriteLine("Hello World");
//            // WriteLine("Hello World");
//            Console.WriteLine("Hello .Net 5");
//        }
//    }
//}
#endregion

#region .Net 6 Hierarchy
/**
 * Background بقي مش لازم اكتبها هيا بقت مكتوبه في ال .Net 6 من اول .Net 5 اللي في Hierarchyكل ال
*/
//Console.WriteLine("Hello .Net 6");
//Console.ReadLine();
#endregion

#endregion


///////////////////// 2 About C# /////////////////////
#region About_C#
/*
 ** CaseSensitive C# ال
 ** semicolonلازم اكتب ال
 
 ** Compiler vs Interpreter
    -----------------------
    * Compiler (C++, C#) -> - Native Language الي Code هو اللي بيحول ال
                            - Run مش هيعمل Error كله فا لو في Code لل Compilation بيعمل 

    * Interpreter (JS) -> - Scripting Language بس بيكون خاص لل Compiler نفس وظيفه ال
                          - ويقف Error فا هوا هيشتغل لغايت ما يجي عند السطر اللي ظهر في Line By Line بيمشي 

 ** Errors Types
    -------------
    * 1- Syntax Error -> (Compilation Time بيحصل في ال)
    * 2- Logical Error [Bug] 
    * 3- Run Time Error [Exception] -> (Run Time بيحصل في ال)
    * 4- Warning 
    
 ** Variable
    --------
    * <Datatype> <Name> = <Value>;
    
 ** Naming Notation
    --------------- 
    * Camelcase (variableOne) -> variables
    * Pascalcase (FunctionOne) -> methods and classes
    * Kabab-case (variable_one)
*/

//int varOne = 10;
//Console.WriteLine(varOne);
#endregion


///////////////////// 3 CTS and CLS /////////////////////
#region CTS and CLS
/*
 *** CTS (Common Type System) -> CLS + Dot net اللي موجوده في ال Datatypes جوا ال 
    ** CLS (Common Language Specification) -> Dot net خصائص مشتركه بين لغات ال
                                             IL ويتحولوا لنفس Project هيا اللي بتخليني اقدر اكتب بأكتر من لغه في ال
*/
#endregion


///////////////////// 4 Data Types /////////////////////
#region DataTypes
/*
 *** Data Types in .Net Divided into 2 Categories :
    ** 1- Value Type (Primitive) 
       *  Stack [FILO] بيتخزنوا في ال Value Type اللي من نوع Variables ال  
       *  Variables ببقي عارف حجم ال
       
    ** 2- Reference Type (Non Primitive) 
       * Stack بتاعها بيتخزن في ال Address وال Heap بتتخزن في ال Value ال Reference Type اللي من نوع Variables ال  
       * Variables مش عارف حجم ال

 *** 1. Struct (Value Typed) :
        ** Built In Types :
           * Byte       Sbyte (Pos,Neg)      1 Byte | 
           * Short      UShort(Neg Only)     2 Byte | [Integer Numbers]
           * int        Uint                 4 Byte | 
           * Long       Ulong                8 Byte |  
          
           * Float                          4 Byte  | 
           * Double                         8 Byte  | [Fraction Numbers]
           * Decimal                        16 Byte | 
                                            
           * Char                            2 Byte | 
           * Bool                            1 Byte | 
           * Datetime                        8 Byte |  
           
        ** User Defined Types :


 *** 2. Enum (Value Typed) :
        ** Built In Types :
        ** User Defined Types :


 *** 3. Class (Reference Typed) :
        ** Built In Types :
           * Object (object)
           * String
           * Array 
           * Delegate -> (تانيه Functionل Function زي اني اباصي Structure Programing الموجوده في Featuresلل Implement بيخليني اقدر اعمل  C#مومجود في ال)
       
        ** User Defined Types :
   

 *** 4. Interface (Reference Typed) :
        ** Built In Types :
        ** User Defined Types :
 
*/
#endregion


///////////////////// 5 DataTypes - Value Type /////////////////////
#region ValueType
//int X; // Allocate 4 Uninitialized Bytes in Stack [Declaration]
//X = 4;
//Int32 Y = 9; // Int32 [BCL] = int [C#]
//Y = X; // 4  (مش هتتغير Yقيمه ال X لل Reassign ولو عملت X خدت نسخه من ال)
//X++; // 5
//Console.WriteLine("X = " + X);
//Console.WriteLine("Y = " + Y);
#endregion


///////////////////// 6 DataTypes - Reference Type /////////////////////
#region ReferenceType
/*
  ** class or interface عباره عن Reference Type من نوع Data أي
*/

// User-Defined class // Main class (Program) لان انا هني جوا Readable لوحده برا عشان الكود يبقي class بروح اعمل 
//class point
//{
//    public int X; //4 Bytes   
//    public int Y; //4 Bytes   
//}

//point P1; // point من نوع Reference (Variable) {Reference -> [Address عشان بيشيل]}
/*                 
  - Allocate 4 Bytes in Stack -> (Address عشان)
  - Zero Bytes Allocate at Heap
*/

//P1 = new point(); // point هيكون شايل حاجة من نوع P1ال
/*
   * 1. Allocate Required Bytes at Heap -> [Object Size (4 Bytes to X, 4 Bytes to Y)  + CLR Overhead Variables]

   * 2. Initialize (Cross Out) Allocated Bytes Of Object -> [Default Value for Datatype -> (Zero to int)]
   
   * 3. Call User Defined Constructor If Exist
   
   * 4. Assign Reference (P1) To Allocated Object
*/

//point P2 = new point();
//P2 = P1;
/*
 * Address هيكونوا بيشاور علي نفس ال P2 , P1  
 * Address لانه مش بيشاور علي Unreachable object هيبقي P2 وكدا 
 * garbage collector بتتملي بيظهر حاجة اسمها Heap دا هيعمل مشكله لان لما ال Unreachable object ال 
   ويمسحهم والمشكله انه بيوقف البرنامج لغايت ما يخلص Unreachable objects ودا وظيفته انه بيلم كل ال
*/

//P1.X = 9;
//P1.Y = 10;
//P2.X = 20;

//Console.WriteLine("P1.X = " + P1.X + " , " + "P1.Y = " + P1.Y);
//Console.WriteLine("P2.X = " + P2.X + " , " + "P2.Y = " + P2.Y);
#endregion


///////////////////// 7 Object /////////////////////
#region Object
/*
   **** Object (object) -> Built in class
       *** ودا عشان سببين Object class لازم تورث من ال Build-In او User-Defined سواء Datatype اي 
       
           ** 1. Generics (قبل 2005 C#مكنش في الفكره دي في ال)
           
             public static void Print1 (object item)
             {
                 Console.WriteLine(item);
             }
             Print1(2); 
             Print1(“Ahmed”); 
             ----------------------------------
             public static void Print2<T> (T item)
             {
                 Console.WriteLine(item);
             }
             Print2<int>(2); 
             Print2<string>(“Ahmed”); 


           ** 2. Set Of Behaviors (Functions) Should be Existed at any data type
               * 1- ToString() -> [String بتحول اي حاجة الي]
               * 2- <Object>.GetHashCode() -> [Memoryاللي في ال References بتاع ال Address ودا بيبقي بناء علي ال Unique_ID بترجع]
               * 3- <Object>.Equals(<Object>) -> [bool value وبترحع Two Object بتقارن]
               * 4- <Object>.GetType()
*/

//point p3 = new point();
//point p4 = new point();

//object o1 = new object();

//Console.WriteLine("P3 HashCode-> " + p3.GetHashCode());
//Console.WriteLine("P4 HashCode-> " + p4.GetHashCode());
//Console.WriteLine("P3 Equal P4?-> " + p3.Equals(p4)); // False -> مختلف Address لان كل واحد شايل
//Console.WriteLine("-----------------");

//p3 = p4;
//Console.WriteLine("P3 HashCode-> " + p3.GetHashCode());
//Console.WriteLine("P4 HashCode-> " + p4.GetHashCode());
//Console.WriteLine("P3 Equal P4 (After Assign)? -> " + p3.Equals(p4)); // True
//Console.WriteLine("-----------------");

//Console.WriteLine("O1 HashCode-> " + o1.GetHashCode());
//Console.WriteLine("P3 HashCode-> " + p3.GetHashCode());
//Console.WriteLine("P3 Equal O1? -> " + p3.Equals(o1));
//Console.WriteLine("-----------------");

//o1 = p3;
//Console.WriteLine("O1 HashCode-> " + o1.GetHashCode());
//Console.WriteLine("P3 HashCode-> " + p3.GetHashCode());
//Console.WriteLine("P3 Equal O1 (After Assign)? -> " + p3.Equals(o1));
//Console.WriteLine("-----------------");

//Console.WriteLine("P4 Equal O1? -> " + p4.Equals(o1));
//Console.WriteLine("-----------------");
#endregion


///////////////////// 8 Fractions and Discard /////////////////////
#region Fractions
/*
   * double d = 3.5 -> Main Datatype for Fraction Numbers 
   * float f = 3.5F -> float عشان لو عايز اخون رقم عشري في F(f)لازم اكتب ال
   * decimal c = 3.7M -> decimal عشان لو عايز اخون رقم عشري في M(m)لازم اكتب ال
*/
double d = 3.5;
float f = 3.6F;
decimal c = 3.7M;

int discard = 1_000_000; // Discard (_) -> Readability بستخدمها عشان ال
#endregion


///////////////////// 9 Value Types Casting /////////////////////
#region Casting
/*
   ** 1. Implicit Casting
   ** 2. Explicit Casting
   ** 3. Parse
   ** 4. Convert
*/
//Console.WriteLine("CR" + 7); //Implicit Casting

#region Parse 
/* Parse -> [Method used for casting from string to a caller datatype]
            Syntax-> <caller datatype>.Parse("String Value")
*/
//int valueOne;
//Console.WriteLine("Enter Number One..");
//valueOne = int.Parse(Console.ReadLine()); // Console.ReadLine() -> return string 
//Console.WriteLine("Number One You Entered => " + valueOne);
#endregion


#region Convert
/*Convert -> [Class containing a set of methods used for casting from datatype to any data type]
             Syntax-> Convert.<Method That Will Be Convert Value>(<Value To Convert>)
*/
//int valueTwo;
//Console.WriteLine("Enter Number Two..");
//valueTwo = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Number Two You Entered => " + valueTwo);

#endregion

//string strBool = "Trueee";
//Console.WriteLine(Convert.ToInt32(bool.Parse(strBool))); //Exception
// TryParse عشان كدا هستخدم Exception اللي عايزها هيضرب Datatype اللي بحولها مينفعش تتحول لل Value ليهم عيب ان لو ال Convert , Parse  
#endregion