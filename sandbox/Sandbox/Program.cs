using System;

class Program
{
    static void Main(string[] args)
    {
        // trying to use a class file

        Person persona = new Person();
        persona._givenName = "Emma";
        persona._familyName = "Smith";
        persona.ShowWesternName();

        Person personb = new Person();
        personb._givenName = "Joseph";
        personb._familyName = "Smith";
        personb.ShowWesternName();



        // Code of the blind example
        // creates a blind for the kitchen
        Console.WriteLine("\nExample for the blind");
        Blind kitchen = new Blind();
        Blind livingRoom = new Blind();

        kitchen._width = 60;
        kitchen._height = 48;
        kitchen._color = "white";

        livingRoom._width = 180;
        livingRoom._height = 48;
        livingRoom._color = "grey";

        double materialAmount = kitchen.GetArea();
        Console.WriteLine("Material amount for kitchen blind:  {0}", materialAmount);

        double materialAmount2 = livingRoom.GetArea();
        Console.WriteLine("Material amount for living room blind:  {0}", materialAmount2);


        // Examples with objects inside objects
        House johnsonHome = new House();


        johnsonHome._owner = "Johnson Family";
        johnsonHome._kitchen._width = 60;

    HouseListExample johnsonHomeList = new HouseListExample();
    johnsonHomeList._blinds.Add(cozinha);
    }
}