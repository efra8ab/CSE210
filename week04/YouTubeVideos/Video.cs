using System.Reflection;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment

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
        
    }
}