using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    internal class Post
    {
        private static int currentPostId;

        // Properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // In this constructor, for this demo, we will set here the value
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            SendByUsername = "Haki";
            IsPublic = true;
        }
        // We want to add another instance constructor that has different parameter
        public Post(string title, string sendByUsername, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        // To give different ids to different posts
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        // Update post
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // We want to override a method that is implemented by the System.Object namespace
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.SendByUsername}");
        }
    }
}
