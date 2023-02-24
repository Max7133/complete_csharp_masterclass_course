using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    // subclass chair that extends Furniture
    class Chair : Furniture, IDestroyable
    {
        // implementing the Interface's Property
        public string DestructionSound { get; set; }

        // simple constructor
        public Chair(string color, string matetial)
        {
            this.Color = color;
            this.Material = matetial;
            // initializing the Interface's property with a value in the Constructor
            DestructionSound = "ChairDestructionSound.mp3";
        }

        // implementing the Interface's Method
        public void Destroy() 
        {
            // when a chair gets destroyed we should play the destruction sound
            // and spawn the destroyed chair parts
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }
    }
}
