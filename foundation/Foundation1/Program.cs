using System;
using System.Collections.Generic;

namespace Foundation1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Video video1 = new Video("Deadpool Dance Tutorial", "Dance Academy", 500);
            Video video2 = new Video("How to have Abs at Home", "Work Out with Amy", 600);
            Video video3 = new Video("The Best Cheesecake Recipe", "New York Chef", 370);

            // Add comments to each video
            video1.AddComment(new Comment("Bryce", "I love Deadpool!"));
            video1.AddComment(new Comment("Marissa", "This tutorial is the best!"));
            video1.AddComment(new Comment("Shannon", "Loved your dance tutorials!"));

            video2.AddComment(new Comment("Crystal", "Thank you for sharing!"));
            video2.AddComment(new Comment("Yan", "I am going to try it at home!"));
            video2.AddComment(new Comment("Samson", "Great Video!"));

            video3.AddComment(new Comment("Rachel", "The best recipe!"));
            video3.AddComment(new Comment("Tiff", "We tried it at home and It turned out great!"));
            video3.AddComment(new Comment("Lisa", "I am so inspired to cook now!"));

            List<Video> videos = new List<Video> { video1, video2, video3 };

            foreach (Video video in videos)
            {
                video.DisplayVideoDetails();
            }
        }
    }
}

