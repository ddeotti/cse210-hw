public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"===== Welcome to the {_name} activity =====");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"End of {_name} activity.");
        Console.WriteLine($"I hope you have enjoyed the {_name} activity.");
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b");
        }
        Console.WriteLine("Go!");
    }

    protected void UserInputTime()
    {
        Console.WriteLine();
        Console.Write("How long would you like for your session? ");
        Duration = int.Parse(Console.ReadLine());
    }

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }
}