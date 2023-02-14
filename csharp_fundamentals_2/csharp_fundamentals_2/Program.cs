// See https://aka.ms/new-console-template for more information

// lecture 40

using System;
using System.Xml.Linq;

string friend1 = "Vitautsas";
string friend2 = "Thomas";
string friend3 = "Maksim";

// Lecture 42
GreetFriend(friend1);
GreetFriend(friend2);
GreetFriend(friend3);
//////////


Console.WriteLine(Add(10, 23)); // 33
WriteSomething();
WriteSomethingSpecific("I am an argument and am called from a method");


static void WriteSomething()
{
    Console.WriteLine("I am called from a method");
}

static void WriteSomethingSpecific(string myText)
{
    Console.WriteLine(myText);
}

// Lecture 41, Methods with Return Value and Parameters

static int Add(int num1, int num2)
{
    return num1 + num2;
}

// Lecture 42, Challenge - Methods


static void GreetFriend(string friendName)
{
    Console.WriteLine("Hi " + friendName + " my friend !");
}

// Lecture 44, User Input

Calculate();

static void Calculate()
{
    Console.WriteLine("Please enter the first number");
    string number1Input = Console.ReadLine();
    Console.WriteLine("Please enter the second number");
    string number2Input = Console.ReadLine();

    // Converting String to Integer
    //int number1 = Convert.ToInt32(number1Input);
    //int number2 = Convert.ToInt32(number2Input);
    int number1 = int.Parse(number1Input);
    int number2 = int.Parse(number2Input);

    int result = number1 + number2;

    Console.WriteLine(result);
}

// Lecture 45, Try, Catch and Finally
Console.WriteLine("Please enter a number!");
string userInput = Console.ReadLine();
try
{
    int userInputAsInt = int.Parse(userInput);
}
catch (FormatException) // now the program won't crash if I enter string
{
    Console.WriteLine("Format exception, please enter the correct type.");
}
catch (OverflowException)
{
    Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
}
catch (ArgumentNullException)
{
    Console.WriteLine("ArgumentNullException, the value was empty(null)");
}
finally // will execute after try and catch are done, doesn't matter if there was or was no error
{
    Console.WriteLine("This is called anyways!");
} // when I wan't to close the file or the connection either way

///////////// Lecture 46, Try, Operators

int numOne = 5;
int numTwo = 3;
int numThree;

///// Unary Operators
numThree = -numOne; // it will multiply numOne with -1
Console.WriteLine("numThree is {0}", numThree);

bool isSunny = true;
Console.WriteLine("is it sunny? {0}", !isSunny); //!isSunny = is Not sunny = false;

//// Increment Operators
int number = 0;
number++;
Console.WriteLine("nummber is {0}", number); // 1
// post increment
Console.WriteLine("nummber is {0}", number++); // 1 (number++ will add + 1 only on the Next line)
// pre increment
Console.WriteLine("nummber is {0}", ++number); // 3 (++number will add + 1 on the Same line)

//// + Operators
int results;

results = numOne + numTwo;
Console.WriteLine("result of numOne + numTwo is {0}", results); // result of number1 + number2 is 8

// Relational and Type Operators
bool isLower;
isLower = numOne < numTwo;
Console.WriteLine("result of numOne < numTwo is {0}", isLower); // false

// Equality Operator
bool isEqual;
isEqual = numOne == numTwo; // = assigning equal; == comparing equal;
Console.WriteLine("result of numOne == numTwo is {0}", isEqual); // false
 
isEqual= numOne != numTwo;
Console.WriteLine("result of numOne != numTwo is {0}", isEqual); // true

// Conditional Operators
bool isLowerAndSunny;
isLowerAndSunny = isLower && isSunny; // false, false
Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny); // false

// Or Operator
isLowerAndSunny = isLower && isSunny;
Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny); // false (if 1 of them was true, then it would be true)
