// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;

Console.WriteLine("Hello, World!");

//////////////////////// INTEGERS //////////////////////

// declaring a variable
int num1;

// declaring multiple variables at once
int num3, num4, num5;

// assigning a value to a variable
num1 = 13;

// declaring and initializing a variable in one go
int num2 = 23;
num2 = 100;

// using concatination
Console.WriteLine("num1 is " + num1);
int sum = num1 + num2;
Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

//////////////////////// DOUBBLES //////////////////////

double d1 = 3.1415;
double d2 = 5.1;
double dDiv = d1 / d2;
Console.WriteLine("d1/d2 is " + dDiv);

//////////////////////// FLOATES //////////////////////
float f1 = 3.1415f;
float f2 = 5.1f;
float fDiv = f1 / f2;
Console.WriteLine("f1/f2 is " + fDiv);

//////////////////////// STRINGS //////////////////////
string myname = "Max";
string message = "My name is " + myname;
string capsMessage = message.ToUpper();
string lowerCaseMessage = message.ToLower();
Console.WriteLine(lowerCaseMessage);

//////////////// NAMING CONVENTIONS ////////////////////
// Class names like Program or ClientActivity
// Method names like CalculateValue or Value
// Method arguments like firstNumber

// For Variables 
// local variable like itemCount, use user Control instead of usrCtr
// DON'T use number at the start of Variable names for e.g. int 3cars = 5;
// However THIS is allowed for e.g. int cars3 = 5;
// AVOID UNDERSCORE for e.g. int cars_engine = 5;
// However THIS is allowed for e.g. int _loginDate = 5; or _login

// CORRECT
string myName;
int lastNum;
bool isSaved;

// AVOID!
// String myName;
// Int32 lastNum;
// Boolean isSaved;

/////////////////////////////////////////////////////////////
///////////// IMPLICIT AND EXPLICIT CONVERSION///////////////

// IMPLICIT CONVERSION
int number = 12390532;
long bigNum = number; // I can assign a smaller Type Value to a Bigger one

// or even I can assign Double to Float
float myFloat = 13.37F;
double myNewDouble = myFloat;

double myDouble = 13.37;
int myInt;

// EXPLICIT CONVERSION
// cast double to int;
myInt = (int)myDouble; // makes a Integer out of a Double <-- EXPLICIT CONVERSION

// TYPE CONVERSION
// making a String out of Double or Integer e.g.
string myString = myDouble.ToString(); // "13.37"
string myFloatString = myFloat.ToString();  // 13.37
bool sunIsShining = false;

string myBoolString = sunIsShining.ToString();

Console.WriteLine(myBoolString); // False


///////////////// PARSING A STRING TO AN INTEGER ////////////////////////

string myFirstString = "15";
string mySecondString = "13";
int numOne = Int32.Parse(myFirstString); // Same For Doubles e.g. Double.Parse
int numTwo = Int32.Parse(mySecondString);
int resultInt = numOne + numTwo; // 28 
string result = myFirstString + mySecondString; // 1513

// ASSIGNMENT 1

string stringForFloat = "0.85"; // datatype should be float
string stringForInt = "12345"; // datatype should be int

float stringToFloat = float.Parse(stringForFloat, CultureInfo.InvariantCulture.NumberFormat);
int stringToInt = Int32.Parse(stringForInt);

Console.WriteLine(stringToFloat); // 0,85
Console.WriteLine(stringToInt); // 12345

///////////////////// STRING MANIPULATION ////////////////////////
// define few variables
int age = 31;
string name = "Pedro";
string job = "Developer";

// 1. String concatenation
Console.WriteLine("String Concatenation");
Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old");

// 2. String formatting
// string formatting uses index
Console.WriteLine("String Formatting");
Console.WriteLine("Hello my name is {0} , I am {1} years old. I'm a {2}", name, age, job);
// Output:
// Hello my name is Pedro , I am 31 years old. I'm a Developer

// 3. String interpolation.
// string Interpolation uses $ at the start which will allow us to write our variable like this {variableName}
Console.WriteLine("String Interpolation");
Console.WriteLine($"Hello my name is {name} , I am {age} years old");

// 4. Verbatim strings.
// verbatim strings start with @ and tells the compiler to take the string literally and ignore any spaces and escape characters like \n
Console.WriteLine("Verbatim strings");
Console.WriteLine(@"Lorem ipsum dolor sit amet ipsum dolor sit amet 
ipsum dolor sit amet ipsum dolor sit amet ipsum dolor sit amet 
ipsum dolor sit amet ipsum dolor sit
amet ipsum dolor sit amet 


ipsum dolor sit amet ipsum dolor sit amet ipsum dolor sit amet 
ipsum dolor sit amet ipsum dolor sit amet ipsum dolor sit amet 
ipsum dolor sit amet");

// instead of using \\ to write file paths we can use verbatim strings to make it easier
// if you remove the @ you will get an error because \U, \A and \D are not valid escape characters for e.g.
Console.WriteLine(@"C:\User\Admin\Dog Pictures\Dog1\Super CoolDog.png");

// with verbatim strings even valid escape characters won't work
Console.WriteLine(@"Muahaha \n you have no powers here!.");
Console.WriteLine("Oh.. \n you have powers here!.");

// Assignment 2
string myNamee;
Console.Write("Please enter your name and press enter : ");
myNamee = Console.ReadLine();
string upperName = String.Format("Upper case : {0}", myNamee.ToUpper());
Console.WriteLine(upperName); // MAKSIM PASNITSENKO
string lowerName = String.Format($"Lower case : {myNamee.ToLower()}");
Console.WriteLine(lowerName); // maksim pasnitsenko
string trimmedName = String.Format($"Trimmed value : {myNamee.Trim()}");
Console.WriteLine(trimmedName); // Maksim Pasnitsenko
string subName = String.Format($"Sub value : {myNamee.Substring(0, 6)}");
Console.WriteLine(subName); // Maksim

// Assignment 3 TODO

///////////////// CONST ////////////////////////

// constants as fields
const double PI = 3.14159265359;
const int weeks = 52, monhts = 12;
const string birthday = "04.04.1988";
const string birthday2 = "19.11.1988";
const string birthday3 = "02.06.2020";

//Console.Read(); // Read needs to be after ALL consoles
Console.WriteLine("My birthday is always going to be: {0}", birthday); // without {0} birthday won't be printed
Console.ReadKey();