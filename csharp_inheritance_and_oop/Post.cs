using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inheritance_and_oop
{
    class Post
    {
        // Field of the Post, it's Static - so it's available outside of this Post as well,
        // and this Post will be create once the application is started.
        private static int currentPostId;

        // Properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        // Default Constructor.
        // If a derived class does not invoka a base-class Constructor explicitly,
        // the default Constructor is called implicitly.
        public Post() // This Constructor in this Base Class is called IMPLICITLY
        {
            ID = GetNextID();
            Title = "My First Post";
            IsPublic = true;
            SendByUserName = "Max Pas";
        }

        // Another Instance Constructor 3 several Parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = 0;
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = isPublic;
        }

        // This will return the next ID, which means currentPostID will increment itself by 1
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        // Method for changing the Title and if the Post isPublic or NOT
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // Overriding System.Object.ToString()
        // Virtual Method override of the ToString Method that is inherited from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUserName); // 2 - Check out my new shoes! - http://images.com/shoes - by Max Pas
        }
    }
}
