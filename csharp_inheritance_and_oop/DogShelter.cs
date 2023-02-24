using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    // This Class contains a Generic Collection of type Dog
    // Objects of this Class can't be used inside a foreach Loop because it lack an implementation of the IEnumerable Interface
    class DogShelter : IEnumerable<DogForIEnumerable> // in order to make it iterable with foreach Loop
    {
        // list of type List<DogForIEnumerable>
        public List<DogForIEnumerable> dogs;
        // this Constructor will initialize the dogs list with some values
        public DogShelter()
        {
            // initialize the dogs list using the collection-initializer
            dogs = new List<DogForIEnumerable>()
            {
                new DogForIEnumerable("Casper", false),
                new DogForIEnumerable("Sif", true),
                new DogForIEnumerable("Oreo", false),
                new DogForIEnumerable("Pixel", false),
            };
        }

        // Generic
        IEnumerator<DogForIEnumerable> IEnumerable<DogForIEnumerable>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        // Non Generic
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
