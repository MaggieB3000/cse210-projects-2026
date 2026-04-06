using System.Globalization;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int length)
    {
        _length = length;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
    public void SetComments(List<Comment> comments)
    {
        _comments = comments;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"\n\n{_title}\nBy: {_author}\nLength (in seconds): {_length}\nNumber of comments: {_comments.Count}");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}