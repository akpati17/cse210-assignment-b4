using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthSeconds { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}

public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics in 10 Minutes", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "Great explanation of C# basics!"));
        video1.AddComment(new Comment("Bob", "Super helpful, thanks for uploading."));
        video1.AddComment(new Comment("Charlie", "Can you cover OOP principles next?"));
        videos.Add(video1);

        Video video2 = new Video("Top 5 Tech Gadgets of 2026", "Tech Reviews", 840);
        video2.AddComment(new Comment("Dave", "I really want that new smart watch!"));
        video2.AddComment(new Comment("Eva", "The battery life on #3 looks amazing."));
        video2.AddComment(new Comment("Frank", "Nice summary, loved the editing."));
        videos.Add(video2);

        Video video3 = new Video("How to Cook Authentic Carbonara", "Chef Secrets", 450);
        video3.AddComment(new Comment("Grace", "No cream! Finally an authentic recipe."));
        video3.AddComment(new Comment("Heidi", "Tried this today and it came out perfect."));
        video3.AddComment(new Comment("Ivan", "Guanciale is hard to find here, but bacon worked well."));
        video3.AddComment(new Comment("Judy", "Subscribed! Fantastic recipe."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"  - {comment.Name}: \"{comment.Text}\"");
            }

            Console.WriteLine();
        }
    }
}