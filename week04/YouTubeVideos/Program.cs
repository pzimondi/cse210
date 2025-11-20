using System;
using System.Collections.Generic;

// Class for comments
class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

// Class for videos
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
         // Create videos
        Video video1 = new Video("C# Basics", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Loved it!"));

        Video video2 = new Video("Advanced C#", "Jane Smith", 600);
        video2.AddComment(new Comment("Dave", "I learned a lot."));
        video2.AddComment(new Comment("Eve", "Please make more videos."));
        video2.AddComment(new Comment("Frank", "Awesome content!"));

        Video video3 = new Video("YouTube API Basics", "Michael Scott", 450);
        video3.AddComment(new Comment("Grace", "This is exactly what I needed."));
        video3.AddComment(new Comment("Hank", "Excellent explanation."));
        video3.AddComment(new Comment("Ivy", "Thanks for sharing."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video info and comments
        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Author}");
            Console.WriteLine($"Length: {v.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {v.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment c in v.Comments)
            {
                Console.WriteLine($"- {c.CommenterName}: {c.Text}");
            }
            Console.WriteLine();
        }
    }
}