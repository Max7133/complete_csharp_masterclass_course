using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand):base(isOn, brand)
        {
        }

        // method to listen to the radio

        public void ListenRadio()
        {
            if (IsOn)
            {
                // listen to radio
                Console.WriteLine("Listening to the Radio");
            }
            else
            {
                // print errot message
                Console.WriteLine("Radio is switched off, switch it on first");
            } 
                
        }
    }
}
