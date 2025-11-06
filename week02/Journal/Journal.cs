//This class will hold and manage all entries (Including saving and loading them)
public class Journal()
{
    //The attribute is a list which will include the entries (from the Entry class)
    public List<Entry> _entries = new List<Entry>();


    //Methods which will manage our entries
public void AddEntry(Entry entry)   //Add entry to the list
{
    _entries.Add(entry);
}

public void DisplayAll()   //Displaying the saved entries in the list  with the entry class format of the display method
{
    foreach (Entry entry in _entries)
    {
        entry.Display();
    }
}

public void SaveToFile(string filename)  //Saving to the text file
{
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        foreach (Entry entry in _entries)
        {
            // saving while separating values by |
            outputFile.WriteLine($"{entry._date}|{entry._PromptText}|{entry._entryText}");
        }
    }
}

public void LoadFromFile(string filename) //Loading from the saved file
{
    _entries.Clear();
    string[] lines = File.ReadAllLines(filename);
    foreach (string line in lines)
    {
        string[] parts = line.Split('|');  //value are split by the |
        Entry e = new Entry();
        e._date = parts[0];    //The order basing on the index
        e._PromptText = parts[1]; 
        e._entryText = parts[2];
        _entries.Add(e);
    }
}

}