class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    public List<Comment> Comments { get; } = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(string commenterName, string text)
    {
        Comment comment = new Comment(commenterName, text);
        Comments.Add(comment);
    }
      public int GetNumComments()
    {
        return Comments.Count;
    }
}