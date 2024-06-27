// Code used to play around with classes and objects
public class Person 
{
    // in C# we start member variables with an underscore
    public string _givenName = "";
    public string _familyName = "";

    // This is a constructor method
    public Person() 
    {

    }

    // Method to displays the person's full name as used in eastern countries

    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }

    public void ShowWesternName() {
        Console.WriteLine($"{_givenName} {_familyName}");
    }
}
 