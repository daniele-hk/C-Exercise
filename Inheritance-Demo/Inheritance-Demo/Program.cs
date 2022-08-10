using System;

namespace Inheritance_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", "Haki", true);
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("BENU Limited Edition", "Haki", "http://here-the-image.com", true);
            Console.WriteLine(imagePost1.ToString());

            Videopost videopost1 = new Videopost("My new BENU in action!", "Haki", "http://here-my-video.com", 120, true);
            Console.WriteLine(videopost1.ToString());
            videopost1.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videopost1.Stop();
            
        }
    }
}
