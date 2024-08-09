using AdvCsharp03.DelegatesExGenerics;

namespace AdvCsharp03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region User-Defined Delegates

            #region 1 What is Delegates?
            /*
             * Delegates is  A C# Language Feature (similar to the [function pointer] in C/C++)
             
             * A delegate is a reference type variable that can hold a reference to the methods.
             
             * Has 2 Usage 
               * 1. Pointer To Function
               * 2. Event-Driven Programing

             * Delegate in Compilation Time Will Turn into a Normal Class.
             * Reference From Delegate Can Refer To More One Function.
            */
            #endregion

            #region 2 Declaring a Delegate
            /*
             * Delegate type can be declared using the 'delegate' keyword.  
             
             * Syntax => [modifier] delegate [return_type] [delegate_name] ([parameter_list]);
             
             * The Functions Must be with the Same Signature of The Delegate (Regardless Function Name & Access Modifier).
             
             * Once a delegate is declared, delegate instance will refer and call those methods whose return type 
               and parameter-list matches with the delegate declaration.
            */
            #endregion

            #region 3 Delegate Usage
            /*
             * Step 0. Delegate Declaration 
             
             * Step 1. Declare Reference From Delegate.
             
             * Step 2. Initialize Reference From Delegate (Pointer To Function)
                       
                      * Syntax : [delegate_name] [instance_name] = new [delegate_name]([methodsRef]);
                                 OR
                                 [delegate_name] [instance_name] = [methodsRef]; // Syntax Sugar 

             * Step 3. Use Delegate Reference (Call Method) 
             
                      * Syntax : [delegate_name]([parameter_list])
                                 OR
                                 [delegate_name].Invoke([parameter_list])
            */

            #endregion

            #region 4 Delegates Examples (Generic)

            #region Example 01

            //string[] names = { "Rana", "Ahmed", "Abdalrhman", "Yasmine" };
            //SortingAlgorithms<string>.BubbleSortGeneric(names, CompareFunctions.SortingDescending);

            //Console.WriteLine("Sort Names Descending: ");
            //foreach (string i in names)
            //    Console.Write($"{i} "); // Abdalrhman Yasmine Ahmed Rana

            //Console.WriteLine();

            //int[] numbers = { 100, 30, 1, 105, 50, 30 };

            //SortingAlgorithms<int>.BubbleSortGeneric(numbers, CompareFunctions.CompareGrater);
            //Console.WriteLine("\nSort Numbers Ascending: ");
            //foreach (int i in numbers)
            //    Console.Write($"{i} "); // 1 30 30 50 100 105

            //Console.WriteLine();

            #endregion

            #region Example 02

            #region Without Genenric
            //List<int> numbers = Enumerable.Range(1, 100).ToList(); // 😁 بصمج 

            //List<int> oddNumbers = Helper.GetOddNumbers(numbers);
            //List<int> evenNumbers = Helper.GetEvenNumbers(numbers);
            //List<int> numbersBySeven = Helper.GetNumbersDividedBy7(numbers);

            //Console.WriteLine("Odd Numbers: ");
            //foreach (int i in oddNumbers)
            //    Console.Write($"{i} "); // 1 3 5 7 9 11 13 15 .....

            //Console.WriteLine();

            //Console.WriteLine("\nEven Numbers: ");
            //foreach (int i in evenNumbers)
            //    Console.Write($"{i} "); // 2 4 6 8 10 12 14 16 .....

            //Console.WriteLine();

            //Console.WriteLine("\nEven Numbers: ");
            //foreach (int i in numbersBySeven)
            //    Console.Write($"{i} "); // 7 14 21 28 35 42 49 56 63 70 77 84 91 98

            //Console.WriteLine();

            //Console.WriteLine("\n/////////////////////////////////////////////////\n");

            //List<int> oddNumbers02 = Helper.GetNumbersBasedOnRefMethod(numbers, ConditionalFunctions.CheckOdd);
            //List<int> evenNumbers02 = Helper.GetNumbersBasedOnRefMethod(numbers, ConditionalFunctions.CheckEven);
            //List<int> numbersBySeven02 = Helper.GetNumbersBasedOnRefMethod(numbers, ConditionalFunctions.CheckDividedBySeven);

            //Console.WriteLine("Odd Numbers (Delegate): ");
            //foreach (int i in oddNumbers02)
            //    Console.Write($"{i} "); // 1 3 5 7 9 11 13 15 .....

            //Console.WriteLine();

            //Console.WriteLine("\nEven Numbers (Delegate): ");
            //foreach (int i in evenNumbers02)
            //    Console.Write($"{i} "); // 2 4 6 8 10 12 14 16 .....

            //Console.WriteLine();

            //Console.WriteLine("\nEven Numbers (Delegate): ");
            //foreach (int i in numbersBySeven02)
            //    Console.Write($"{i} "); // 7 14 21 28 35 42 49 56 63 70 77 84 91 98

            //Console.WriteLine();
            #endregion

            #region Generic
            //List<int> numbers = Enumerable.Range(1, 100).ToList();
            //List<int> oddNumbers = Helper.GetElementsBasedOnRefMethod<int>(numbers, ConditionalFunctions.CheckOdd);
            //List<int> evenNumbers = Helper.GetElementsBasedOnRefMethod(numbers, ConditionalFunctions.CheckEven);

            //Console.WriteLine("Odd Numbers (Delegate-Generic): ");
            //foreach (int i in oddNumbers)
            //    Console.Write($"{i} "); // 1 3 5 7 9 11 13 15 .....
            //Console.WriteLine();

            //Console.WriteLine("\nEven Numbers (Delegate-Generic): ");
            //foreach (int i in evenNumbers)
            //    Console.Write($"{i} "); // 2 4 6 8 10 12 14 16 .....
            //Console.WriteLine();


            //List<string> names = new List<string> { "Rana", "Ahmed", "Abdalrhman", "Ali", "Yasmine" };
            //List<string> namesLessThan4 = Helper.GetElementsBasedOnRefMethod(names, ConditionalFunctions.CheckStringLessThan4);
            //List<string> namesMoreThan4 = Helper.GetElementsBasedOnRefMethod(names, ConditionalFunctions.CheckStringMoreThan4);

            //Console.WriteLine("\nNames Less Than 4 (Delegate-Generic): ");
            //foreach (string i in namesLessThan4)
            //    Console.Write($"{i} "); // Ali
            //Console.WriteLine();

            //Console.WriteLine("\nNames More Than 4 (Delegate-Generic): ");
            //foreach (string i in namesMoreThan4)
            //    Console.Write($"{i} "); // Ahmed Abdalrhman Yasmine
            //Console.WriteLine();
            #endregion

            #endregion

            #endregion

            #endregion

            #region Built-in Delegates

            #region Built-in Delegates Types
            /*
             * 1.Predicate<T>: Can refer To Function Take (One Parameter) Only From Any Data Type And (Must be Return boolean)
            
             * 2.Func <T1,..., T16, TResult>: Can refer To Function Take (0-16 Parameter) From Any Data Type 
                                              And one output parameter (Must Returns Result)
            
             * 3.Action: 
                       * Non Generic Version [Action] : Can refer To Function (Take 0 Parameter) And (Must be Void)
                       
                       * Generic Version [Action <T1,....T16>]: Can refer To Function (Take 1-16 Parameter) From Any Data Type 
                                                                And (Must be Void)
             
            
             * 16 Parameter بتاخد اكتر من Method لو في User-Defined Delegate بعمل 
            */
            #endregion


            #region Brevious Examples

            #region 1.Predicate<T>
            //List<int> numbers = Enumerable.Range(1, 100).ToList();

            //Predicate<int> conditionalPredicateDelegate = ConditionalFunctions.CheckOdd;
            //List<int> oddNumbers = Helper.GetElementsUsingPredicateDelegate<int>(numbers, conditionalPredicateDelegate);

            //Console.WriteLine("Odd Numbers (Predicate-Delegate): ");
            //foreach (int i in oddNumbers)
            //    Console.Write($"{i} "); // 1 3 5 7 9 11 13 15 .....
            //Console.WriteLine();


            //conditionalPredicateDelegate += ConditionalFunctions.CheckEven;
            //List<int> evenNumbers = Helper.GetElementsUsingPredicateDelegate(numbers, conditionalPredicateDelegate);

            //Console.WriteLine("\nEven Numbers (Predicate-Delegate): ");
            //foreach (int i in evenNumbers)
            //    Console.Write($"{i} "); // 2 4 6 8 10 12 14 16 .....
            //Console.WriteLine();

            //Console.WriteLine("\n///////////////////////////////////////////////////////////////");

            //List<string> names = new List<string> { "Rana", "Ahmed", "Abdalrhman", "Ali", "Yasmine" };

            //Predicate<string> conditionalPredicateDelegate02 = ConditionalFunctions.CheckStringLessThan4;
            //List<string> namesLessThan4 = Helper.GetElementsUsingPredicateDelegate(names, conditionalPredicateDelegate02);

            //Console.WriteLine("\nNames Less Than 4 (Predicate-Delegate): ");
            //foreach (string i in namesLessThan4)
            //    Console.Write($"{i} "); // Ali
            //Console.WriteLine();
            #endregion

            #region 2.Func <T1,..., T16, TResult>
            //string[] names = { "Rana", "Ahmed", "Abdalrhman", "Yasmine" };

            //Func<string, string, bool> compareFuncDelegate = CompareFunctions.SortingDescending;
            //SortingAlgorithms<string>.BubbleSortGenericUsingFuncDelegate(names, compareFuncDelegate);

            //Console.WriteLine("Sort Names Descending (Using Func Delegate): ");
            //foreach (string i in names)
            //    Console.Write($"{i} "); // Abdalrhman Yasmine Ahmed Rana
            //Console.WriteLine();
            #endregion

            #endregion


            #region Built In Delegate Examples

            #region 1.Predicate<T>
            //Predicate<int> predicateFunc; // Refer To Function Take One Parameter [int] and Return [bool]
            //predicateFunc = TestFunctions.CheckGreaterThanZero;

            //Console.WriteLine(predicateFunc(10)); // True 
            #endregion

            #region 2.Func <T1,..., T16, TResult>
            //Func<int, string> funcDelegate; // Refer To Function Take One Parameter (in) [int] and Return (out) [string]
            //funcDelegate = TestFunctions.ConvertNumberToString;

            //Console.WriteLine(funcDelegate(10)); // ToString: 10
            #endregion

            #region 3.Action

            #region Action (Non-Generic)
            //Action actionDelegate; // Non-Generic Action Refer To Function Take 0 Parameters and Return Void
            //actionDelegate = TestFunctions.Print;

            //actionDelegate(); // Hello World
            #endregion

            #region Action<T> (Generic)
            //Action<string> actionDelegateGeneric; // Generic Action Refer To Function Take 1 Parameters [string] and Return Void
            //actionDelegateGeneric = TestFunctions.PrintMessage;

            //actionDelegateGeneric("Hello World"); // Hello World
            #endregion

            #endregion

            #endregion

            #endregion

            #region Anonymous Method And Lambda Expression

            #region Anonymous Method (C# 2)
            /*
             * Anonymous Method: an anonymous method is a inline method without a name.
             * can be defined using the 'delegate' keyword and can be assigned to a variable of delegate type.
            */

            //Predicate<int> predicateAnonymousFunc; // Refer To Function Take One Parameter [int] and Return [bool]

            //predicateAnonymousFunc = delegate (int x) // Take One Parameter [int] and Return [bool] تكون  method المهم في ال
            //{
            //    return x > 0;
            //};
            //Console.WriteLine(predicateAnonymousFunc(10)); // True


            //Func<int, string> funcDelegateAnonymous; // Refer To Function Take One Parameter (in) [int] and Return (out) [string]

            //funcDelegateAnonymous = delegate (int x) // Take One Parameter [int] and Return [string] تكون  method المهم في ال
            //{
            //    return $"ToString: {x}";
            //};
            //Console.WriteLine(funcDelegateAnonymous(10)); // ToString: 10


            //Action actionDelegateAnonymous; // Non-Generic Action Refer To Function Take 0 Parameters and Return Void
            //actionDelegateAnonymous = delegate
            //{
            //    Console.WriteLine("Hello World");
            //};
            //actionDelegateAnonymous(); // Hello World


            //Action<string> actionDelegateGenericAnonymous; // Generic Action Refer To Function Take 1 Parameters [string] and Return Void
            //actionDelegateGenericAnonymous = delegate(string message)
            //{
            //    Console.WriteLine(message);
            //};
            //actionDelegateGenericAnonymous("Hello World"); // Hello World
            #endregion

            #region Lambda Expression
            /*
             * Lambda Expression is a short block of code that accepts parameters and returns a value.
             * It is defined as an anonymous function
             
             * Syntax: (parameterList) => lambda body  
             * (=>) arrow Function | goes to
             
             * The two types of lambda expressions are:
             
                * 1.Expression Lambda: Expression lambda contains a single expression in the lambda body. 
                    * (int num) => num * 5;

                * 2.Statement Lambda: Statement lambda encloses one or more statements in the lambda body.
                                    We use curly braces {} to wrap the statements.

                    * (int a, int b) =>
                      {
                          int sum = a + b;
                          return sum;
                      };
            */

            //Predicate<int> predicateFuncLambda;
            //predicateFuncLambda = (int x) => x > 0;
            //Console.WriteLine(predicateFuncLambda(10)); // True


            //Func<int, string> funcDelegateLambda;
            //funcDelegateLambda = (int x) => $"ToString: {x}";
            //Console.WriteLine(funcDelegateLambda(10)); // ToString: 10


            //Action actionDelegateLambda;
            //actionDelegateLambda = () => Console.WriteLine("Hello World");
            //actionDelegateLambda(); // Hello World


            //Action<string> actionDelegateGenericAnonymous;
            //actionDelegateGenericAnonymous = (string message) => Console.WriteLine(message);
            //actionDelegateGenericAnonymous("Hello World"); // Hello World
            #endregion

            #endregion
        }
    }
}
