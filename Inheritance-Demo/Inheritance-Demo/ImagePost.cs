using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }

        // We dont call the base constructor explicity in the follwing constructors, so it's call by default!
        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            // Properties inheritad fromPost
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            // Property inside ImagePost itself
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.ImageURL} - {this.SendByUsername}");
        }
    }
}
