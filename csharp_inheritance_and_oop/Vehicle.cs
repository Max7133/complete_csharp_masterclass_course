using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    // base class for vehicles
    class Vehicle
    {
        // speed of the vehicle
        public float Speed { get; set; }
        // color of the vehicle
        public string Color { get; set; }
        // default Constructor
        public Vehicle() 
        {
            Speed = 120f;
            Color = "White";
        }
        // simple constuctor
        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
} 
