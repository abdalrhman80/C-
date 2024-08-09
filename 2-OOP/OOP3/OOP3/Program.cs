using OOP3.Binding.Example01;
using OOP3.Binding.Example1;
using OOP3.Binding.Example2;
using OOP3.Interfaces.Example1;
using OOP3.Interfaces.Example2;
using OOP3.Interfaces.Example3.Classes;
using OOP3.Interfaces.Example3.Interfaces;
using OOP3.OOP3.Built_In_Interfaces;

namespace OOP3
{
    internal class Program
    {
        #region Binding Example
        public static void ProcessEmployeeBasedOnChild(FullTimeEmployee Emp)
        {
            if (Emp is not null)
            {
                Emp.WhoYouAre();
                Emp.Print();
            }
        }

        // Parameter في الاتنين بتعمل نفس الحاجة الاختلاف بس اني غيرت ال Method لان ال Overloading دا كدا ميعتبرش 

        public static void ProcessEmployeeBasedOnChild(PartTimeEmployee Emp)
        {
            if (Emp is not null)
            {
                Emp.WhoYouAre();
                Emp.Print();
            }
        }

        public static void ProcessEmployeeBasedOnParent(Employee Emp)
        {
            if (Emp is not null)
            {
                Emp.WhoYouAre(); // Static Binding
                Emp.Print(); // Dynamic Binding
            }
        }
        #endregion

        #region Interface Example2

        public static void PrintTenNumbersFromSeriesWithClassParameter(SeriesByTwo series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(series.Current);
                    series.GetNext();
                }
                series.Reset();
            }
        }

        public static void PrintTenNumbersFromSeriesWithClassParameter(SeriesByThree series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(series.Current);
                    series.GetNext();
                }
                series.Reset();
            }
        }

        public static void PrintTenNumbersFromSeriesWithInterfaceParameter(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(series.Current);
                    series.GetNext();
                }
                series.Reset();
            }
        }

        #endregion

        static void Main(string[] args)
        {
            #region 1 Binding

            #region 1.1 What Is Binding
            /*
             * Binding Is A Behavior.
             * Binding Is A Reference From Parent, But Refer To Object From Child.
            */

            //TypeA01 BaseRef = new TypeB01(1, 2);

            //BaseRef.A = 3;
            ////BaseRef.B = 4; // BaseRef Can Access Only Members In Reference Class (TypeA01)

            #region Static / Early Binding 
            /* 
             * Compiler Will Bind Function Call Based On Reference Not Object.
             * Happened At  Compile Time.
             * The compiler knows exactly what code to execute.
            */

            //BaseRef.WhereAmI(); // Iam In Parent => WhereAmI() Override with [new] keyword.
            #endregion

            #region Dynamic / Late Binding
            /*
             * Compiler Will Bind Function Call Based On Object Not Reference.
             * Happened At RunTime.
            */

            //BaseRef.Print(); // TypeB : A = 3 , B = 2  => Print() Override with [virtual, override] keywords.
            #endregion

            //TypeA01 Ref1 = new TypeB01(1, 2); // Binding

            //TypeB01 Ref2 = (TypeB01)Ref1; // Casting

            //Console.WriteLine($"{Ref2.A}, {Ref2.B}"); // 1, 2

            #endregion

            #region 1.2 Binding Is A Behavior?

            #region Example 1

            //FullTimeEmployee emp1 = new FullTimeEmployee()
            //{
            //    // Object Initializer
            //    Id = 1,
            //    Name = "Abdalrhman",
            //    Age = 23,
            //    Salary = 8000
            //};

            //ProcessEmployeeBasedOnChild(emp1); // Iam Full Time Employee //Employee ID : 1 , Employee Name : Abdalrhman , Age: 23 , Salary: 8000

            //Console.WriteLine("--------------------------------------------------------------------");

            //PartTimeEmployee emp2 = new PartTimeEmployee()
            //{
            //    Id = 2,
            //    Name = "Ahmed",
            //    Age = 24,
            //    HourRate = 20
            //};

            //ProcessEmployeeBasedOnChild(emp2); // Iam Part Time Employee // Employee ID : 2 , Employee Name : Ahmed , Age: 24 , HourRate : 20

            //Console.WriteLine("--------------------------------------------------------------------");

            //FullTimeEmployee emp3 = new FullTimeEmployee()
            //{
            //    Id = 3,
            //    Name = "Emad",
            //    Age = 30,
            //    Salary = 8000
            //};

            //ProcessEmployeeBasedOnParent(emp3); // Iam Employee // Employee ID : 3 , Employee Name : Emad , Age: 30 , Salary: 8000

            //Console.WriteLine("--------------------------------------------------------------------");

            //PartTimeEmployee emp4 = new PartTimeEmployee()
            //{
            //    Id = 4,
            //    Name = "Ali",
            //    Age = 28,
            //    HourRate = 20
            //};

            //ProcessEmployeeBasedOnParent(emp4); // Iam Employee //  Employee ID : 4 , Employee Name : Ali , Age: 28 , HourRate : 20

            #endregion

            #region Example 2
            //TypeA RefA01 = new TypeC(1, 2, 3);
            //RefA01.A = 10;
            ////RefA01.B = 11; Invalid
            ////RefA01.C = 12; Invalid
            //RefA01.WhereAmI(); // Iam Type A
            //RefA01.Print(); // TypeC : A = 10 , B = 2 , C = 3

            //Console.WriteLine("-------------------------------------");

            //TypeB RefB01 = new TypeC(1, 2, 3);
            //RefB01.A = 20;
            //RefB01.B = 11;
            ////RefB01.C = 12; Invalid
            //RefB01.WhereAmI(); // Iam Type B
            //RefB01.Print(); // TypeC : A = 20 , B = 11 , C = 3

            //Console.WriteLine("-------------------------------------");

            //TypeA RefA02 = new TypeE(1, 2, 3, 4, 5);
            //RefA02.WhereAmI(); // Iam Type A
            //RefA02.Print(); // TypeC : A = 1 , B = 2 , C = 3 

            //Console.WriteLine("-------------------------------------");

            //TypeB RefB02 = new TypeE(1, 2, 3, 4, 5);
            //RefB02.WhereAmI(); // Iam Type B
            //RefB02.Print(); // TypeC : A = 1 , B = 2 , C = 3 

            //Console.WriteLine("-------------------------------------");

            //TypeC RefC02 = new TypeE(1, 2, 3, 4, 5);
            //RefC02.WhereAmI(); // Iam Type C
            //RefC02.Print(); // TypeC : A = 1 , B = 2 , C = 3 

            //Console.WriteLine("-------------------------------------");

            //TypeD RefD01 = new TypeE(1, 2, 3, 4, 5);
            //RefD01.WhereAmI(); // Iam Type D
            //RefD01.Print(); // TypeE : A = 1 , B = 2 , C = 3, D = 4 , E = 5 

            //Console.WriteLine("-------------------------------------");

            //TypeD RefD02 = new TypeD(1, 2, 3, 4);
            //RefD02.WhereAmI(); // Iam Type D
            //RefD02.Print(); // TypeD : A = 1 , B = 2 , C = 3, D = 4

            //Console.WriteLine("-------------------------------------");

            //TypeE RefE01 = new TypeF(1, 2, 3, 4, 5, 6);
            //RefE01.WhereAmI(); // Iam Type E
            //RefE01.Print(); // TypeF : A = 1 , B = 2 , C = 3, D = 4 , E = 6 , F = 6

            #endregion

            #endregion

            #endregion

            #region 2 Interface
            /*
             * An interface is a contract that defines a set of methods, properties, events, or indexers
               that a class or struct must implement.
             
             * Interfaces provide a way to achieve polymorphism and can be used to specify what a class 
               must do, but not how it does it.

             * Default access Modifier Inside Interface is Public.
              
             * Syntax => interface <InterfaceName>
                         {
                           // 1-Signature For Properties
                           // 2-Signature For Methods
                           // 3-Default Implemented Methods [C# 8 (.net core 3.1)]
                         }
             
             * Class Can Implement Multiple Interfaces, But Can't Inherit Multiple Classes.
            
             * In Class We Can Implement Interfaces Members :
               * 1.Implicitly =>
               * 2.Explicitly => 
            */

            #region Example1
            //MyType ReferFromClass = new MyType();

            //Console.WriteLine("Reference From Class MyType :");

            ////ReferFromClass.PrintMessage();
            /*
             * class في ال implement مش هتظهر عشان انا مش عاملها
             * class من ال object بيشاور علي interface من ال reference عشان تظهر محتاج اعمل 
            */

            //ReferFromClass.Salary = 8000;
            //ReferFromClass.PrintSalary();

            //Console.WriteLine("\n---------------------------------\n");

            //IMyType ReferFromInterface;
            /*
             * Declare For Reference Of Type IMyType Refer To null.
             * This Reference Can Refer To Object From Class or Struct If They Implement That Interface.
             * CLR Allocate 4 Bytes At Stack For The Reference.
            */

            ////ReferFromInterface = new IMyType(); //Invalid : Cannot create an instance of the interface

            //ReferFromInterface = new MyType();

            //Console.WriteLine("Reference From Interface IMyType :");

            //ReferFromInterface.PrintMessage();
            //ReferFromInterface.Salary = 10000;
            //ReferFromInterface.PrintSalary();
            #endregion

            #region Example2
            //SeriesByTwo series01 = new SeriesByTwo();
            //PrintTenNumbersFromSeriesWithClassParameter(series01);

            //Console.WriteLine("--------------------");

            //SeriesByThree series02 = new SeriesByThree();
            //PrintTenNumbersFromSeriesWithClassParameter(series02);

            //Console.WriteLine("--------------------");

            //SeriesByTwo series03 = new SeriesByTwo();
            //PrintTenNumbersFromSeriesWithInterfaceParameter(series03);

            //Console.WriteLine("--------------------");

            //SeriesByThree series04 = new SeriesByThree();
            //PrintTenNumbersFromSeriesWithInterfaceParameter(series04);
            #endregion

            #region Example3
            //Airplane airplane = new Airplane();
            ////airplane.Forward(); 
            ///*
            // * Implement Explicitly عاملها Forward() , Classوجوا ال Classمن ال Reference مش هعرف اوصلها لان انا معرف 
            // * Interface من ال Reference فا عشان اوصلها هعرف
            //*/

            //IMovable AirplaneMove = new Airplane();
            //AirplaneMove.Forward();  

            //IFlyable AirplaneFly = new Airplane();
            //AirplaneFly.Forward();
            #endregion

            #endregion

            #region 3 Shallow Copy & Deep Copy

            #region Shallow Copy
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"HashCode Of Array 01 = {Arr01.GetHashCode()}"); // 54267293 
            //Console.WriteLine($"HashCode Of Array 02 = {Arr02.GetHashCode()}"); // 18643596
            //Console.WriteLine($"Array01[0] = {Arr01[0]}"); // 1
            //Console.WriteLine($"Array02[0] = {Arr02[0]}"); // 4

            //Arr02 = Arr01;
            /*
             * This Object { 1, 2, 3 } Has 2 References [Arr01 , Arr02]
             * The Object { 4, 5, 6 } Became Unreachable Object
            */

            //Arr01[0] = 10;

            //Console.WriteLine("\nAfter Shallow Copy...\n");

            //Console.WriteLine($"HashCode Of Array 01 = {Arr01.GetHashCode()}"); // 54267293
            //Console.WriteLine($"HashCode Of Array 02 = {Arr02.GetHashCode()}"); // 54267293 
            //Console.WriteLine($"Array01[0] = {Arr01[0]}"); // 10
            //Console.WriteLine($"Array02[0] = {Arr02[0]}\n"); // 10
            #endregion

            #region Deep Copy
            //int[] Arr03 = { 11, 12, 13 };
            //int[] Arr04 = { 14, 15, 16 };

            //Console.WriteLine($"HashCode Of Array 03 = {Arr03.GetHashCode()}"); // 33574638 
            //Console.WriteLine($"HashCode Of Array 04 = {Arr04.GetHashCode()}"); // 33736294
            //Console.WriteLine($"Array03[0] = {Arr03[0]}"); // 11
            //Console.WriteLine($"Array04[0] = {Arr04[0]}"); // 14

            //Arr03 = (int[])Arr04.Clone();
            /*
             * <SourceArray>.Clone() :
                 * Create A Copy Of <SourceArray> , With Different Identity
                 * Return Object
                 * The Object That Will Returned Have The Same Values Of Source Object
            */

            //Arr03[0] = 111;

            //Console.WriteLine("\nAfter Deep Copy...\n");

            //Console.WriteLine($"HashCode Of Array 03 = {Arr03.GetHashCode()}"); // 35191196
            //Console.WriteLine($"HashCode Of Array 04 = {Arr04.GetHashCode()}"); // 33736294 
            //Console.WriteLine($"Array03[0] = {Arr03[0]}"); // 111
            //Console.WriteLine($"Array04[0] = {Arr04[0]}"); // 14
            #endregion

            #endregion

            #region 4 Built In Interfaces

            #region 4.1 ICloneable
            /* 
             * ICloneable interface provides a way to support cloning, 
               which is creating a new instance of a class with the same value as an existing instance.
            
             * The ICloneable interface contains a single method,
               Clone(), which returns a copy of the current object instance, with different identity.
            */

            #region Deep Copy Using Clone
            //Console.WriteLine("Deep Copy Using Clone:\n");

            //Employee02 Emp1 = new Employee02()
            //{
            //    Id = 1,
            //    Name = "Abdalrhman",
            //    Salary = 8000
            //};

            //Employee02 Emp2 = new Employee02()
            //{
            //    Id = 2,
            //    Name = "Emad",
            //    Salary = 12000
            //};

            //Console.WriteLine(Emp1);
            //Console.WriteLine($"Emp1 Hash Code : {Emp1.GetHashCode()}\n"); // 54267293

            //Console.WriteLine(Emp2);
            //Console.WriteLine($"Emp2 Hash Code : {Emp2.GetHashCode()}"); // 18643596

            ////Emp2 = Emp1.Clone(); // 'Employee' does not contain a definition for 'Clone' 
            /*
             * BuiltIn كانت موجوده Array في ال
             * ICloneable لل Implement لازم اعمل Clone عشان اقدر استخدم ال
            */

            //Emp2 = (Employee02)Emp1.Clone();

            //Console.WriteLine("\nAfter Copy...\n");

            //Console.WriteLine(Emp1);
            //Console.WriteLine($"Emp1 Hash Code : {Emp1.GetHashCode()}\n"); // 54267293

            //Console.WriteLine(Emp2);
            //Console.WriteLine($"Emp2 Hash Code : {Emp2.GetHashCode()}"); // 33574638
            #endregion

            #region Deep Copy Using Constructor Copy
            //Console.WriteLine("Deep Copy Using Constructor Copy :\n");

            //Employee02 Emp3 = new Employee02()
            //{
            //    Id = 3,
            //    Name = "Abdalrhman",
            //    Salary = 8000
            //};

            //Employee02 Emp4 = new Employee02()
            //{
            //    Id = 4,
            //    Name = "Emad",
            //    Salary = 12000
            //};

            //Console.WriteLine(Emp3);
            //Console.WriteLine($"Emp3 Hash Code : {Emp3.GetHashCode()}\n"); // 27252167

            //Console.WriteLine(Emp4);
            //Console.WriteLine($"Emp4 Hash Code : {Emp4.GetHashCode()}"); // 43942917

            //Emp4 = new Employee02(Emp3);

            //Console.WriteLine("\nAfter Copy...\n");

            //Console.WriteLine(Emp3);
            //Console.WriteLine($"Emp3 Hash Code : {Emp3.GetHashCode()}\n"); // 27252167

            //Console.WriteLine(Emp4);
            //Console.WriteLine($"Emp4 Hash Code : {Emp4.GetHashCode()}"); // 59941933
            #endregion

            #endregion

            #region 4.2 IComparable
            /*
             * The IComparable interface is used to define a generalized comparison method for objects. 
           
             * When a class implements IComparable, it allows instances of that class to be compared
               with each other.
            
             * The ICloneable interface contains a single method, CompareTo(),
               which takes one parameter of the same type and returns an integer 
               that indicates the relative order of the objects being compared. 

             * The method returns:
                * [A negative number] if the current instance precedes(اقل) the object being compared.
                * [Zero] if the current instance occurs in the same position in the sort order as the object being compared.
                * [A positive number] if the current instance follows(اكبر) the object being compared.
            */

            ////int[] Numbers = { 5, 7, 3, 1, 2 };
            ////Array.Sort(Numbers);
            ////foreach (int i in Numbers)
            ////    Console.Write($"{i} "); // 1 2 3 5 7

            //Employee02[] employees =
            //{
            //    new Employee02 { Id = 3, Name = "Ali", Salary = 10000 },
            //    new Employee02 { Id = 1, Name = "Ahmed", Salary = 6000 },
            //    new Employee02 { Id = 2, Name = "Gaber", Salary = 7000 },
            //    new Employee02 { Id = 4, Name = "Sara", Salary = 6000 }
            //};

            #region Explain Sort
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    for (int j = 0; j < employees.Length-i-1; j++)
            //    {
            //        if (employees[j].CompareTo(employees[j+1]) == 1)
            //        {
            //            //Swap(ref employees[j], ref employees[j+1]);
            //        }
            //    }
            //} 
            #endregion

            ////Array.Sort(employees); // System.InvalidOperationException: Failed to compare two elements in the array.
            ////foreach (Employee02 employee in employees)
            ////    Console.WriteLine(employee);

            //int Result = employees[0].CompareTo(employees[1]);
            //Console.WriteLine(Result); // 1

            //Result = employees[3].CompareTo(employees[2]);
            //Console.WriteLine(Result); // -1

            #endregion

            #region 4.3 ICombarer

            #endregion

            #endregion
        }
    }
}
