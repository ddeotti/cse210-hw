public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        UserInputTime();
        Console.Clear();
        Console.WriteLine("Get ready!");
        ShowSpinner(5);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} --- ");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemCount++;
        }
        _count = itemCount;
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
        ShowSpinner(5);
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}
