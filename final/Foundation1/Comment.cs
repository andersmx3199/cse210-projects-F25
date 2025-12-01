using System.Security.Cryptography.X509Certificates;

class Comment
{
    // Attributes for the Comment Class
    public string _username = "";
    public string _comment = "";

    public string GetUsername()
    {
        return _username;
    }
    public void SetUsername(string username)
    {
        _username = username;
    }

    public string GetComment()
    {
        return _comment;
    }
    public void SetComment(string comment)
    {
        _comment = comment;
    }

    public Comment(string username, string comment) 
    {
        _username = username;
        _comment = comment;
    }
}