using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class Box
    {
        // member variables
        private int length = 3; // default value is 3
        private int height;
        //public int width; // I don't wan't to set the "width" as a member variable, I want to have it as a property
        private int volume;

        // short version Property
        public int Width { get; set; }

        // long version Property
        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }


        // long version Property
        public int Height // if I want to get access or change the "height member variable", I need to do it with the "property height"
        { 
            get
            { 
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value; // the value that I set will be set to the "height"
                }
            }
        }

        public Box(int length, int height, int width) 
        {
        this.length = length;
            this.height = height;
            Width= width;
        }    

        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length; // changes the length of this Object (of the Object that is created of the class box)
        }

        public int GetLength()
        {
            return this.length; // member variable
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", 
                length, height, Width, volume = length*height*Width);
        }
    }
}

//// This is the same as 

// public int Width { get; set }

//// This

//public int Width
//{
//    get
//    {
//        return this.width;
//    }
//    set
//    {
//        this.width = value;
//    }
//}