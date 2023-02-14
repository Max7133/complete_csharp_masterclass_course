// See https://aka.ms/new-console-template for more information

///////////////////////// O   O   P ///////////////////////////////

using csharp_oop;

// Creating an object out of a Human Class
// an instance of Human
Human max = new Human("Max", "P.", 34, "gray");
// access public variable from outside, and even change it
// DON'T NEED THIS AFTER CONSTRUCTOR
/*max.firstName = "Max";
max.lastName = "P.";*/
// call methods of the class
max.IntroduceMyself(); // Hi, I'm Max P. I'm 34 years old, and my eye color is gray

// Creating a 2nd object out of a Human Class
Human igor = new Human("Igor", "M.", 33, "brown");
// DON'T NEED THIS AFTER CONSTRUCTOR
/*igor.firstName = "Igor";
igor.lastName = "M.";*/
igor.IntroduceMyself(); // Hi, I'm Igor M. I'm 33 years old, and my eye color is brown

// Creating a 3rd object that 
Human defaultHuman = new Human();
defaultHuman.IntroduceMyself(); // Hi, I'm   I'm 0 years old, and my eye color is

///////////////////////// Lecture 77 PROPERTIES //////////////////////////////////////////////

Box box = new Box(3,4,5);
//box.length = 3; // because of the PRIVATE I can't Set it
//box.SetLength(4);
//box.height = 4;
//box.Height = -4; // 4 will be the value (height = value; in Box Class)
//box.Width = 5;
//Console.WriteLine("Box length is " + box.length); // and I can't Get it
Console.WriteLine("Boxes volume is " + box.Volume);
Console.WriteLine("Boxes width is " + box.Width); // Boxes width is 5
box.Width = 10;
Console.WriteLine("Boxes width is " + box.Width); // Boxes width is 10
box.DisplayInfo();

///////////////////////// Lecture 80 Members And Finalizers/Destructors //////////////////////////////////////////////

Members member1 = new Members();
member1.Introducing(true);
