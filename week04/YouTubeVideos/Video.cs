public class Video     //declaring class attributes and the list for storing comments from our comment class
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments = new List<Comment>(); 

    public Video(string title, string author, int length)  //constructor for the attributes
    {
        _title = title;
        _author = author;
        _lengthSeconds = length;
    }

    public void AddComment(Comment comment) // Method for adding comments to the list
    {
        _comments.Add(comment);
    }

    public int GetCommentCount() // Method for Counting the number of comments
    {
        return _comments.Count;
    }

    public void Display()     // Display method
    {
        Console.WriteLine("\n");  // new line before printing
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds");
        Console.WriteLine($"Comments: {GetCommentCount()}");

        Console.WriteLine("----- Comment Section -----"); 
        foreach (Comment c in _comments)        // Iterating through the comment list
        {
            c.Display();
        }
    }
}
