public class Comment     // Commenter name and text content attributes
{
    private string _name;
    private string _text;

    public Comment(string name, string text)  // The constructor
    {
        _name = name;
        _text = text;
    }

    public void Display()  // Display method
    {
        Console.WriteLine($"{_name}: {_text}");
    }
}
