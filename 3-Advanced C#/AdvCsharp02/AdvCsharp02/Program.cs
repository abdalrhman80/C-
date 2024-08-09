using AdvCsharp02.DelegatesEx;
using System.Collections;

namespace AdvCsharp02
{
    #region Delegates
    /*
     * Creating New Class [Delegate]
     
     * Any Reference From This Delegate Can Refer To 
       Function Or More [Pointer To Function]

     * This Function May be Static Function [Class Member Function] or Non Static Function [Object Member Function]

     * But These Functions Must be with the Same Signature of The Delegate Regardless Function Name & Access Modifier
    */
    public delegate int StringFuncDelegate(string str); // Step 0: Delegate Declaration

    #endregion

    internal class Program
    {
        #region ArrayList Method Example
        public static int SumArrayListElements(ArrayList arrayList)
        {
            int Sum = 0;

            if (arrayList is not null)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    //Sum += arrayList[i]; //  Operator '+=' cannot be applied to operands of type 'int' and 'object'
                    Sum += (int)arrayList[i]; // Casting From 'object' To 'int'
                }
            }

            return Sum;
        }
        #endregion

        #region List Method Example
        public static int SumListElements(List<int> list)
        {
            int Sum = 0;

            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Sum += list[i]; // Casting From 'object' To 'int'
                }
            }

            return Sum;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Collections

            #region What is Collections?
            /*
              * Collection عبارة عن C# في ال Data Structure اي 
            */
            #endregion

            #region Types Of Collections
            /*
             * Collections are divided into 3 classes. They are:
               * 1.System.Collections
               * 2.System.Collections.Generic
               * 3.System.Collections.Concurrent

              [Non-Generic]                  [Generic]

                ArrayList    ------------->     List

                HashTable    ------------->     Dictionary

                SortedList   ------------->     SortedList  

                Stack        ------------->     Stack

                Queue        ------------->     Queue 
               
            */
            #endregion


            #region 1 Non Generic Collection [System.Collections]

            #region What is The Non Generic Collection?
            /*
             * In non-generic collections, each element can represent a value of a different type.
             * The collection size is not fixed.
             * We use [System.Collections] namespace. 
            */
            #endregion

            #region 1.1 ArrayList

            #region 1.1.1 What is ArrayList?
            /*
             * ArrayList is a class similar to an array, but it's size is dynamic and it can store values of various types.

             * In ArrayList, you can store elements of the same type and of the different types. 
                          
             * It is the non-generic type of collection which is defined in System.Collections namespace,
             
             * You can't implement a multi-dimensional array using ArrayList.
             
             * Duplicate elements are allowed inside ArrayList. 
            */
            #endregion

            #region 1.1.2 ArrayList Methods
            /*
             * 1.<ArrayList>.Count => Return Actual Numbers Of Elements in ArrayList.
 
             * 2.<ArrayList>.Capacity => Return Number Of Elements The ArrayList Can Hold.

             * 3.<ArrayList>.Add(object? <Value>) => Adds The Object To The End Of The <ArrayList>
             
             * 4.<ArrayList>.AddRange(ICollection <C>) => Adds The Elements Of The Given Collection To The End Of <ArrayList>.
            
             * 5.<ArrayList>.TrimToSize() => - Sets the (Capacity) of <ArrayList> to the size (Count) of the <ArrayList>.
                                             - This method can be used to minimize a list's memory overhead once it is 
                                               known that no new elements will be added to the list.
            */
            #endregion

            #region 1.1.3 Create ArrayList

            #region 1-ArrayList()
            //// New instance of the ArrayList class that is empty and has the capacity of Zero.
            //ArrayList arrayList = new ArrayList();


            //Console.WriteLine($"Count Of ArrayList {arrayList.Count}"); // 0
            //Console.WriteLine($"Capacity Of ArrayList {arrayList.Capacity}"); // 0

            //arrayList.Add(10);
            ///*
            // * Upon adding the first element to the list the capacity is increased to _defaultCapacity = 4 ,
            //   and then increased in multiples of two as required.

            // * Create New Array At Heap With Size  = 4
            //*/

            //Console.WriteLine("\nAfter Adding The First Element\n");
            //Console.WriteLine($"Count Of ArrayList {arrayList.Count}"); // 1
            //Console.WriteLine($"Capacity Of ArrayList {arrayList.Capacity}"); // 4

            //arrayList.Add(20);
            //arrayList.AddRange(new int[] { 30, 40 });

            //Console.WriteLine("\nAfter Adding 4 Elements\n");
            //Console.WriteLine($"Count Of ArrayList {arrayList.Count}"); // 4
            //Console.WriteLine($"Capacity Of ArrayList {arrayList.Capacity}"); // 4

            //arrayList.Add(50);
            ///*
            // * Create New Array At Heap With Double Size = 8
            // * Take Old Elements And Adding New Elements To The New Array.
            //*/

            //Console.WriteLine("\nAfter Adding 5 Elements\n");
            //Console.WriteLine($"Count Of ArrayList {arrayList.Count}"); // 5
            //Console.WriteLine($"Capacity Of ArrayList {arrayList.Capacity}"); // 8
            #endregion

            #region 2-ArrayList(Int32)
            //// New instance of the ArrayList class that is empty and has the specified initial capacity.
            //ArrayList arrayList02 = new ArrayList(5) { 10, 20, 30, 40, 50 };

            //Console.WriteLine($"Count Of ArrayList02 {arrayList02.Count}"); // 5
            //Console.WriteLine($"Capacity Of ArrayList02 {arrayList02.Capacity}"); // 5

            //arrayList02.Add(60);

            //Console.WriteLine("\nAfter Adding The 6 Element\n");
            //Console.WriteLine($"Count Of ArrayList02 {arrayList02.Count}"); // 6
            //Console.WriteLine($"Capacity Of ArrayList02 {arrayList02.Capacity}"); // 10 => 6 ints(24 Bytes) Used,
            //                                                                      // 4 ints(16 Bytes) Unused

            //arrayList02.TrimToSize();
            //// Create New Array At Heap With Size = arrayList02.Count
            //// Old Array Will be Unreachable

            //Console.WriteLine("\nAfter Trim ArrayList02\n");
            //Console.WriteLine($"Count Of ArrayList02 {arrayList02.Count}"); // 6
            //Console.WriteLine($"Capacity Of ArrayList02 {arrayList02.Capacity}"); // 6

            //Console.Write("\nArrayList02 Elements ");
            //foreach (int Number in arrayList02)
            //{
            //    Console.Write($"{Number} "); // ArrayList02 Elements 10 20 30 40 50 60
            //}

            //arrayList02.Add(70); // Casting From ValueType To ReferenceType => Boxing
            //arrayList02.Add("Abdalrhman"); // arrayList02 Will Be Heterogenous 
            //                               // Compiler Can't Enforce Type Safety At Compilation Time

            //int SumResult = SumArrayListElements(arrayList02);
            //Console.WriteLine($"\nSum ArrayList02 Elements {SumResult}"); // System.InvalidCastException
            //                                                              // 'Unable to cast object of type
            //                                                              // 'System.String' to type 'System.Int32'.
            #endregion

            #endregion

            #endregion

            #endregion

            #region 2 Generic Collections [System.Collections.Generic]

            #region What is The Generic Collections?
            /*
             * In Generic collections, doesn't allow to store different types of elements.
             * The collection size is not fixed.
             * We use [System.Collections.Generic] namespace. 
            */
            #endregion

            #region Lists

            #region 2.1 List<T>

            #region 2.1.1 What Is List<T>
            /*
             * The List<T> class is the generic version of the ArrayList class.

             * The List<T> class is used to store multiple elements of the same type that can be accessed 
               using the indexes.
            */
            #endregion

            #region 2.1.2 List Methods
            /*
             * 1.<List>.Count => Return Actual Numbers Of Elements in <List>.
 
             * 2.<List>.Capacity => Return Number Of Elements The <List> Can Hold.

             * 3.<List>.Add(object? <Value>) => Adds The Object To The End Of The <List>
             
             * 4.<List>.AddRange(IEnumerable<T> <Collection>) => Adds The Elements Of The Given Collection To 
                                                                 The End Of <List>.
            
             * 5.<List>.TrimExcess() => - Sets the capacity of <ArrayList> to the size (Count) of the <ArrayList>.
                                        - This method can be used to minimize a list's memory overhead once it is 
                                          known that no new elements will be added to the list.
           
             * 6. <List>.Clear() => Remove All Elements in <List>
             
             * 7. <List>.Insert(int <index>, <T> item) => Inserts an element into this <List> at a specific index.
             
             * 8. <List>.InsertRange(int index, IEnumerable<T> <Collection>) => Inserts the elements of the given collection 
                                                                                at a specific index.

             * 9. <List>.BinarySearch(T <Item>) => Return The Zero Based Index Of Searched Item, OtherWise Negative Number.
            
             * 10. <List>.Contains(T <Item>) => Return true If <Item> Is Found, OtherWise false
             
             * 11. <List>.EnsureCapacity(int <Capacity>) => If the current capacity of the <List> is less than specified 
                                                             <Capacity>, the capacity is increased to twice current capacity.                                           
            */

            //List<int> list = new List<int>();

            //list.Add(1);
            //list.AddRange(new int[] { 2, 3, 4 });
            //list.Insert(4, 50);
            //list.InsertRange(5, new int[] { 60, 70 });

            //Console.WriteLine($"The Count Of List {list.Count}"); // 7
            //Console.WriteLine($"The Capacity Of List {list.Capacity}\n"); // 8

            //foreach (int i in list)
            //{
            //    Console.Write($"{i} "); // 1 2 3 4 50 60 70
            //}

            //list.Clear();

            //Console.WriteLine("\n\nAfter Remove All Elements\n");
            //Console.WriteLine($"The Count Of List {list.Count}"); // 0
            //Console.WriteLine($"The Capacity Of List {list.Capacity}\n"); // 8

            //Console.WriteLine($"\n{list.BinarySearch(4)}"); // 3
            //Console.WriteLine($"{list.BinarySearch(5)}"); // -5 

            //Console.WriteLine($"{list.Contains(6)}"); // False

            //Console.WriteLine(list.Capacity); // 8
            //list.EnsureCapacity(9); 
            //Console.WriteLine(list.Capacity); // 16

            #endregion

            #region 2.1.3 Create List<T>

            #region 1-List<T>()
            //// New instance of the List<T> class that is empty and has the default initial capacity.
            //List<int> ListOfInt = new List<int>();

            //Console.WriteLine($"The Count Of List {ListOfInt.Count}"); // 0
            //Console.WriteLine($"The Capacity Of List {ListOfInt.Capacity}"); // 0

            //ListOfInt.Add(10);

            //Console.WriteLine("\nAfter Adding First Element\n");
            //Console.WriteLine($"The Count Of List {ListOfInt.Count}"); // 1
            //Console.WriteLine($"The Capacity Of List {ListOfInt.Capacity}"); // 4

            //ListOfInt.AddRange(new int[] { 20, 30, 40, 50 });

            //Console.WriteLine("\nAfter Adding 5 Elements\n");
            //Console.WriteLine($"The Count Of List {ListOfInt.Count}"); // 5
            //Console.WriteLine($"The Capacity Of List {ListOfInt.Capacity}"); // 8

            //ListOfInt.TrimExcess();

            //Console.WriteLine("\nAfter Time List\n");
            //Console.WriteLine($"The Count Of List {ListOfInt.Count}"); // 5
            //Console.WriteLine($"The Capacity Of List {ListOfInt.Capacity}"); // 5

            //ListOfInt[0] = 110; // Using Indexer As Setter

            //Console.Write("\nList Elements: ");
            //for (int i = 0; i < ListOfInt.Count; i++)
            //{
            //    Console.Write($"{ListOfInt[i]} "); // Using Indexer // List Elements: 110 20 30 40 50
            //}

            ////ListOfInt[6] = 500; // Invalid => We Can't Use Indexer To Adding 
            #endregion

            #region 2-List<T>(Int32)
            //// New instance of the List<T> class that is empty and has the specified initial capacity.
            //List<int> ListOfInt02 = new List<int>(5) { 10, 20, 30, 40, 50 };

            //Console.WriteLine($"The Count Of List {ListOfInt02.Count}"); // 5
            //Console.WriteLine($"The Capacity Of List {ListOfInt02.Capacity}"); // 5

            //ListOfInt02.Add(60);
            ////ListOfInt02.Add("Abdalrhman"); // Invalid => Compiler Will Ensure Type Safety At Compilation Time

            //Console.WriteLine(SumListElements(ListOfInt02)); // 210
            #endregion

            #endregion

            #endregion

            #region Other Lists

            #region 2.2 LinkedList<T>

            #region 2.2.1 What is LinkedList<T>?
            /*
             * LinkedList<T> is List of nodes, every node consist of value and pointer refer to next node.
            */

            #endregion

            #region 2.2.2 LinkedList Methods
            /*
             * 1.<LinkedList>.AddFirst(T <Value>) => - Add new node containing the <Value> at start of <LinkedList>
                                                     - Return LinkedListNode<T> containing the <Value>

             * 2.<LinkedList>.AddLast(T <Value>) => - Add new node containing the <Value> at end of <LinkedList>
                                                    - Return LinkedListNode<T> containing the <Value>


             * 3.<LinkedList>.AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode) 
                              => Adds a new node or value after an existing node in the LinkedList.
             
             
             * 4.<LinkedList>.AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) 
                              => Adds a new node or value before an existing node in the LinkedList.


             * 5.<LinkedList>.Find(T <Value>) => - Finds the first node that contains the specified value.
                                                 - Return LinkedListNode<T> containing the <Value> if found, otherwise null.
             
             * 6.<LinkedList>.FindLast(T <Value>) => - Finds the last node that contains the specified value.
                                                     - Return LinkedListNode<T> containing the <Value> if found, 
                                                       otherwise null
            */
            #endregion

            #region 2.2.3 Create LinkedList

            #region 1-LinkedList()
            //// Initializes a new instance of the LinkedList class that is empty.
            //LinkedList<int> linkedList = new LinkedList<int>();

            //Console.WriteLine($"The Count Of LinkedList: {linkedList.Count}"); // 0

            //linkedList.AddFirst(10);
            //linkedList.AddLast(50);

            //Console.WriteLine("\nAfter Adding To LinkedList\n");
            //Console.WriteLine($"The Count Of LinkedList: {linkedList.Count}"); // 2

            //linkedList.AddAfter(linkedList.Find(10), 20);
            //linkedList.AddBefore(linkedList.Find(50), 40);

            //Console.Write("\nElements Of LinkedList: ");
            //foreach (int i in linkedList)
            //{
            //    Console.Write($"{i} "); // Elements Of LinkedList: 10 20 40 50
            //}
            #endregion

            #endregion

            #endregion

            #region 2.3 Stack<T> [LIFO]

            #region 2.3.1 What Is The Stack<T>?
            /*
             * Stack represents a last-in, first out collection of object
              
             * It is used when you need a last-in, first-out access to items
              
             * When you add an item in the list, it is called (pushing) the item 
               and when you remove it, it is called (popping) the item.
            */
            #endregion

            #region 2.3.2 Stack Methods
            /*
             * 1.<Stack>.Push(T <Value>) => Insert <Value> at the top of the <Stack>
             
             * 2.<Stack>.Peek() => Returns the object at the top of the Stack without removing it.
             
             * 3.<Stack>.Pop() => Removes and returns the object at the top of the Stack.
            */
            #endregion

            #region 2.3.3 Creat Stack

            #region 1-Stack()
            //// Initializes a new instance of the Stack class that is empty and has the default initial capacity.
            //Stack<int> stack = new Stack<int>(); 

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //Console.WriteLine(stack.Peek()); // 30

            //Console.WriteLine(stack.Pop()); // 30

            //Console.WriteLine(stack.Peek()); // 20
            #endregion

            #endregion

            #endregion

            #region 2.4 Queue<T> [FIFO]

            #region 2.4.1 What Is Queue<T>?
            /*
             * Queue<T> represents a first-in, first out collection of object.
             
             * It is used when you need a first-in, first-out access of items.  
             
             * When you add an item in the list, it is called (enqueue),
               and when you remove an item, it is called (dequeue).
            */
            #endregion

            #region 2.4.2 Queue Methods
            /*
             * 1.<Queue>.Enqueue(T <Value>) => Adds an object to the end of the Queue.
             
             * 2.<Queue>.Peek() => Returns the object at the beginning of the Queue without removing it.
             
             * 3.<Queue>.Dequeue() => Removes and returns the object at the beginning of the Queue.
            */
            #endregion

            #region 2.4.3 Create Queue

            #region 1-Queue()
            //// New instance of the Queue that is empty, has the default initial capacity, and uses the default growth factor.
            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);

            //Console.WriteLine(queue.Peek()); // 10
            //Console.WriteLine(queue.Dequeue()); // 10
            //Console.WriteLine(queue.Peek()); // 20
            #endregion

            #endregion

            #endregion

            #endregion

            #endregion

            #region HashTable
            // The HashTable (Non-Generic) class represents a collection of key/value pairs that are organized based on the hash code of the key. 

            #region 2.5 Dictionary<TKey, TValue>

            #region 2.5.1 Waht Is Dictionary<TKey, TValue>?
            /*
             * New Version of HashTable (Non-Generic).
             
             * Dictionary<TKey, TValue> is a collection of Keys and Values. 
             
             * The Dictionary <TKey, TValue> generic class provides a mapping from a set of keys to a set of values. 
             
             * The <TKey> Must Be Unique.
            */
            #endregion

            #region 2.5.2 Dictionary Methods
            /*
             * 1.<Dictionary>.Add(TKey, TValue) => Adds the specified key and value to the dictionary. 
             
             * 2.<Dictionary>.ContainsKey(TKey) => - Determines whether the Dictionary<TKey, TValue> contains the specified key.
                                                   - Return 'true' if the Dictionary<TKey, TValue> contains the key
                                                     otherwise 'false'
             
             * 3.<Dictionary>.TryAdd(TKey, TValue) => - Attempts to add the specified key and value to <Dictionary>
                                                      - Return 'true' if key/value pairs add successfully otherwise 'false'

             * 4.<Dictionary>.TryGetValue(TKey, out TValue) => - Gets the value associated with the specified key.
                                                               - Return 'true' if the Dictionary<TKey, TValue>
                                                                 contains the elements with the specified key, otherwise 'false'                                                                                       
            */
            #endregion

            #region 2.5.3 Create Dictionary
            ////New instance of the Dictionary<TKey, TValue> that is empty, has the default initial capacity
            //Dictionary<string, int> PhoneBook = new Dictionary<string, int>();

            //PhoneBook.Add("Abdalrhman", 123);
            //PhoneBook.Add("Ahmed", 456);
            //PhoneBook.Add("Ali", 789);
            ////PhoneBook.Add("Abdalrhman", 129); // UnSafe Code // An item with the same key has already been added. Key: Abdalrhman

            //PhoneBook["Ahmed"] = 999; // Use Indexer As Setter
            //Console.WriteLine($"{PhoneBook["Ahmed"]}"); // 999 => Use Indexer As Getter

            //PhoneBook["Mona"] = 333; // Use Indexer For Adding

            //foreach (KeyValuePair<string, int> item in PhoneBook)
            //{
            //    Console.Write($"{item} "); // [Abdalrhman, 123] [Ahmed, 999] [Ali, 789] [Mona, 333]
            //}

            ////PhoneBook.Add("Mona", 888); // UnSafe Code // An item with the same key has already been added. Key: Mona

            //if (!PhoneBook.ContainsKey("Mona"))
            //    PhoneBook.Add("Mona", 888);

            //PhoneBook.TryAdd("Mona", 888);


            //if (!PhoneBook.ContainsKey("Mona"))
            //    PhoneBook.Add("Mona", 888);
            //else
            //    PhoneBook["Mona"] = 444; // Update


            //if (!PhoneBook.TryAdd("Mona", 9999999))
            //    PhoneBook["Mona"] = 9999999; // Update

            //Console.WriteLine(PhoneBook["Yasmin"]); // UnSafe Coe // The given key 'Yasmin' was not present in the dictionary.

            //PhoneBook.TryGetValue("Yasmin", out int Number);

            //Console.WriteLine($"\n{Number}"); //0

            #endregion

            #endregion

            #region 2.6 HashSet<T>

            #region 2.6.1 What is HashSet<T>?
            /*
             * HashSet<T> is an unordered collection of the unique elements. 

             * It is used in a situation where we want to prevent duplicates from being inserted in the collection. 
            */
            #endregion

            #region 2.6.2 Dictionary Methods
            /*
             * <HashSet>.Add(T) => Adds the specified element to a set.
            */
            #endregion

            #region 2.6.3 Create Dictionary
            //// New instance of the HashSet class that is empty and uses the default equality comparer for the set type.
            //HashSet<int> Set = new HashSet<int>();

            //Set.Add(1);
            //Set.Add(2);
            //Set.Add(3);
            //Set.Add(1);

            //foreach (int i in Set)
            //{
            //    Console.WriteLine($"{i} "); // 1 2 3
            //}

            #endregion

            #endregion

            #endregion

            #endregion

            #region Array Vs. ArrayList Vs. List<T> Vs. LinkedList<T>
            /*
             * 1. Array:              
               * Use Case: When you have a collection of a fixed number of homogeneous items (same type). 

             * 2. ArrayList:              
               * Use Case: When you have a dynamic-sized collection of heterogeneous objects (different types).

             * 3. Lis<T>:
               * Use Case: When you need a dynamic-sized collection of homogeneous items and frequently retrieve data.    

             * 4. LinkedList<T>:
               * Use Case: When you have a dynamic-sized collection of homogeneous items and frequently add or remove items,
                           especially at the beginning or middle of the list.              
            */
            #endregion

            #endregion

            #region Delegates

            #region 1 What is Delegates?
            /*
             * Delegates is  A C# Language Feature (similar to the [function pointer] in C/C++)
             
             * A delegate is a reference type variable that can hold a reference to the methods.
             
             * Has 2 Usage 
               * 1. Pointer To Function
               * 2. Event-Driven Programing

             * Delegate in Compilation Time Will Turn into a Normal Class.
             * Reference From Delegate Can Refer To More One Function
            */
            #endregion

            #region 2 Declaring a Delegate
            /*
             * Delegate type can be declared using the 'delegate' keyword.  
             * Once a delegate is declared, delegate instance will refer and call those methods whose return type 
               and parameter-list matches with the delegate declaration.
             
             * The Functions Must be with the Same Signature of The Delegate Regardless Function Name & Access Modifier.
             
             * Syntax => [modifier] delegate [return_type] [delegate_name] ([parameter_list]);
            */
            #endregion

            #region 3 Delegate Usage
            /*
             * Step 0. Delegate Declaration 
             
             * Step 1. Declare Reference From Delegate
             
             * Step 2. Initialize Reference From Delegate (Pointer To Function)
                    * Syntax : [delegate_name] [instance_name] = new [delegate_name];
                               OR
                               [delegate_name] [instance_name] = [methodsRef]; // Syntax Sugar 

             * Step 3. Use Delegate Reference (Call Method) 
                      * Syntax : [delegate_name]([parameter_list])
                                 OR
                                 [delegate_name].Invoke([parameter_list])
            */
            #endregion

            #region 4 Delegates Example

            //// Function بتاع ال Address من ال reference يشيل X انا عايز اخلي ال
            ////int X = String_Functions.GetCountOfUpperChars; // Cannot convert method group 'GetCountOfUpperChars' to non-delegate type 'int'.


            ////// Step 1: Declare Reference Form Delegate
            //StringFuncDelegate stringFuncDelegate;


            ////// Step 2: Initialize Reference From Delegate
            ////stringFuncDelegate = new StringFuncDelegate(String_Functions.GetCountOfUpperChars);
            //stringFuncDelegate = String_Functions.GetCountOfUpperChars; 
            //// String_Functions => GetCountOfUpperChars Only


            ////// Step 3: Use Delegate Reference 
            ////int ResultUpper = stringFuncDelegate("Abdalrhman Gamal");
            //int ResultUpper = stringFuncDelegate.Invoke("Abdalrhman Gamal");

            //stringFuncDelegate += String_Functions.GetCountOfLowerChars; // الاول stringFuncDelegate لل assign لازم اعمل
            //// String_Functions => GetCountOfUpperChars + GetCountOfLowerChars 

            //int ResultLower = stringFuncDelegate.Invoke("Abdalrhman Gamal");

            //Console.WriteLine(ResultUpper); // 2
            //Console.WriteLine(ResultLower); // 13

            #endregion

            #endregion
        }
    }
}
