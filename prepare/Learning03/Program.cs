using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); 
        Console.WriteLine("constructor: Fraction");
        Fraction fracao1 = new Fraction();
        Console.WriteLine(fracao1.GetFractionString());
        Console.WriteLine(fracao1.GetDecimalValue());


        Console.WriteLine("");
        Console.WriteLine("constructor: Fraction(int wholenumber)");
        Fraction fracao2 = new Fraction(5);
        Console.WriteLine(fracao2.GetFractionString());
        Console.WriteLine(fracao2.GetDecimalValue());


        Console.WriteLine("");
        Console.WriteLine("constructor: Fraction(int top, int bottom)");
        Fraction fracao3= new Fraction(3,4);
        Console.WriteLine(fracao3.GetFractionString());
        Console.WriteLine(fracao3.GetDecimalValue());
    

        Console.WriteLine("");
        Console.WriteLine("constructor: Fraction(int top, int bottom) with 1/3 division");
        Fraction fracao4 = new Fraction(1,3);
        Console.WriteLine(fracao4.GetFractionString());
        Console.WriteLine(fracao4.GetDecimalValue());
    }
}