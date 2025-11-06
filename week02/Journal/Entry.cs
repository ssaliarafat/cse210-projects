//An Entry includes the prompt, the user response and its date.
public class Entry
{
    //Attributes of the Entry class for showing prompts, user response, and date
    public string _PromptText;  //The prompts
    public string _entryText;   //The response from user
    public string _date;    //The date at which the entry text is written (response)


    //The Method to be used to display our entry
    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_PromptText}");
        Console.WriteLine($"Response: {_entryText}\n");
    }


}
