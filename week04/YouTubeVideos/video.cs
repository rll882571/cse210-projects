using System.Collections.Generic; // Precisamos disso para usar List<>

public class Video
{
    // Variáveis para guardar as informações do vídeo
    public string _title;
    public string _author;
    public int _lengthInSeconds;

    
    private List<Comment> _comments;

    
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

       public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

       public List<Comment> GetComments()
    {
        return _comments;
    }
}