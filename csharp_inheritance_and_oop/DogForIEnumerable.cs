using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    class DogForIEnumerable
    {
        // the name of the Dog
        public string Name { get; set; }
        // is this a naughty dog
        public bool IsNaughtyDog { get; set; }
        // simple Constructor
        public DogForIEnumerable(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }
        // This Method will print how many treats the dog received
        public void GiveTreat(int numberOfTreats)
        {
            // print a message containing the number of treats and the name of the dog
            Console.WriteLine("Dog: {0} said wuoff {1} times!.", Name, numberOfTreats);
        }// OUTPUT
         // Dog: Casper said wuoff 2 times!.
         // Dog: Sif said wuoff 1 times!.
         // Dog: Oreo said wuoff 2 times!.
         // Dog: Pixel said wuoff 2 times!.
    }
}
