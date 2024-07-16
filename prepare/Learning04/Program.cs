using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("John Peter","Fractions");
        Console.WriteLine($"{assignment1.GetSummary()}");

        MathAssignment assignment2 = new MathAssignment("Valdecir Carlyle","Logarithm","4.3","7-20");
        Console.WriteLine($"{assignment2.GetSummary()}");
        Console.WriteLine($"{assignment2.GetHomeWorkList()}");


        WritingAssignment assignment3 = new WritingAssignment("Ronaldo Neves ", "Brazil History", "The New Atlas of Brazilian History");
        Console.WriteLine($"{assignment3.GetSummary()}");
        Console.WriteLine($"{assignment3.GetWritingInformation()}");
    }
}