public class PromptGenerator
{
    List<string> _prompts = new List<string>
    {
        "What was the best part of your day? ",
        "What was the strongest emotion I felt today? ",
        "What I'm greatful for today? ",
        "What I learned today? ",
        "What thought kept runing to my mind today? ",
        "What I can do tomorrow to be better than today? "
    };
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}