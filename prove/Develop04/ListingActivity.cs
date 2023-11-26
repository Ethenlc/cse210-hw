public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts;

    public ListingActivity(int _duration) : base("Listing Activity", "Listing Desc")
    {
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("When were you positively impacted by someone this week?");
        _prompts.Add("Who can you serve this week?");
        _prompts.Add("Who means the most to you?");
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(0, _prompts.Count);

        string randomPrompt = _prompts[randomIndex];

        Console.WriteLine(randomPrompt);
    }

    public int GetListFromUser(TimeSpan duration)
    {
                DateTime startTime = DateTime.Now;
        DateTime endTime = startTime + duration;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _count += 1;
        }
        return _count;
    }


}