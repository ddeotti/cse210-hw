public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    public void Start()
    {
        Console.Clear();
        DisplayStartingMessage();
        UserInputTime();
        int totalDuration = Duration;
        Console.Clear();
        Console.WriteLine("Get ready!");
        ShowSpinner(5);
        Console.WriteLine("Start...");
        Console.WriteLine();
        while (totalDuration > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            totalDuration -= 3;

            if (totalDuration <= 0) break;

            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            totalDuration -= 3;
        }
        DisplayEndingMessage();
        ShowSpinner(5);
    }
}