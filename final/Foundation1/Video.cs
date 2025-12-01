using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Video 
{

    // Attributes for the Video Class

    // Title containing the title of the video
    public string _title = "";
    // Author containing the author of the video
    public string _author = "";
    // Length in seconds of the video
    public int _length = 0;

    public List<Comment> comments;


    // Behaviors of the Video Class
    
    public Video()
    {
        comments = new List<Comment>();
    }

    // Get and Set YouTube Video Title
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    // Get and Set YouTube Video Author
    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }

    // Get and Set YouTube Video Length (s)
    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int length)
    {
        _length = length;
    }


    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

    // Display Video Details
    public void DisplayVideo()
    {
        Console.WriteLine($"YouTube Video: {_title}");
        Console.WriteLine($"YouTube Author: {_author}");
        Console.WriteLine($"Duration: {_length}s");
        Console.WriteLine("Comments:");
        foreach (Comment comment in comments){
            Console.WriteLine($"{comment._username} says {comment._comment}");
        }
        Console.WriteLine("");
    }

}