using System.Collections.Generic;

public class Video
{
    // Stores the title of the video
    public string Title { get; set; }

    // Stores the name of the video author
    public string Author { get; set; }

    // Stores the length of the video in seconds
    public int LengthSeconds { get; set; }

    // Stores a list of comments belonging to the video
    public List<Comment> Comments { get; set; }

    // Constructor to create a video
    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;

        // Creates an empty list to store comments
        Comments = new List<Comment>();
    }

    // Returns the number of comments on the video
    public int GetCommentCount()
    {
        return Comments.Count;
    }
}