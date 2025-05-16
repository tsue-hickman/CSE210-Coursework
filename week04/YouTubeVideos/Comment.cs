public class Comment
{
    // Properties
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    // Constructor
    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}