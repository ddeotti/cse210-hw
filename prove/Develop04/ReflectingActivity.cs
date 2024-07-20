public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        UserInputTime();
        Console.Clear();
        Console.WriteLine("Get ready!");
        ShowSpinner(5);
        string prompt = GetRandomPrompt();
        Console.WriteLine($"-----{prompt}-----");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        Random random = new Random();
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question}");
            ShowSpinner(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
        ShowSpinner(5);
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }
}