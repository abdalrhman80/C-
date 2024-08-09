
//////////////// 1 Value Type - Implicit Casting Vs Explicit Casting ////////////////

#region Implicit Casting Vs Explicit Casting

//int X1 = 5;
//long Y1 = X1; // Implicit Casting [Safe Casting]
//Console.WriteLine(X1);
//Console.WriteLine(Y1);

//long X2 = 5_000_000_000_000_000_00;
////int Y2 = X2; // Cannot implicitly convert type 'long' to 'int'.
//int Y2 = (int)X2; // Explicit Casting [UnSafe Casting (ممكن يتم وممكن لا)]
//Console.WriteLine(X2); // 500000000000000000
//Console.WriteLine(Y2); // -743309312 (Garbage Value)


//double X3 = 5.3;
//int Y3 = (int)X3; // Explicit Casting [UnSafe Casting]
//Console.WriteLine(X3); // 5.3
//Console.WriteLine(Y3); // 5 

#endregion

#region Checked and Unchecked
/*
   In C#, checked and unchecked keywords are used to control the overflow-checking context 
   for arithmetic operations and conversions involving integral types.
*/

#region Checked
/*
   Arithmetic operations and conversions that exceed the bounds of the data type will 
   cause a System.OverflowException to be thrown
*/

//checked 
//{
//    int val2 = int.MaxValue; // 2147483647
//    Console.WriteLine(val2 + 1); // OverflowException: Arithmetic operation resulted in an overflow.
//}

#endregion

#region unchecked
/* 
   Arithmetic operations and conversions that exceed the bounds of the data type do not throw an exception. 
   Instead, they result in overflow wrapping, where the result wraps around the minimum value of the type.
*/

//unchecked
//{
//    int val2 = int.MaxValue; // 2147483647
//    Console.WriteLine(val2 + 1); // -2147483648 -> wrap around to the minimum value of int
//}

#endregion

//long X4 = 500000000000000000;

//checked
//{
//    int Y4 = (int)X4; // OverflowException: Arithmetic operation resulted in an overflow.
//    unchecked
//    {
//        Console.WriteLine(Y4);
//    }
//}
//Console.WriteLine(X4);

#endregion


//////////////// 2 Operators ////////////////

#region Operators
/*
 ** Unary (One Operand): ++ , --
    * Prefix [Increment or Decrement Then Print]
    * Postfix [Print Then Increment or Decrement]
    
 ** Binary (Two Operand): + , - , * , / , %
 ** Assignment (Two Operand): = , += , -+ , *= , /= , %=
 ** Relational (Two Operand): == , != , >= , <= , > , <
 ** Logical (Two Operand): ! , && , ||
 ** Bitwise (Like Logical): & [and] , | [or]
 ** Ternary (Short Hand If...Else): [variable = (condition) ? expressionTrue : expressionFalse]
*/

#region Logical And Bitwise
//Console.WriteLine(true && false); // false -> [Short Circuit] -> (false بيطلع false اول ما يلاقي)
//Console.WriteLine(true & false); // false -> [Long Circuit] -> (بتشوف هل طرفين المقارنة بيساوي بعض ولا لا)

//Console.WriteLine(false || true); // true
//Console.WriteLine(false | true); // true
#endregion

#region Ternary

//int int1 = 5, int2 = 4;
//string MSG1;

//if (int1 > int2)
//    MSG1 = "int1 More Than int2";
//else if (int1 < int2)
//    MSG1 = "int1 Less Than int2";
//else
//    MSG1 = "int1 Equal int2";

//Console.WriteLine(MSG1);


//string MSG2 = (int1 >int2) /*If*/ ? "int1 More Than int2" : 
//              (int1 < int2)/*Else If*/ ? "int1 Less Than int2" :/*Else*/ "int1 Equal int2";

//Console.WriteLine(MSG2);
#endregion

#endregion

#region Operators Priority [Precedence] and Associativity
/*
 * Priority:
            1. Prefix Unary Operator [++ , --]
            2. Round Braces [()]
            3. * , / , %
            4. + , -

 * Associativity: هيبدا من الشمال لليمين Priorityليهم نفس ال Operator لو في اتنين 
*/

//int equ1 = 4 + 5 - 3 * 2 / 6;
//double equ2 = ((4 + 5) - 3) * 2 / 6;
//Console.WriteLine(equ1); // 8
//Console.WriteLine(equ2); // 2
#endregion


//////////////// 3 String Formatting ////////////////

#region String Formatting
/*
   1. Concat -> +
   2. Composite Formatting -> string.Format("String Formatting", args....) 
   3. String Interpolation -> $".... {arg} ..."
*/

//int a = 10;
//int b = 20;
//int sum = a + b;

//Console.WriteLine("Concat-> " + "Equation : " + a + " + " + b + " = " + sum);

//Console.WriteLine(string.Format("Composite Formatting-> Equation : {0} + {1} = {2}", a , b , sum));

//Console.WriteLine($"String Interpolation-> Equation : {a} + {b} = {a + b}");

#endregion


//////////////// 4 Control Statements (If- Switch) ////////////////

#region If Statements
/*
 * line by line Cases بتمشي علي كل ال
 * If Statement اقل من ال5 يفضل اشتغل Cases لو عدد ال
*/

//Console.WriteLine("Please Inter A Month Number In First Quarter Of Year");
//int monthNumber = int.Parse(Console.ReadLine());

//if (monthNumber == 1)
//    Console.WriteLine("Hello January");
//else if (monthNumber == 2)
//    Console.WriteLine("Hello February");
//else if (monthNumber == 3)
//    Console.WriteLine("Hello March");
//else
//    Console.WriteLine("Number You Entered Is Not In First Quarter");

#endregion


#region Switch

#region Switch Statements (Before C# 6)
// اعلا Cost بس ال (Debug هتبان في ال) Jump Table بتعها احسن لانها بتشتغل بطريقة Performance ال 

//Console.WriteLine("Please Enter A Month Number In Second Quarter Of Year");
//int monthNumber2 = int.Parse(Console.ReadLine());

//switch (monthNumber2)
//{
//    case 4:
//        Console.WriteLine("Hello April");
//        break;

//    case 5:
//        Console.WriteLine("Hello May");
//        break;

//    case 6:
//        Console.WriteLine("Hello June");
//        break;

//    default:
//        Console.WriteLine("Number You Entered Is Not In Second Quarter"); 
//        break;
//}

//////////////////////////////////////////


//Console.WriteLine("Please Enter Your Budget");
//int budget = int.Parse(Console.ReadLine());

//switch (budget)
//{
//    case 3000:
//        //Console.WriteLine("Option 1");
//        //Console.WriteLine("Option 2");
//        Console.WriteLine("Option 3");
//        goto case 2000;
//        break;

//    case 2000:
//        //Console.WriteLine("Option 1");
//        Console.WriteLine("Option 2");
//        goto case 1000;
//        break;
//    case 1000:
//        Console.WriteLine("Option 1");
//        break;
//}
#endregion


#region Switch Statements (In C# 7,8,9)

#region C# 7 /*when Keyword*/

#region Before C# 7
//object obj1 = new object(); // Datatype وبالتالي يقدر يشيل اي object من نوع  Variable عباره عن obj1 ال 
//obj1 = "Abdo";

//switch (obj1)
//{
//    case int Number: // int عباره عن obj1 لو ال
//        /*  (مينفش C# 6 لو عايز اشوف هل الرقم اللي ما بين رقمين معينين (في */
//        Console.WriteLine($"{Number} is Integer");
//        break;
//    case double Number: // double عباره عن obj1 لو ال
//        Console.WriteLine($"{Number} is double");
//        break;
//    case string Name: // string عباره عن obj1 لو ال
//        Console.WriteLine($"{Name} is String");
//        break;
//}

#endregion

//object obj2 = new object(); 
//obj2 = 9;

//switch (obj2)
//{
//    case int Number when Number > 1 & Number <10: // int عباره عن obj1 لو ال
//        Console.WriteLine($"{Number} is Integer and between 1 and 10");
//        break;
//    case double Number: // double عباره عن obj1 لو ال
//        Console.WriteLine($"{Number} is double");
//        break;
//    case string Name: // string عباره عن obj1 لو ال
//        Console.WriteLine($"{Name} is String");
//        break;
//}

#endregion

#region C# 8 /*Switch Expression*/

string option = "1";
string Message = "";
//switch (option)
//{
//    case "1":
//        Message = "Using Option 1";
//        break;
//    case "2":
//        Message = "Using Option 2";
//        break;
//    case "3":
//        Message = "Using Option 3";
//        break;
//    default:
//        Message = "No Option";
//        break;
//}
//Console.WriteLine(Message);

/*Switch Expression*/
Message = option switch
{
    /* (=>) goes to*/
    "1" => "Using Option 1",
    "2" => "Using Option 2",
    "3" => "Using Option 3",
    _ => "No Option" // default
};
Console.WriteLine(Message);

#endregion

#region C# 9

#endregion

#endregion

#endregion