using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    // ImagePost Class derives from Post and adds a Property (ImageURL) and two Constructors
    class ImagePost : Post // Inheriting from Post Class
    {
        // Properties
        public string ImageURL { get; set; }

        // Constructor 1
        public ImagePost() 
        {
        }
        // Constructor 2
        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            // Inherited Properties from Post Class
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = isPublic;

            // Properties of this Class ImagePost
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SendByUserName);
        }
    }
}

// The Default Constructor in the Base Class "Post" is called IMPLICITLY, because I don't call it EXPLICITLY in 2 ImagePost Constructors 