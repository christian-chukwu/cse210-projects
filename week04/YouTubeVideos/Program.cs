using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create first video and add comments

        Video video1 = new Video("Learning C#", "Christian", 300);
        video1.AddComment(new Comment("John", "Great tutorial!"));
        video1.AddComment(new Comment("Mike", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Bissa", "I learned a lot."));
        videos.Add(video1);

        // Create second video and add comments

        Video video2 = new Video("Cooking Jollof Rice", "Olivia", 450);
        video2.AddComment(new Comment("Chima", "Looks delicious!"));
        video2.AddComment(new Comment("Sophia", "Can't wait to try this recipe."));
        video2.AddComment(new Comment("Donatus", "Best recipe so far."));
        videos.Add(video2);

        // Create third video and add comments

        Video video3 = new Video("C# Design Patterns", "Shantel", 600);
        video3.AddComment(new Comment("Ebuka", "Design patterns are so useful."));
        video3.AddComment(new Comment("Joy", "Thanks for the good examples."));
        video3.AddComment(new Comment("Chisom", "I would love to see more videos like this."));
        videos.Add(video3);

        // Display all videos and their comments
        foreach (var video in videos)
        {
            video.Display();
        }
    }
}


