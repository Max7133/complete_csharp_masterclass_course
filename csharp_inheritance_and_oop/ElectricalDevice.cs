using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    class ElectricalDevice
    {
        // boolean to determine the state of the Electrical Device
        public bool IsOn { get; set; }

        // string for the brand name of the Electrical Device
        public string Brand { get; set; }

        // constructor
        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        // switch on the Electrical Device
        public void SwitchOn()
        {
            IsOn = true;
        }
        // switch off the Electrical Device
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
