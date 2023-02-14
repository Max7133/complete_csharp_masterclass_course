// See https://aka.ms/new-console-template for more information

// Lecture 49, Introduction to Decision Making in C#
// & Lecture 51, If, Else If + TryParse

Console.WriteLine("What's the temperature like?");
string temperature = Console.ReadLine();
int numTemp;
int number;
bool userEnteredANumber = int.TryParse(temperature, out number); // "out" - output number

if (userEnteredANumber)  
{
    numTemp = number; // with succesfull parsing numTemp will become number
}
else
{
    numTemp = 0; // if User didn't enter anything
    Console.WriteLine("The entered value was not a number, 0 set as temperature");
}

if (numTemp < 20)
{
    Console.WriteLine("Take the coat");
}else if(numTemp == 20)
{
    Console.WriteLine("Pants and Pull Over should be fine");
}else
{
    Console.WriteLine("Shorts are enough today");
}

//// Coding Challenge 2
static void Check(int number)
{
    // TODO
    if (number % 2 == 0)
    {
        Console.WriteLine("Even");
    }
    else
    {
        Console.WriteLine("Odd");
    }
}
Check(21); // Odd

////// Lecture 52, Nested If Statements

bool isAdmin = false;
bool isRegistered = true;
Console.WriteLine("Please enter your username");
string userName = Console.ReadLine();

if (isRegistered && userName != "" && userName.Equals("admin")) // Equals (is for strings) checks whatever is inside of userName and compares it with the String. ("admin")
{
    Console.WriteLine("Hi there, registered user");

        Console.WriteLine("Hi there, " + userName);

            Console.WriteLine("Hi there, Admin");
        
}

if(isAdmin || isRegistered)
{
    Console.WriteLine("You are logged in");
}

// Coding Challenge 3
static void NestedCheck(int number)
{
    if (number%3 == 0)
    {
        Console.WriteLine("Divisible by 3");
    }
    else if (number%7 == 0)
    {
        Console.WriteLine("Divisible by 7");
    }
    else if (number%1 == 0)
    {
        Console.WriteLine("Odd number");
    } 
    else 
    { 
        Console.WriteLine("The number is even");
    }
}

NestedCheck(21);

////// Lecture 52, Switch Statement

int age = 25;

switch (age)
{
    case 15:
        Console.WriteLine("Too young to party in the club!");
        break; // if it's true, then I need to break out of the switch statement.
    case 25:
        Console.WriteLine("Good to go!");
        break;
    default: // similiar to else statement (when nothing is true)
        Console.WriteLine("How old are you then?");
        break;
}

string username = "Max";

switch (username)
{
    case "Max":
        Console.WriteLine("username is Max");
        break;
    case "root":
        Console.WriteLine("username is root");
        break;
    default:
        Console.WriteLine("username is unknown");
        break;
}

////// Lecture 58, Enhanced If Statements - Ternary Operator

// condition ? first_expression : second_expression;
// condition has to be either true or false
// The conditional operator is right - associative.
// The expresssion a ? b: c? d : e
// is evaluated as a ? b : (c ? d : e),
// not as (a? b : c) ? d: e.
// The conditional operator cannot be overloaded.

int temp = -5;
string stateOfMatter;

if (temp < 0)
    stateOfMatter = "solid";
else
    stateOfMatter = "liquid";

Console.WriteLine("State of matter is {0}", stateOfMatter); // solid 

temp += 30;

// Ternary Operator
stateOfMatter = temp < 0 ? "solid" : "liquid";

temp += 100;
stateOfMatter = temp > 100 ? "gas" : temp < 0 ? "solid" : "liquid";

Console.WriteLine("State of matter is {0}", stateOfMatter); // liquid