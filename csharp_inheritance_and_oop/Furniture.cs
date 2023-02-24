using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    // Base Class for furniture
    class Furniture
    {
        public string Color { get; set; }
        // material of the furniture
        public string Material { get; set; }
        // default constructor
        public Furniture() {
            Color = "White";
            Material = "Wood";
        }

        // simple Constructor
        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }
} 
