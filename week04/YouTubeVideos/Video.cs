using System.Reflection;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comments> _comments = new List<Comments>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Video title: {_title}");   
        Console.WriteLine($"Author: {_author}");   
        Console.WriteLine($"Duration in seconds: {_length}");   
        Console.WriteLine($"Number of comments: {NumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comments comment in _comments)
        {
            Console.WriteLine($">> {comment._commentAuthor} -> {comment._text}");
        }   
        Console.WriteLine();
    }
}