using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    // will have a Property to store the audio file that will be run once we execute the destruction sound
    interface IDestroyable
    {
        // property to store the audio file of the destruction sound
        string DestructionSound { get; set; }
        // method to destroy an Object
        void Destroy();
    }
}
