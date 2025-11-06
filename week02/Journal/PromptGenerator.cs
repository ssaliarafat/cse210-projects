//This class will give us random prompts
public class PromptGenerator
{
    //The List to contain the Prompts which will be displayed to the user
    public List<string> _prompts = new List<string>()
 {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
 };


    //The Methods to generate Random Prompts from our saved prompts
    public string GetRandomPrompt()
  {
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    return _prompts[index];
  }

}