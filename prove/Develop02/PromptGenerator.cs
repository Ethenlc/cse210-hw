public class PromptGenerator
{
    private Random random = new Random();
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        string[] prompts = {
            "If I had one thing I could do over today, what would it be?",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?"
        };

        int randomIndex = random.Next(prompts.Length);
        return prompts[randomIndex];
    }
}