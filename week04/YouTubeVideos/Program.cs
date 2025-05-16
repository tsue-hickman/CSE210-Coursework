using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create first video
        Video video1 = new Video("C# Programming Tutorial for Beginners", "CodeWithMosh", 1800);
        video1.AddComment(new Comment("John Doe", "This was extremely helpful, thanks!"));
        video1.AddComment(new Comment("Jane Smith", "Great explanation of OOP concepts."));
        video1.AddComment(new Comment("Bob Johnson", "I finally understand abstraction now!"));
        videos.Add(video1);

        // Create second video
        Video video2 = new Video("Making Homemade Pizza", "ChefMaster", 720);
        video2.AddComment(new Comment("Pizza Lover", "My pizza turned out amazing using this recipe!"));
        video2.AddComment(new Comment("Cooking Newbie", "The dough instructions were so clear."));
        video2.AddComment(new Comment("Italian Chef", "Almost authentic! Try adding a bit more basil."));
        video2.AddComment(new Comment("Family Cook", "My kids loved helping with this recipe."));
        videos.Add(video2);

        // Create third video
        Video video3 = new Video("Tour of Iceland's Natural Wonders", "TravelTheWorld", 1200);
        video3.AddComment(new Comment("Adventure Seeker", "Adding this to my bucket list!"));
        video3.AddComment(new Comment("Nature Photographer", "The waterfalls look breathtaking."));
        video3.AddComment(new Comment("Iceland Native", "You captured our country beautifully!"));
        videos.Add(video3);

        // Create fourth video
        Video video4 = new Video("Beginner Guitar Lessons - First Chords", "MusicMaster", 900);
        video4.AddComment(new Comment("Guitar Student", "My fingers hurt but I can play a G chord now!"));
        video4.AddComment(new Comment("Music Teacher", "Great explanation of finger positioning."));
        video4.AddComment(new Comment("Rock Fan", "Can't wait to learn some rock songs."));
        videos.Add(video4);

        // Display information for each video
        Console.WriteLine("YouTube Video Tracker\n");

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine("\n-----------------------------------\n");
        }
    }
}