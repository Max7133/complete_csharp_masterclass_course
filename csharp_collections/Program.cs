// See https://aka.ms/new-console-template for more information
////////////////////////////  ARRAYS  ///////////////////////////////////

// declare and initialize array grades
using csharp_collections;
using System.Collections;
using System.Net.Cache;
using System.Runtime.ConstrainedExecution;

int[] grades = new int[5];

grades[0] = 20;
grades[1] = 15;
grades[2] = 12;
grades[3] = 9;
grades[4] = 7;

Console.WriteLine("grades for index 0 : {0}", grades[0]);

string input = Console.ReadLine(); 
// assign value to array grades at index 0
grades[0] = int.Parse(input);
Console.WriteLine("grades for index 0 : {0}" , grades[0]);

// another way of initializing an array
int[] gradesOfMathStudentsA = { 20, 15, 12, 9, 7 };

// third way of initializing an array
int[] gradesOfMathStudentsB = new int[]{ 20, 15, 12, 9, 7, 8 };

Console.WriteLine("Length of gradesOfMathStudentB: {0}", gradesOfMathStudentsB.Length);

////////////////////////////  FOREACH LOOPS  ///////////////////////////////////
// foreach loop allows us to go throug a collection and a 2D, 3D matrixes, however many dimensions I want
// all of them in the end are just Collections, and an Array is a Collection Type

int[] nums = new int[10]; // 10 int values in Array

// Putting values into the Array
for(int i = 0; i < 10; i++)
{
    // Assigning the value of its index to the value itself
    nums[i] = i;
    Console.WriteLine("Element{0} = {1}", i, nums[i]); // Element0 = 0 Element1 = 1 etc..
}

int counter = 0;
foreach(int k in nums) // creates a Variable "k" and runs through the whole Array
{
 
    Console.WriteLine("Element{0} = {1}", counter, k); // Element0 = 0 Element1 = 1 etc..
    counter++;
}

string[] myFriends = { "Michael", "Wlad", "Ilja", "Andy", "Daniel" };

foreach(string name in myFriends)
{
    Console.WriteLine("Hello {0}", name); // Hello Michael Hello Wlad etc...
}

////////////////////////////  Multi Dimensional Arrays  ///////////////////////////////////

// Simple 2D Array
string[,] matrix; // declared 2D Array

// Simple 3D Array
int[,,] threeD; // declared 3D Array

// Two Dimensional Array
int[,] array2D = new int[,] // here I'm declaring how many dimensions I have
{
 { 1, 2, 3}, // row 0
 { 4, 5, 6}, // row 1 and 5 is in Index 1
 { 7, 8, 9}, // row 2
};

// Accessing 5
Console.WriteLine("Central value is {0}", array2D[1,1]); // 5

// Three Dimensional Array
string[,,] array3D = new string[,,]
{ // 1st dimnsn
    { // 2nd dimnsn (the entries are entered in exact same way how I access them for e.g. [1,1,0] == 110
        {"000", "001" }, // 3rd dimnsn
        {"010", "011" },
        {"Hi there", "What's up" } // "Hi there" = 020
    },
    {
        {"100", "101"},
        {"110", "111"},
        {"Another one", "Last entry" }
    }
};

Console.WriteLine("The value is {0}", array3D[1,1,0]); // 110

// ANOTHER way of creating Multidimensional Arrays
string[,] array2DString = new string[3, 2] // 3 rows, 2 entries per row
{
    { "one_entry", "two_entry" },
    { "three_entry", "four_entry" },
    { "five_entry", "six_entry" }
};

array2DString[1, 1] = "4 entry";
Console.WriteLine("The value is {0}", array2DString[1, 1]);

// Checking how many Dimensions does the Array have
int dimensions = array2DString.Rank; // Rank - gets the number of Dimensions of the Array
Console.WriteLine("Number of dimensions {0}", dimensions); // 2

// ALSO I can create an Array without specifying the "rank" on the Right Hand side
// for e.g.
// int[,] array2D = new int[,] - 2 dimensions
// string[,,] array3D = new string[,,] - 3 dimensions

int[,] array2D2 = { { 1, 2 }, { 3, 4 } }; // without new int[,]

////////////////////////////  Nested For Loops And 2D Arrays  ///////////////////////////////////

Console.WriteLine("\n This is my 2D Array printed using foreach loop");
int[,] matrixTwo =
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8 ,9}
};

foreach (int item in matrixTwo)
{
    Console.Write(item + " "); // 1 2 3 4 5 6 7 8 9
    //item = 3; it's imposible to assign 3 to item variable with "foreach", however it's possible with Nested For Loop
}

Console.WriteLine("\n This is my 2D Array printed using Nested For Loop");

// Nested For Loop
// I want to go through each Dimension, so I want to go through it Row by Row and Column by Column
// The 1st Dimension will be the Rows
// GetLength() where inside I meed to pass the Dimension, it represents the number of elements in the specified Dimension of the Array.
// in this case ill pass 0 to the GetLength(), GetLength(0) will return the 0 Dimensions - the whole rows 
// GetLength(0) will now allow me to go through the Whole Row

// outer for loop (for columns)
////// "i" is going to stay 0 until the "j" will finish iterating 3 times!
for (int i = 0; i < matrixTwo.GetLength(0); i++) // is 3 less then the length of that current Dimension (Row, total 3 Rows)
                                                 // For iterating through each individual column, I need to use another loop inside here.
{
    // inner for loop (for rows)
    for (int j = 0; j < matrixTwo.GetLength(1); j++) // is 3 less then the length of that current Dimension (Column, total 3 Columns)
    {
        // NOW I want to compare J not to the Length of the 1st Dimension, but of the 2nd Dimension "GetLength(1)"
        // GetLength(1) will now allow me to go through Every Single Column
        Console.Write(matrixTwo[i, j]+ " "); // display i and j, which means display the "i row" & "j column",
                                             // which means in the 1st iteration the loop with "i" will be 0, then the loop with "j" starts and when it's done, then it will only go to the Next Iteration of the OUTER FOR LOOP, only then "i" will be incremented by 1 
    }
}

int[] temperature = { 0, 13, 25, 31, 22, 32 };
for (int i = 0;i < temperature.GetLength(0); i++)
Console.WriteLine(temperature.Length);

////// Nested For Loops And 2D Arrays - Two Examples

int[,] matrixThree =
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8 ,9}
};

foreach (int item in matrixThree)
{
    Console.Write(item + " ");
}

//// Nested for loop
// outer for loop
for (int i = 0; i < matrixThree.GetLength(0); i++) 
                                                 
{
    // inner for loop
    for (int j = 0; j < matrixThree.GetLength(1); j++) 
    {
        // if Even Number - print Number
        if (matrixThree[i, j] % 2 == 0) // compares if the Modulo Remainder when Dividing numbers will have 0 (No Remainder) - Even Number
            Console.Write(matrixThree[i, j] + " ");
        else
            Console.Write(" ");
    } // OUTPUT: 2 4 6 8
}

// Printing Diagonal Elements of the Matrix e.g... 1, 5, 9 or 3, 5, 7
// i and j needs to be equal for 1, 5, 9 
// RESULT: if ([i == j]) 

// Showing 3, 5, 7
// 2 counter variables "i" and "j", but we are only limiting based on the "i" Value (THIS WILL WORK ONLY FOR THE MATRIX THAT HAS THE SAME AMOUNT OF columns as it has amount of ROWS), otherwise use Nested For Loop

Console.Write("\n");
Console.WriteLine("Getting 3, 5, 7 out of the matrixThree");
for (int i = 0, j = 2; i < matrixThree.GetLength(0); i++, j--) // "j" should start at 2, and then I decrement "j" for each iteration
{
    Console.WriteLine(matrixThree[i, j]); // 3, 5, 7
}

////////////////////////////  Jagged Arrays  ///////////////////////////////////
//// [][] - an Array within an Array || Jagged Array
// And it's not just 1 Array within Array, it's Multiple Arrays Within 1 Array.

// declare jaggedArray
int[][] jaggedArray = new int[3][]; // [3] defining how many Arrays I want to have within that Array (I want to have 3 Arrays within that Jagged Array)

// adding values to them (how long the Array are going to be)
jaggedArray[0] = new int[5]; // this one will have 5 Values (entries) in the Array
jaggedArray[1] = new int[3];
jaggedArray[2] = new int[2];

// adding values to them
jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
jaggedArray[1] = new int[] { 1, 2, 3 };
jaggedArray[2] = new int[] { 13, 21 };

// Alternative way: in adding values to them (while declaring I initialize it directly)

int[][] jaggedArray2 = new int[][]
{
    new int[] { 2, 3, 5, 7, 11 },
    new int[] { 1, 2, 3}
};

// Accessing the value 5 
Console.WriteLine("The value in the middle of the first entry is {0}", jaggedArray2[0][2]);

// CHALLENGE: Get all the values of the jaggedArray2 in to the Console
for (int i = 0; i < jaggedArray2.Length; i++)
{
    Console.WriteLine("Array {0}", i); // 1st Row
    for (int j = 0; j < jaggedArray2[i].Length; j++) // jaggedArray2[i] - I'm getting the length of the Array within the Jagged Array
    {
        Console.WriteLine("Value {0} ", jaggedArray2[i][j]);
    }
}// OUTPUT: 
 // Array 0 Value 2 Value 3 Value 5 Value 7 Value 11
 // Array 1 Value 1 Value 2 Value 3

// HOW IT LOOKS LIKE
//    index                     0    1    2    3      // Normal Array type Int
// normal Array of type int : [15],[21],[23],[13]     // index 0 = 15
//    index                         0                       1                     2              // Jagged Array type Int
// Jagged Array of type int : [array1([15],[13],[5])],[array2([7],[8],[2])],[array3([2],[4],[1])]  // Indexes here store Arrays, index 0 = [array1([15],[13],[5])] with 3 Values

////////////////////////////  Using Arrays as Parameters ///////////////////////////////////

// Using Methods with Parameters which are of type Array.
// This is the Method that I can always use whenever I want to calculate the average of an Array that is handled as an Argument
static double GetAverage(int[] gradesArray) // as Parameter I use an Array of Int and it's going to be called gradesArray
{
    int size = gradesArray.Length;
    double average;
    int sum = 0;

    for (int i = 0; i < size; i++)
    {
        sum += gradesArray[i]; // Adding the Current Value of gradesArray to the sum
    }
    average = (double)sum / size; // Casting it in to a double
    return average;
}

// Calling the Method and handing over an Array (creating an Array for this)
int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
double averageResult = GetAverage(studentsGrades); // studentsGrades as Argument

// Of what this is the Average
foreach (int grade in studentsGrades)
{
    Console.WriteLine(" {0} ", grade); // 15, 13, 8, 12, 6, 16
}

Console.WriteLine("The average is: {0}", averageResult); // The average is: 11,666666666666666

////

int[] happiness = { 2, 3, 4, 5, 6 };
SunIsShining(happiness);

foreach (int y in happiness)
{
    Console.WriteLine(y); // 4, 5, 6, 7, 8
}

static void SunIsShining(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] += 2;
    }
}

////////////////////////////  Params Keyword ///////////////////////////////////

// Console.WriteLine(); has 18 Overloads
////// Overloads - different kind of implementations for this Method.
////// Params means that it will accept as many Parameters as you give it and it will accept Parameters of type Object (means Everything)

Console.WriteLine("price is {0}, pi is {1}, at is {2}", 32, 3.14, '@'); // price is 32, pi is 3,14, at is @

// Another Params example
// I will write every single item of that parameters list that I'm going to throw at it.
static void ParamsMethod(params string[] sentence) // it will be an Array of strings "sentence"
{ // This for loop will iterate as many times as I pass Parameters to this ParamsMethod() 
    for (int i = 0; i < sentence.Length; i++)
    {
        Console.Write(sentence[i] + " "); // [i] because "sentence" is an Array of Strings
    }
}

ParamsMethod("This", " is", " a ", "long ", "string", " I ", "have", " no ", "idea ", "when ", "it's ", "going", " to", " end", "....");

// Same Params example (with Object)
static void ParamsMethod2(params object[] stuff)
{
    // for each loop to go throug the Array of Objects
    foreach (object obj in stuff)
    {
        // print each object followed by a space
        Console.Write(obj + " ");
    }
}
// EVERY SINGLE CLASS has internally a Method called ToString(), so it's inheriting from Object, which means that it has this Method. 
// So that means that whatever Object I give to the Method, it will be able to make a String out of it

int price = 69;
float pi = 3.14f;
char at = '@';
string book = "The Hobbit";

ParamsMethod2(price, pi, at, book, 3.3); // 69 3,14 @ The Hobbit 3,3
ParamsMethod2("Hello", 5.3, '$'); // Hello 5,3 $

// Another Params Example (Getting the Min Value of many given Numbers using Params)
static int MinV2(params int[] numbers)
{
    int min = int.MaxValue; // highest value a Int can have

    foreach (int number in numbers) // "numbers" that are passed to this Method once this Method is called MinV2()
    {
        if (number < min)
            min = number;
    }
    return min;
}

// Now I can throw as many Values as I want to the MinV2 Method
int minNum = MinV2(6, 4, 2, 8, 0, 1, -5);

Console.WriteLine("The minimum number is: {0}", minNum); // The minimum number is: -5

////////////////////////////  Array Lists  ///////////////////////////////////

// declaring an ArrayList with undefined amount of Objects
ArrayList myArrayList= new ArrayList();
// declaring an ArrayList with defined amount of Objects
ArrayList myArrayListDefined = new ArrayList(100);

// adding elements to an ArrayList (with ArrayList I can store any Type that I want in there)
myArrayList.Add(25);
myArrayList.Add("Any Type");
myArrayList.Add(13.37);
myArrayList.Add(13);
myArrayList.Add(128);
myArrayList.Add(25.3);
myArrayList.Add(13);

// Using Methods on myArrayList 
// this will delete element with specific value from the ArrayList
myArrayList.Remove(13); // removing NOT index, but an Object (IT WILL REMOVE THE 1st "13")

// delete element at specific index (position)
myArrayList.RemoveAt(0); // it removes the (25)

// checking how many Objects are inside the ArrayList
Console.WriteLine(myArrayList.Count);

// checking all the Objects in ArrayList
double sum = 0;

foreach (object obj in myArrayList)
{
    if(obj is int)
    {
        // the "sum" should be an Integer and the Double that are inside the ArrayList
        // I can't do that, so I'm going to convert Int to Double
        // although "obj" is not an Integer, it's an Object that CONTAINS an Integer but it's of type Object
        sum += Convert.ToDouble(obj); // "obj" is of type Object and NOT Integer, so I can cast it into a Double and add it to a double.
    }
    else if(obj is double) 
    {
        // I need to cast it to a Double
        sum += (double)obj;
    }
    else if(obj is string)
    {
        Console.WriteLine(obj);
    }
}
Console.WriteLine(sum); // 5 Any Type 179,67000000000002

////////////////////////////////////////////////////////  Hashtables  ///////////////////////////////////////////////////////////////
//// The Hashtable is a non-generic collection that stores key-value pairs, similar to generic Dictionary<TKey, TValue> collection.
//// Hashtable is a collection of dictionary entries. 
// key  - value
// Auto - car

// Initializing Hashtable
Hashtable studentsTable = new Hashtable();

// Creating students for the "studentsTable"
Student stud1 = new Student(1, "David", 71); // student Objects
Student stud2 = new Student(2, "Jason", 76);
Student stud3 = new Student(3, "Clara", 43);
Student stud4 = new Student(4, "Steve", 55);

// Adding (Storing) students data to the "studentsTable"
studentsTable.Add(stud1.Id, stud1);
studentsTable.Add(stud2.Id, stud2);
studentsTable.Add(stud3.Id, stud3);
studentsTable.Add(stud4.Id, stud4);

// retriece individual item with known ID (while creating an Object)
Student storedStudent1 = (Student)studentsTable[stud1.Id]; // Casting to Student because the Object is of Type Student

Console.WriteLine("Student ID:{0}, Name:{1}, GPA{2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA); // Student ID:1, Name:David, GPA71

// retrieve all values from a Hashtable
foreach (DictionaryEntry entry in studentsTable)
{
    // Creating a temporary value, which will be the entry value
    Student temp = (Student)entry.Value;
    Console.WriteLine("Student ID:{0}", temp.Id); // now I can use the Student ID by using template ID because "temp" now is of Type Student and Student has ID, Name, GPA
    Console.WriteLine("Student Name:{0}", temp.Name);
    Console.WriteLine("Student GPA:{0}", temp.GPA);
}// OUTPUT:
//Student ID:1, Name: David, GPA71
//Student ID:4
//Student Name:Steve
//Student GPA:55
//Student ID:3
//Student Name:Clara
//Student GPA:43
//Student ID:2
//Student Name:Jason
//Student GPA:76
//Student ID:1
//Student Name:David
//Student GPA:71

// simplifying the Upper foreach loop
foreach (Student value in studentsTable.Values) // this allows to go through the Values directly without having to casting it into a Student Object
{ // Now I can do the same thing that I did in the upper foreach, only without creating a temporary Value
    Console.WriteLine("Student ID:{0}", value.Id); 
    Console.WriteLine("Student Name:{0}", value.Name);
    Console.WriteLine("Student GPA:{0}", value.GPA);
}

////////////////////////////  Hashtable Challenge  ///////////////////////////////////

Hashtable table = new Hashtable();

StudentHashtableChallenge[] students = new StudentHashtableChallenge[5];
students[0] = new StudentHashtableChallenge(1, "Denis", 88);
students[1] = new StudentHashtableChallenge(2, "Olaf", 97);
students[2] = new StudentHashtableChallenge(6, "Ranger", 65);
students[3] = new StudentHashtableChallenge(1, "Luise", 73);
students[4] = new StudentHashtableChallenge(4, "Levi", 73);


foreach (StudentHashtableChallenge s in students)
{
    if(!table.ContainsKey(s.Id))
    {
        table.Add(s.Id, s);
        Console.WriteLine("Student with ID{0} was added!.", s.Id);
    }
    else
    {
        Console.WriteLine("Sorry, a student with the same ID already exists ID:{0}", s.Id);
    }
}

// OUTPUT:
// Student with ID1 was added!.
// Student with ID2 was added!.
// Student with ID6 was added!.
// Sorry, a student with the same ID already exists ID:1
// Student with ID4 was added!.

////////////////////////////////////////////////////////  Dictionaries  ///////////////////////////////////////////////////////////////
// Dictionary is a Collection of Key Value pairs, which is a Struct that is defined like a Key Value pair
// Basically a Generic version of Hashtables
// Dictionary will store its value in a Key Value Pair
// key  - value
// Auto - car

// Assuming this is the Data from the Database
Employee[] employees =
{
    new Employee("CEO","Gwyn",95,200), // role, name, age, rate
    new Employee("Manager","Joe",35,25),
    new Employee("HR","Lora",32,21),
    new Employee("Secretary","Petra",28,18),
    new Employee("Lead Developer","Artorias",55,35),
    new Employee("Intern","Ernest",22,8)
};

// Initializing a Dictionary
// It will store for a specific string the ENTIRE employee Object
// String is going to be the employees Role (No mather what type of Key, there is always a Number assigned to it as well)
Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

// ADDING
// This loop will fo through every single employee in my employees fake Database, 
foreach (Employee emp in employees)
{
    employeesDirectory.Add(emp.Role, emp); // and it will Add to my employeesDirectory at the position (key) of the Role the employee itself
}

// UPDATING a position at a specific Key
string KeyToUpdate = "HR";
// Checking if there is an employee in the employeesDirectory that contains this Key.
if (employeesDirectory.ContainsKey(KeyToUpdate))
{
    // replacing "Lora" with new employee at the Position ["HR"]
    employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
    Console.WriteLine("Employee with Role/Key {0} was updated!.", KeyToUpdate);
}
else
{
    Console.WriteLine("No employee found with this Key {0}", KeyToUpdate);
}

// REMOVING
string KeyToRemove = "Intern";
if(employeesDirectory.Remove(KeyToRemove))
{
    Console.WriteLine("Employee with Role/Key {0} was Removed!.", KeyToRemove);
}
else
{
    Console.WriteLine("No employee found with this Key {0}", KeyToRemove);
}
 
for (int i = 0; i < employeesDirectory.Count; i++)
{
    // using ElementAt(i) to return the key-value pair stored at index i
    KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
    // print the key
    Console.WriteLine("Key: {0}", keyValuePair.Key);
    // storing the value in an employee object
    Employee employeeValue = keyValuePair.Value;
    // printing the Properties of the Employee Object
    Console.WriteLine("Employee Name: {0}", employeeValue.Name);
    Console.WriteLine("Employee Role: {0}", employeeValue.Role);
    Console.WriteLine("Employee Age: {0}", employeeValue.Age);
    Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
}// OUTPUT:
//Key: CEO
//Employee Name: Gwyn
//Employee Role: CEO
//Employee Age: 95
//Employee Salary: 384000
//Key: Manager
//Employee Name: Joe
//Employee Role: Manager
//Employee Age: 35
//Employee Salary: 48000
//Key: HR
//Employee Name: Lora
//Employee Role: HR
//Employee Age: 32
//Employee Salary: 40320
//Key: Secretary
//Employee Name: Petra
//Employee Role: Secretary
//Employee Age: 28
//Employee Salary: 34560
//Key: Lead Developer
//Employee Name: Artorias
//Employee Role: Lead Developer
//Employee Age: 55
//Employee Salary: 67200
//Key: Intern
//Employee Name: Ernest
//Employee Role: Intern
//Employee Age: 22
//Employee Salary: 15360

// checking for THAT available KEY
string key = "CEO";
if (employeesDirectory.ContainsKey(key))
{
    // getting the data from the Dictionary of the employee CEO 
    Employee empl = employeesDirectory[key];
    Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary); // Employee Name: Gwyn, Role: CEO, Salary: 384000
}
else
{
    Console.WriteLine("No employee found with this Key {0}", key);
}

Employee result = null;
//using TryGetValue() it returns true if the operation was successful and false otherwise
if (employeesDirectory.TryGetValue("Intern", out result)) // the "out" will put the Value into result
{
    Console.WriteLine("Value Retrieved!");

    Console.WriteLine("Employee Name: {0}", result.Name);
    Console.WriteLine("Employee Name: {0}", result.Role);
    Console.WriteLine("Employee Name: {0}", result.Age);
    Console.WriteLine("Employee Name: {0}", result.Salary);
}
else
{
    Console.WriteLine("The key does not exist");
}// OUTPUT:
// Value Retrieved!
// Employee Name: Ernest
// Employee Name: Intern
// Employee Name: 22
// Employee Name: 15360

// Getting an Element with the ElementAt() Method

////////////////////////////////////////////////////////  STACKS  ///////////////////////////////////////////////////////////////
///// Stack is a Generic Collection
///// The stack could hold any other Type of Object (strings, my own Classes etc) BUT only 1 Type per Stack!!! (bc. Generic)

// DEFINING the Stack with type Int
Stack<int> stack = new Stack<int>();
// ADDING values to stack using Push() (inserts an Object at the Top of the Stack (LAST ITEM) )
stack.Push(1);
// CHECKING what value is at the TOP of the Stack
// Peek() will return the element at the TOP of the Stack without removing it
Console.WriteLine("Top value in the stack is : {0}", stack.Peek()); // Top value in the stack is : 1
stack.Push(2);
Console.WriteLine("Top value in the stack is : {0}", stack.Peek()); // Top value in the stack is : 2
stack.Push(3);
// REMOVING this will "remove" the item and Pop() will "return" the removed item
int myRemovedStackItem = stack.Pop();
Console.WriteLine("Popped item : {0}", myRemovedStackItem); // Popped item : 3
Console.WriteLine("Top value in the stack is : {0}", stack.Peek()); // Top value in the stack is : 2

// EXAMPLE Deleting Item with while loop, until no items left in the Stack
while (stack.Count > 0)
{
    // Pop() will return the element that was removed from the Stack
    Console.WriteLine("Top value {0} was removed from the stack", stack.Pop());
    // Print the Stack Count
    Console.WriteLine("Current Stack count is : {0}", stack.Count);
} // OUTPUT: (Last In First Out)
// Top value 2 was removed from the stack
// Current Stack count is : 1
// Top value 1 was removed from the stack
// Current Stack count is : 0

// REVERSING AN ARRAY with Stack
int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
// Defining a New Stack of Int
Stack<int> myStack = new Stack<int>();

// DISPLAYING the Items that I have in my "numbers" Array
Console.WriteLine("The numbers in the Array are :"); // The numbers in the Array are : 8 2 3 4 7 6 2
// foreach Number in the "numbers" Array
foreach (int number in numbers)
{
    // print them
    Console.Write(number + " ");
    // push is into my Stack (Add)
    myStack.Push(number);
}

Console.WriteLine("");
Console.WriteLine("The numbers in reverse :"); // The numbers in reverse : 2 6 7 4 3 2 8
// as long as my Stack is not empty
while (myStack.Count > 0)
{
    // Pop it and store it in a Variable (Popps the Last item)
    int number = myStack.Pop();
    // print the Popped Value 
    Console.Write(number + " ");
}

////////////////////////////////////////////////////////  QUEUES  ///////////////////////////////////////////////////////////////
//// Queues should be used when the order of the data is Important !
//// Queues are also part of the type of Generic Collections

// DEFINING a Queue of Integers
Queue<int> queue = new Queue<int>();
// Adding Items to this Queue with Enqueue() Method (WILL BE THE LAST ITEM IN THE QUEUE)
queue.Enqueue(1);
// PRINTING the Element at the front of the Queue
// Peek() Method will display the 1st item in the Queue (the item in the front of the Queue)
Console.WriteLine("The value at the front of the Queue is : {0}", queue.Peek()); // The value at the front of the Queue is : 1
queue.Enqueue(2);
Console.WriteLine("Top value in the Queue is : {0}", queue.Peek()); // Top value in the Queue is : 1
queue.Enqueue(3);
// REMOVING the item from the Queue with Dequeue()
// It will remove the 1st item in the Queue and store it straight away
// int queueItem = queue.Dequeue();
Console.WriteLine("Top value in the Queue is : {0}", queue.Peek()); // Top value in the Queue is : 2

while (queue.Count > 0)
{
    // Dequeue() will returnthe element that was removed from the Queue
    Console.WriteLine("The front value {0} was removed from the queue", queue.Dequeue());
    // print the queue count
    Console.WriteLine("Current queue count is : {0}", queue.Count);
} // OUTPUT
// The front value 1 was removed from the queue
// Current queue count is : 2
// The front value 2 was removed from the queue
// Current queue count is : 1
// The front value 3 was removed from the queue
// Current queue count is : 0

// This method will create an Array of orders and return it
static Order[] RecieveOrdersFromBranch1()
{
    // Creating new orders Array
    Order[] orders = new Order[]
    {
        new Order(1,5),
        new Order(2,4),
        new Order(6,10)
    };

    return orders;
}

static Order[] RecieveOrdersFromBranch2()
{
    // Creating new orders Array and initializing it with some Objects of type Order
    Order[] orders = new Order[]
    {
        new Order(3,5),
        new Order(4,4),
        new Order(5,10)
    };
    // return the Array of orders that were created
    return orders;
}

// Creating a Queue of Orders
Queue<Order> ordersQueue = new Queue<Order>();

foreach (Order o in RecieveOrdersFromBranch1())
{
    // Add each order to the Queue
    ordersQueue.Enqueue(o);
}

foreach (Order o in RecieveOrdersFromBranch2())
{
    // Add each order to the Queue
    ordersQueue.Enqueue(o);
}

// As long as the Queue is not empty
while (ordersQueue.Count > 0)
{
    // Remove the order At the front of the queue
    // and store it in a Variable called currentOrder
    Order currentOrder = ordersQueue.Dequeue();
    // Process the Order
    currentOrder.ProcessOrder();
}
