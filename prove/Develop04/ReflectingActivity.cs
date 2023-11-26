public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(int duration) : base("Reflecting Activity", "Reflecting Description")
    {
        _prompts.Add("Reflect on your happiest moment.");
        _prompts.Add("Think of a time when you did something really difficult");
        _prompts.Add("Ponder on a time your testimony grew.");

        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("Are you able to do this moment over again?");
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(0, _prompts.Count);

        string randomPrompt = _prompts[randomIndex];

        Console.WriteLine(randomPrompt);
    }

        public void GetRandomQuestion()
    {
        Random rand2 = new Random();
        int randomIndex = rand2.Next(0, _questions.Count);

        string randomQuestion = _questions[randomIndex];

        Console.WriteLine(randomQuestion);
    }

        public void DisplayPrompt()
        {
            GetRandomPrompt();
        }

        public void DisplayQuestions()
        {
            GetRandomQuestion();
            ShowSpinner(5);
        }
}