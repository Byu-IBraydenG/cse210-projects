using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very Helpful, Thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));
        videos.Add(video1);

        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 600);
        video2.AddComment(new Comment("Dave", "Awesome content!"));
        video2.AddComment(new Comment("Eve", "Loved the examples"));
        video2.AddComment(new Comment("Frank", "Very detailed explanation"));
        videos.Add(video2);

        Video video3 = new Video("C# Design Patterns", "Robert Brown", 450);
        video3.AddComment(new Comment("Grace", "Clear and concise."));
        video3.AddComment(new Comment("Hank", "Excellent tutorial"));
        video3.AddComment(new Comment("Ivy", "Really useful, thank you!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumbrOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }

            Console.WriteLine(); // blank line between videos
        }
    }
}