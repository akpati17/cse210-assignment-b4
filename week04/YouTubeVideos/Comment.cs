public class Comment
{
    // The name of the person who made the comment
    public string CommenterName { get; set; }

    // The text of the comment
    public string Text { get; set; }

    // Constructor
    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}