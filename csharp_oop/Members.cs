using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // member - property - exposes jobTitle safely - properties start with a capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            } else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}, I'm {2} years old", memberName, jobTitle, age);
            }
        }
        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Igor";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor
        // ~ + name of the Class 
        // Whenever the Object is closed, deleted or runs out of scope, that's when this finalizer here is executed
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Destruction of Members Object");
        }
    }

    // If the finalizer is empty, I should not use it. Only if I have something useful to do in there, then I should use the finalizer,
    // Otherwise it just uses up performance, because when the Class contains the finalizer, an Entry is created in the "finalizing queue" and when if analyzer is then called,
    // the garbage collector is invoked to process that queue.
}
