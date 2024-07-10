public class PromptGenerator
{

    List<string> _prompts = new List<string>
    {
        "What is your current mood?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is your current project of passion?",
        "What was the last book you read?",
        "How you feel about the world right now?",
        "How did you deal with difficulties today?",
        "Reflect about the challenges of today,",
        "What did you learn from today's experience?",
        "What bad habits and behaviors are holding you back from reaching your full potential?",
        "How has that impacted who you are today?",
        "What fears or insecurities do you need to overcome today?",
        "What gave you joy and fulfillment today?"
    };
    public string GetRandomPrompt()
    {
        Random randNumber = new Random();
        int index = randNumber.Next(_prompts.Count);
        return _prompts[index];
    }

}