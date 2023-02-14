using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    // this class is a blueprint for a Datatype
    internal class Human
    {
        // Members: for e.g. variables, methods...
        // member Variable
        private string firstName; // without public it will be protected
        private string lastName;
        private int age;
        private string eyeColor;

        // constructor (default constructor)
        public Human()
        {
            Console.WriteLine("Default constructor called. Object created");
        }

        // constructor (parameterized constructor)
        public Human(string firstName, string lastName, int age, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }

        // member Method (because it's part og my Human Class, which is a blueprint)
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1} I'm {2} years old, and my eye color is {3}", firstName, lastName, age, eyeColor);
        }
    }
}
