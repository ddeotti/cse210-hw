public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // Activity constructor
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine($"{_description}");
        Thread.Sleep(500);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"End of {_name} activity.");
        Console.WriteLine($"I hope you have enjoyed the {_name} activity.");
        Thread.Sleep(1000);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i <= seconds ; i++)
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

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds;i >= 0;i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int UserInputTime(int seconds)
    {
        
    }
}