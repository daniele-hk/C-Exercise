using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Inheritance_Demo
{
    internal class Videopost : Post
    {
        // Fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;

        // Properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public Videopost() { }

        public Videopost(string title, string sendByUsername, string videoURL, int length, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.VideoURL = videoURL;
            this.Length = length;
            this.IsPublic = isPublic;
        }
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.VideoURL} - {this.Length}s - {this.SendByUsername}");
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Video started");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if(currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine($"Video at {currentDuration}s");
                // To clear memory
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Stopped at {currentDuration}s");
                currentDuration = 0;
                // To stop the timer
                timer.Dispose();
            }
            
        }
    }
}
