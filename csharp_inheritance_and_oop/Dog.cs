using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    class Dog : Animal
    {
        // bool property to check if the dog is Happy
        public bool IsHappy { get; set; }
        // Constructor where I pass the "name" and "age" to the Base Constructor
        public Dog(string name, int age) : base(name, age) 
        {
            // all dogs are happy
            IsHappy = true;
        }

        // simple Override of the Virtual Method Eat
        public override void Eat()
        {
            // to call the Eat() from the base class Animal, I use the keyword "base"
            base.Eat();
        }

        // override of the Virtual Method MakeSound
        public override void MakeSound()
        {
            // since every animal will make a totally different sound
            // each Animal will implement their own version of MakeSound
            Console.WriteLine("Wuuuf!.");
        }

        // Override of the Virtual Play()
        public override void Play()
        {
            // check if the dog is happy if yes call the Play() from the Base Class
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
 