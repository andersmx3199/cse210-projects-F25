class Video 
{

    // Attributes for the Video Class

    // Title containing the title of the video
    public string _title = "";
    // Author containing the author of the video
    public string _author = "";
    // Length in seconds of the video
    public int _length = 0;


    // Behaviors of the Video Class
    
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


}