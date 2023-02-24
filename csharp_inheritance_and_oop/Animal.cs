using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    class Animal
    {
        // name property
        public string Name { get; set; }
        // age property
        public int Age { get; set; }
        // is hungry boolean to check whether the Animal is hungry
        public bool IsHungry { get; set; }

        // Constructor
        public Animal(string name, int age)
        {
            Name = name; 
            Age = age;
            // In this example, all animals are hungry by default
            IsHungry = true;
        }

        //an empty Virtual Method "MakeSound" for other Classes to OVERRIDE
        // virtual - so it can be Overridden by Classes that Inherit from Animal Class
        public virtual void MakeSound() 
        {
             
        }

        // Virtual Method called Eat which Sub-Classes can Override
        public virtual void Eat()
        // check if animal is hungry
        {
            if (IsHungry) 
            {
                // if yes, then print the name of the animal + "is eating"
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                // otherwise print that the animal is not hungry
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        // Virtual method Play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
  