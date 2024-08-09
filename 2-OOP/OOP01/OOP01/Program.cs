// اللي عايز استخدمه فيه projectليه في ال reference  تاني لازم اضيف project علي حاجة من access عشان اقدر 
using Common;
using OOP01.Encapsulation;

namespace OOP01
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 Access Modifiers
            /*
             * Access modifiers specify the accessibility of types (classes, interfaces, etc) 
               and type members (fields, methods, etc).
            */

            #region Types of Access Modifiers
            /*      
             * 1. Public
                  * When we declare a type or type member public, it can be accessed from anywhere.  
                  
             * 2. Internal 
                  * When we declare a type or type member internal, it can be accessed only within 
                    the same Project (Assembly File). 
            
             * 3. Private
                  * When we declare a type member with the private access modifier, it can only be accessed
                    within the same class or struct. 
             
             * 4. Protected
                  * When we declare a type member as protected, it can only be accessed from the same class 
                    and its derived classes.
             
             * 5. Protected Internal [Combination of protected and internal access modifiers]
                 * When we declare a member protected internal, it can be accessed from the same project, 
                   and the derived class of the containing class from any (other project).
             
             * 6. Private Protected [Combination of private and protected access modifiers (C# 7.2)]
                 * When we declare a member private protected, it can only be accessed within the same class,
                   and its derived class within the (same project).
            */
            #endregion

            #region What We Can Written...

            #region namespace

            #region What Can We Written inside namespace (Types)?
            /*
              * 1. class
              * 2. struct
              * 3. enum
              * 4. interface   
            */
            #endregion

            #region Allowed Access Modifiers inside namespace for (class or struct or enum or interface) :
            /*
              * 1. Internal (Default Access Modifiers)
              * 2. Public
            */
            #endregion

            #endregion

            #region class & struct 

            #region What Can We Written inside class or struct (Type Members)?
            /*
              * 1. Attributes [Fields]
              * 2. Property (Full Property - Automatic Property - Index)
              * 3. Methods (Constructor [Special Method With Same Name Of The Class] - Getter & Setter Methods)
              * 4. Event
            */
            #endregion

            #region Allowed Access Modifiers inside Struct
            /*
              * 1. Privet (Default Access Modifiers)
              * 2. Internal
              * 3. Public 
              
              * C لانه في الاساس تبع ال Inheritance مش بيدعم ال Struct ال  
                Inheritance بيشتغل مع ال Protected لان ال Protected من نوع Access Modifiers وعشان كدا مش مسموح لأي 
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

            #endregion

            #region Interface
            // Interface => حاجة لما اجي استخدمها لازم التزم بكل اللي موجود جواه + ممكن ازود

            #region What Can We Written inside Interface (Type Members)?
            /*
               * 1. Signature For Methods 
               * 2. Signature For Property 
               * 3. Default Implemented Property (C# 8 - .net 3.1)
               * 4. Default Implemented Methods (C# 8 - .net 3.1)
            */
            #endregion

            #region Allowed Access Modifiers inside Interface?
            /*
             * Allowed Access Modifiers inside Interface :
               * 1. Privet
               * 2. Privet Protected
               * 3. Protected
               * 4. Internal
               * 5. Internal Protected
               * 6. Public (Default Access Modifiers)
            */
            #endregion

            #endregion

            #region Enum
            /*
              * What Can We Written inside Enum => Labels Only Without Access Modifiers 
            */
            #endregion

            #endregion

            TypeA obj = new TypeA();
            //obj.X = 10; // X => privet ('TypeA.X' is inaccessible due to its protection level)
            //obj.Y = 20; Y => internal ('TypeA.X' is inaccessible due to its protection level)
            obj.Z = 30;

            #endregion

            #region 2 What is OOP (Object-Oriented Programming)
            /*
             * طريقة شغل بتحاكي الحياة الواقعية (Paradigm) هوا عباره عن
             * قايمة علي 4 مباديء OOP ال
               * 1. Encapsulation 
               * 2. Polymorphism (Overloading , Overriding)
               * 3. Inheritance
               * 4. Abstraction
               
             * OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug. 
             * Classes and objects are the two main aspects of object-oriented programming.
            */
            #endregion

            #region 3 Encapsulation
            /*
             * Separate Attribute Definition Form It's Using 
               * This Achieve By [Getter , Setter Method] Or [Property]
             
             * بيوفر شوية حاجات زي Encapsulation ال 
               * 1. Direct عليه access التانيه لو انا عامل Projects لو غيرت اسمه هيسمع في ال Attribute ال 
               * 2. Data Validation
               * 3. Security (privet access modifier on attribute)
            */

            //Employee emp01 = new Employee(); // Parameterless Constructor كدا انا مستخدم ال
            //                                 // هستخدمه Constructor هيا اللي بتحدد اي new ال

            //Console.WriteLine(emp01.ToString()); // 0,  ,0

            //Console.WriteLine("-------------------------------------------------------");

            //Employee emp02 = new Employee(5, "Ahmed", 7000, 23);
            //Console.WriteLine(emp02.ToString()); // 5, "Ahmed", 7000, 23

            //Console.WriteLine("-------------------------------------------------------");

            //emp02.Id = 6; // Set Id Directly Through Attribute (ودا انا مش عايزه)
            //Console.WriteLine($"Get Id Directly Through Attribute : {emp02.Id}"); // 6

            //Console.WriteLine("-------------------------------------------------------");

            ////emp02.Name = "Abdalrhman"; //Employee.Name' is inaccessible due to its protection level
            //emp02.SetName("Abdalrhman"); // Set Name Using Setter Method Not Attribute
            //Console.WriteLine($"Get Name Using Getter Method : {emp02.GetName()}");

            //Console.WriteLine("-------------------------------------------------------");

            //emp02.Salary = 6500; // Set Salary Using Property
            //Console.WriteLine($"Get Salary Using Full Property {emp02.Salary}");

            //Console.WriteLine("-------------------------------------------------------");

            //emp02.Age = 24;
            //Console.WriteLine($"Get Age Using Automatic Property {emp02.Age}");
            #endregion

            #region 4 Class

            //Car C1; 
            /*
             * Declarer Reference From Type Car
             * C1 Can Refer To Object From Type Car
             * CLR Will Allocate 4 Bytes For Reference In Stack
             * Zero Bytes At Heap
            */

            //C1 = new Car(); // Call Parameterless Constructor
            /*
             * Struct غير في ال Class في ال new ال
             * 1. Allocate Required Bytes At Heap
             * 2. Initialize Allocated Bytes At Heap With Default Value
             * 3. Call User Defied Constructor If Exists
             * 4. Assign Reference (C1) To Allocated Object At Heap
            */

            //Console.WriteLine(C1.ToString()); // 0,  , 0

            //Console.WriteLine("-------------------------------------------------------");

            //Car C2 = new Car(2, "BMW", 100); // Call User-Defined Constructor
            //Console.WriteLine(C2.ToString()); // 2, BMW, 100

            //Console.WriteLine("-------------------------------------------------------");

            //Car C3 = new Car(3, "Honda");
            //Console.WriteLine(C3.ToString()); // 3, BMW, 150

            //Console.WriteLine("-------------------------------------------------------");

            //Car C4 = new Car(4);
            //Console.WriteLine(C4.ToString()); // 4, Ferrari, 200
            #endregion
        }
    }
}
