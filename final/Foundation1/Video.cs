public class Video
{
    public string _title;
    public string _author;
    public int _length; // length in seconds
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumbrOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}