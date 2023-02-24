using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    // subclass Car that extends Vehicle
    class Car : Vehicle, IDestroyable
    {
        // implementing the Interface's Property
        public string DestructionSound { get; set; }

        // creating a new Property to store the destroyable Objects nearby
        // when a car gets destroyed it should also destroy the nearby Object
        // this list is of type IDestroyable which means it can store any Object
        // that implements this Interface and we can only access the Properties and Methods in this Interface
        public List<IDestroyable> DestroyablesNearby;

        // simple constructor
        public Car(float speed, string color) : base(speed, color)
        {
            // I used base() instead
            // this.Speed = speed;
            // this.Color = color;

            // initialize the Interface's property with a value in the Constructor
            DestructionSound = "CarExplosionSound.mp3";
            // initialize the list of destroyable objects;
            DestroyablesNearby = new List<IDestroyable>();
        }

        // implementing the Interface's Method
        public void Destroy()
        {
            // when a car gets destroyed we should play the Destruction Sound
            // and create fire effect
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");
            // go through each destroyable Object nearby and call it's destroy Method
            foreach (IDestroyable destroyable in DestroyablesNearby) 
            {
                destroyable.Destroy();
            }
        }
    }
}
  