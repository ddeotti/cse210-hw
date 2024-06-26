using System;

class Program
{
    static void Main(string[] args)
    {
       
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int myGuess = -1;

        // We could also use a do-while loop here...
        while (myGuess != magicNumber)
        {
            Console.Write("What is your Guess? ");
            myGuess = int.Parse(Console.ReadLine());

            if (magicNumber > myGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < myGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You Guessed it!");
            }

        }                    
    }
}