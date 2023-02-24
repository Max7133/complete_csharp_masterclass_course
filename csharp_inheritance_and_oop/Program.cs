/////////////////////////////////////////////////////  INHERITANCE  /////////////////////////////////////////////////////

using csharp_inheritance_and_oop;

Post post1 = new Post("Tnx for gift!", true, "Max Pas");
Console.WriteLine(post1.ToString()); // 0 - Tnx for gift! - by Max Pas
ImagePost imagePost1 = new ImagePost("Check out my new shoes!", "Max Pas", "http://images.com/shoes", true);
Console.WriteLine(imagePost1.ToString()); // 2 - Check out my new shoes! - by Max Pas

// Lecture 118: Inheritance Example
Radio myRadio = new Radio(false, "Sony");
myRadio.SwitchOn();
myRadio.ListenRadio();

TV myTV = new TV(false, "Samsung");
// method of Base Class (Parent)
myTV.SwitchOn();
// method of Child Class
myTV.WatchTV();

// Lecture 119: Virtual and Override Keywords
Dog dog = new Dog("Jeff", 20);
Console.WriteLine($"{dog.Name} is {dog.Age} years old");
dog.MakeSound();
dog.Play();
dog.Eat();

// Lecture 124: Interfaces Intro
//// Interfaces are used for communication between 2 similar or Non similar Classes which do not care about
//// the type of Class implementing the Interface.

Ticket t1 = new Ticket(10);
Ticket t2 = new Ticket(10);
Console.WriteLine(t2.Equals(t1)); // True

// Lecture 125: Creating and Using Interfaces

// creating 2 Objects of type Chair
Chair officeChair = new Chair("Brown", "Plastic");
Chair gamingChair = new Chair("Red", "Wood");

// creating a new Object of type car
Car damagedCar = new Car(80f, "Blue");

// add the 2 chairs to the IDestroyable list of the car so that when we destroy the car,
// the destroyable objects that are near the car will get destroyed as well
damagedCar.DestroyablesNearby.Add(officeChair);
damagedCar.DestroyablesNearby.Add(gamingChair);

// destroy the car
damagedCar.Destroy();
// OUTPUT:
//Playing destruction sound CarExplosionSound.mp3
//Create fire
//The Brown chair was destroyed
//Playing destruction sound ChairDestructionSound.mp3
//Spawning chair parts
//The Red chair was destroyed
//Playing destruction sound ChairDestructionSound.mp3
//Spawning chair parts

//// Lecture 126: IEnumerator and IEnumerable
//// 1. IEnumerable <T> for Generic Collections
//// 2. IEnumerable for NON Generic Collections
//// IEnumerable Interface is the Base Interface for many Collections in C# and it's job is to provide a way to ITERATE through a Collection.
//// So the IEnumerable Interface is simple English, when the Collection Class implements the IEnumerable Interface, it becomes countable
//// and we can count each Element in it individually, for e.g. with foreach Loop

//// IEnumerable<T> contains a single method that I must implement when implementing this Interface;
//// GetEnumerator(), which returns an IEnumerator<T> Object.
//// The returned IEnumerator<T> provides the ability to iterate through the Collection
//// by exposing a Current property that points at the Object we are currently at in the Collection

//// WHEN IT IS RECOMMENDED to use the IEnumerable Interface:
//// - My collection represents a massive Database Table,
//// I don't want to copy the entire thing into memory and cause performance issues in your application.
//// WHEN IT IS NOT RECOMMENDED to use the IEnumerable Interface:
//// I need the results right away and are possibly mutating / editing the Objects later on.
//// In this case, it is better to use an Array or a List.

DogShelter shelter = new DogShelter(); // it contains the List of Dogs

foreach (DogForIEnumerable dogz in shelter)
{
    if(!dogz.IsNaughtyDog)
    {
        dogz.GiveTreat(2);
    }
    else
    {
        dogz.GiveTreat(1);
    }
}

//// Lecture 127: IEnumerable Example 1
//// List Types that we usually use, such as List, Queue, Array, all of those are implementing the IEnumerable Interface

// This Method will return an IEnumerable type of Integer
static IEnumerable<int> GetCollection(int option)
{
    // Option 1 - GetCollection returns a List
    // Option 2 - GetCollection returns a Queue
    // Other Option - GetCollection returns an Array of Integers

    // create a List of numbers (Integers) and initialize it
    List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

    Queue<int> numbersQueue = new Queue<int>();
    // add values to the queue
    numbersQueue.Enqueue(6);
    numbersQueue.Enqueue(7);
    numbersQueue.Enqueue(8);
    numbersQueue.Enqueue(9);
    numbersQueue.Enqueue(10);

    // if it's Option 1
    if (option == 1)
    {
        // return the List of type List<int>
        return numbersList;
        // if it's the Option 2
    }
    else if (option == 2)
    {
        // return the Queue of type<int>
        return numbersQueue;
        // otherwise
    }
    else
    {
        // return an Array of numbers initialized with some Numbers
        return new int[] { 11, 12, 13, 14, 15 };
    }
}

// OPTION 1
// creating a Generic IEnumerable variable that takes any Collection of type Int
// I will use this Variable to store the Collections that will get returned by the GetCollection()
IEnumerable<int> unknownCollection;
unknownCollection = GetCollection(1); // 1 - now it holds a List

// OUTPUT:
Console.WriteLine("This was a List<int>"); // This was a List<int> 1 2 3 4 5

// foreach Number in the Collection I got back from GetCollection(1);
foreach (int num in unknownCollection) // so I'm using this in order to get All the Numbers that are in unknownCollection
{
    Console.Write(num + " ");
}

// OPTION 2
// new line
Console.WriteLine("");
// call GetCollection() with Option 2, which will return a Queue<int> but I will store it in the Base Type of Generic Collections
unknownCollection = GetCollection(2); // 2 - now it hold a Queue

// OUTPUT:
Console.WriteLine("This was a Queue<int>"); // This was a Queue<int> 6 7 8 9 10
// for each Number in the Collection I got back from GetCollection(2)
foreach (int num in unknownCollection)
{
    Console.Write(num + " ");
}

// OTHER OPTION
// new line 
Console.WriteLine("");
// call GetCollection() with Option 5 which will return an Array int[] but I will store it in the Base Type of Generics Collection
unknownCollection = GetCollection(5);

// OUTPUT:
Console.WriteLine("This was an Array of Int"); // This was an Array of Int 11 12 13 14 15
// for each Number in the Collection I got back from GetCollection(5);
foreach (int num in unknownCollection)
{
    Console.Write(num + " ");
}

//// Lecture 128: IEnumerable Example 2
//// Passing an IEnumerable to a Method as a Parameter

static void CollectionSum(IEnumerable<int> anyCollection)
{
    // sum Variable to store the sum of the numbers in Any Type of Collection "anyCollection"
    int sum = 0;
    // for each Number in the Collection passed to this Method
    foreach (int num in anyCollection)
    {
        // add the "num" Value to "sum" that are inside of that Collection
        sum += num;
    }
    // print the Sum
    Console.WriteLine("Sum is {0}", sum);
}

// I can now pass Array, List or Queue because they all work with IEnumerable

// A List of type List<int> initialized with some Number
List<int> numbersList = new List<int>() { 8, 6, 2 };
// An Array of type int[] initialized with some Numbers
int[] numberArray = new int[] { 1, 7, 1, 3 };
// new line
Console.WriteLine(" ");

// call CollectionSum() and pass the List to it
CollectionSum(numbersList); // Sum is 16

// call CollectionSum() and pass the Array to it
CollectionSum(numberArray); // Sum is 12

// call CollectionSum() and pass the Queue to it
Queue<int> numbersQueueTwo = new Queue<int>();
// add values to the queue
numbersQueueTwo.Enqueue(6);
numbersQueueTwo.Enqueue(7);
numbersQueueTwo.Enqueue(8);
numbersQueueTwo.Enqueue(9);
numbersQueueTwo.Enqueue(10);

CollectionSum(numbersQueueTwo); // Sum is 40