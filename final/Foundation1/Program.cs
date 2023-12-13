using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("Test Vid 1",  "Test Author 1", 120),
            new Video("Test Vid 2",  "Test Author 2", 150),
            new Video("Test Vid 3",  "Test Author 3", 90), 
        };

        foreach (var video in videos)
        {
            video.AddComment(new Comment("Viewer Test 1", "First comment!"));
            video.AddComment(new Comment("Viewer Test 2", "I loved this"));
            video.AddComment(new Comment("Viewer Test 3", "Great job"));
        };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine();
            Console.WriteLine("Comments:");
            foreach (var comment in video._comments)
            {
                Console.WriteLine($"{comment._commenterName}: {comment._commenterText}");
            }
            Console.WriteLine("---------------------------------");
        }
    }
}