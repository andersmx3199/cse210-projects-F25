using System.Security.Cryptography.X509Certificates;

class Comment
{
    // Attributes for the Comment Class
    public string _username = "";
    public string _comment = "";

    // Behaviors for the Comment Class
    // Set and Get Username
    public string GetUsername()
    {
        return _username;
    }
    public void SetUsername(string username)
    {
        _username = username;
    }

    // Set and Get Comment
    public string GetComment()
    {
        return _comment;
    }
    public void SetComment(string comment)
    {
        _comment = comment;
    }

    // Comment Constructor
    public Comment(string username, string comment) 
    {
        _username = username;
        _comment = comment;
    }
}