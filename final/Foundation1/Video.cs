class Video : Media
{
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        Comment comment = new Comment { CommenterName = commenterName, Text = text };
        Comments.Add(comment);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Length: " + Length + " seconds");
        Console.WriteLine("Number of comments: " + Comments.Count);
        Console.WriteLine("Comments:");
        foreach (Comment comment in Comments)
        {
            Console.WriteLine(comment.CommenterName + ": " + comment.Text);
        }
        Console.WriteLine();
    }
}