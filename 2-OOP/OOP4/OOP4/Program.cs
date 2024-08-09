using OOP4.Abstraction;
using OOP4.Operator_Overloading.CastingOperatorBusinessNeed;
using OOP4.Operator_Overloading.Example1;
using OOP4.Static_And_Constants;
using OOP4.Partial_Class;

namespace OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator Overloading
            /*
             * Operator overloading in C# allows you to define how operators work with user-defined types
               such as classes or structs.
            
             * This means you can provide custom implementations for standard operators (like +, -, *, /) 
               for your types.

             * The method must be public and static.
             
             * Syntax => public static <ReturnType> operator <OperatorSymbol>(<Operands>)
                         {
                            return ...;
                         } 
             * Unary Operators: +, -, !, ~, ++, --
             * Binary Operators: +, -, *, /, %, &, |, ^, <<, >>
             * Relational (Comparison) Operators: ==, !=, <, >, <=, >=
            */

            //Complex C1 = new Complex()
            //{
            //    Real = 1,
            //    Image = 4
            //};

            //Complex C2 = new Complex()
            //{
            //    Real = 3,
            //    Image = 5
            //};

            #region Binary Operators

            //Complex C3;

            ////C3 = C1 + C2; // Operator '+' cannot be applied to operands of type 'Complex' and 'Complex'

            //Console.WriteLine($"C1 = {C1}"); // 1 + 4i
            //Console.WriteLine($"C2 = {C2}"); // 3 + 5i

            //Console.WriteLine("\nAfter '+' Operator Overloading\n");

            //C3 = C1 + C2;
            //Console.WriteLine($"C3 = {C3}"); // 4 + 9i

            //Complex C4 = C1 + C2 + C3;
            //Console.WriteLine($"C4 = {C4}"); // 8 + 18i

            #endregion

            #region Unary Operators

            //Console.WriteLine($"C1 = {C1}"); // 1 + 4i

            //Console.WriteLine("\nAfter '++ [Prefix]' Operator Overloading\n");
            //Complex C5 = ++C1; 
            //Console.WriteLine($"C1 = {C1}"); // 2 + 4i
            //Console.WriteLine($"C5 = {C5}"); // 2 + 4i

            //Console.WriteLine("\nAfter '++ [Postfix]' Operator Overloading\n");
            //Complex C6 = C1++;
            //Console.WriteLine($"C1 = {C1}"); // 3 + 4i
            //Console.WriteLine($"C6 = {C6}"); // 2 + 4i

            #endregion

            #region Relational (Comparison) Operators
            //if (C1 > C2)
            //    Console.WriteLine($"C1: {C1} Is Greater Than C2: {C2}");
            //else if (C1 < C2)
            //    Console.WriteLine($"C1: {C1} Is Less Than C2: {C2}");
            //else
            //    Console.WriteLine($"C1: {C1} Equal To C2: {C2}");
            #endregion

            #region Casting Operator
            /*
             * Custom Casting For User-defined Types
             * Syntax => public static <explicit | implicit> operator <TypeWantToCast>(Operator)
                                       {
                                         return <ValueOfCastingType>
                                       }
            */

            //object obj = 3; //Boxing [Implicit Casting] => Convert Value Type (3) To Reference Type (object)
            //int Y = (int)obj; //UnBoxing [Explicit Casting] => Reverse Boxing

            //object O1 = "ABC"; // Implicit Casting [Not Boxing]
            //string S2 = (string)O1; // Explicit Casting

            //Complex C = new Complex()
            //{
            //    Real = 4,
            //    Image = 9
            //};

            #region Explicit Casting (Recommended)
            //int X = (int)C; // Explicit Casting => Recommended
            //Console.WriteLine(X); // 4 
            #endregion

            #region Implicit Casting
            //string S1 = C; // Implicit Casting
            //Console.WriteLine(S1); // 4 + 9i 
            #endregion

            #region Business Need For Casting Operator
            //User user = new User()
            //{
            //    Id = 8,
            //    FullName = "Abdalrhman Gamal",
            //    Email= "abc@gmail.com",
            //    Password = "12345",
            //    SecuritySmp = Guid.NewGuid(),      
            //};


            //// Mapping
            //UserViewModel userViewModel = (UserViewModel)user;

            //Console.WriteLine(userViewModel.FName); // Abdalrhman
            //Console.WriteLine(userViewModel.LName); // Gamal
            //Console.WriteLine(userViewModel.Email); // abc@gmail.com
            //Console.WriteLine(userViewModel.Password); // 12345
            #endregion

            #endregion

            #endregion

            #region Abstraction
            /*
             * Abstraction is the process of hide unnecessary details and only show the needed information.

             * A practical example of abstraction can be motorbike brakes.
               We know what a brake does. When we apply the brake, the motorbike will stop.
               However, the working of the brake is kept hidden from us.

             * Abstraction can be achieved with either 'abstract' classes or interfaces.
             
                * 1. The 'abstract' keyword is used for classes and methods: 
                 
                    * Abstract class:
                                      - Partial Implementation To Another Classes.
                    
                                      - Is a class that can't be used to create objects and can't be 
                                        instantiated and is intended to be a base class for other
                                        classes (abstract or non-abstract classes).
                    
                                      - We can declarer reference of type abstract class That refer to
                                        an object of type class inherit from that abstract class
                    
                                      - An abstract class can have both abstract methods (method without body)
                                        and non-abstract methods [regular methods] (method with the body).
                    
                    * Abstract Method: Can only be used in an abstract class, and it does not have a body
                                       and must be implemented by derived non-abstract classes.
             

                * 2. interfaces : 
             *
            */

            //Rectangle rectangle = new Rectangle(10, 20);

            //decimal RectArea = rectangle.GetArea();
            //decimal RectPerimeter = rectangle.Perimeter;
            //Console.WriteLine($"Rectangle Area = {RectArea}"); // 200
            //Console.WriteLine($"Rectangle Perimeter = {RectPerimeter}"); // 60

            //Console.WriteLine("---------------------------------");

            //Square square = new Square(20);

            //decimal SquareArea = square.GetArea();
            //decimal SquarePerimeter = square.Perimeter;
            //Console.WriteLine($"Square Area = {SquareArea}"); // 400
            //Console.WriteLine($"Square Perimeter = {SquarePerimeter}"); // 80

            //Console.WriteLine("---------------------------------");

            //Circle circle = new Circle(10);

            //decimal CircleArea = circle.GetArea();
            //decimal CirclePerimeter = circle.Perimeter;
            //Console.WriteLine($"Circle Area = {CircleArea}"); // 314.15926535897900 
            //Console.WriteLine($"Circle Perimeter = {CirclePerimeter}"); //  62.80

            //Console.WriteLine("---------------------------------");

            //Triangle triangle = new Triangle(1, 2, 3);

            //decimal TriangleArea = triangle.GetArea();
            //decimal TrianglePerimeter = triangle.Perimeter;
            //Console.WriteLine($"Triangle Area = {TriangleArea}"); // 1.0
            //Console.WriteLine($"Triangle Perimeter = {TrianglePerimeter}"); //  6
            #endregion

            #region Static [Class Members] (Class - Method - Property - Constructor)
            /*
             * Static Method: We can call the static methods using the class name.
             
             * Static Variable (Attribute): - We can access the static variable using the class name.
                                            - Compiler Will Initialize The Static Attributes With The Default
                                              Value Of Attribute Type
                                            - All objects of the class share the same static variable.
                                              And, we don't need to create objects of the class to access
                                              the static variables.

             * Static Property: - Static Property Get And Set One Of These
                                  * 1 Static Attribute
                                  * 2 Constant 

             * Static Constructor: - Special methods used to initialize static members of a class
                                   - Defined using the 'static' keyword followed by the class name.
                                   - There can be only one static constructor per class.
                                   - It doesn't have any access modifiers.
                                   - It doesn't take any parameters.
                                   - It runs only once for the lifetime of the program.
                                   - It can't be called directly.
                                   - The static constructor is automatically called before any static members
                                     are referenced or any instance of the class is created.

                                   - Use Case: * Call static members
                                               * Create Object From This Class
                                               * Create Object From Another Class Inheriting From This Class
             
             * Static Class: - We cannot create objects of the static class.
                             - We cannot inherit a static.
                             - We can only have static members inside the static class.
                                  
             * If we are accessing the static variables and methods inside the same class,
               we can directly access them without using the class name          
            */

            //Utility U1 = new Utility(1, 2);
            //Console.WriteLine(U1.CmToInch(254)); // 10 // object مش معتمد علي وجود CmToInch ناتج ال
            //Console.WriteLine(Utility.GetCircleArea(10)); // 314

            //Console.WriteLine(Utility.CmToInch(254));
            //Console.WriteLine(Utility.GetCircleArea(10));
            #endregion

            #region Sealed [Class- Method- Property]

            #endregion

            #region Partial Class
            /*
             * Partial classes allow you to split the definition of a class across multiple source files. 
             
             * This feature is particularly useful for managing large classes, organizing code more effectively,
               and allowing code generation tools to work seamlessly with user-written code.
            
              * All parts must use the partial keyword and must have the same access modifier.

              * During compilation, compiler combines all parts of the partial classes into a single class definition.
              
              * All parts of a partial class must be in the same namespace and assembly (project). 
              
              * Partial methods can be defined within partial classes, allowing the declaration in one part
                and implementation in another.
             
              * The partial keyword can also be used with structs, interfaces, and methods.
              
              * Class ويحولها ال Table لل Mapping لما يعمل Entity-FrameWork هيكون مهم جدا لان ال Partial Class ال 
                ويعمله من اول وجديد Members كله بكل ال Class ده هيمسح ال Table لو جيت عدلت في ال
                والتاني خاص بي انا Entity-FrameWork واحد يكون خاص بال Partial Class فا الحل اني اعمل 
            */

            //PartialEmployee c1 = new PartialEmployee()
            //{
            //    ID = 1,
            //    Name = "A",
            //    Age = 23,
            //    Salary = 23,
            //};

            //c1.Print();
            #endregion
        }
    }
}
