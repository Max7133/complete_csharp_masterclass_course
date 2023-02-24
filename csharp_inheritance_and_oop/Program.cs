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