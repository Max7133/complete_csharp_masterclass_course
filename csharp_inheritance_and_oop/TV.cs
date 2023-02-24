using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    class TV : ElectricalDevice
    {

        // constructor
        public TV(bool isOn, string brand) : base(isOn, brand)
        {
        }

        // switch on the TV

        public void WatchTV() {

            // first check if the TV is on
            if (IsOn)
            {
                // watch the TV
                Console.WriteLine("Watching TV!");
            }
            else
            {
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
