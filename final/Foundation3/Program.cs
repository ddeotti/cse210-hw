using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Address address1 = new Address("123 Main St", "New York", "New York", "USA");
        Address address2 = new Address("456 Elm St", "Some town", "Idaho", "USA");
        Address address3 = new Address("789 Oak St", "Some town 2", "New York", "USA");

        Lecture lecture = new Lecture("Vector analysis", "An engineering lecture", "2024-08-15", "14:00", address1, "Dr. Samsen", "40");
        Reception reception = new Reception("Startup meeting expo", "An exhibition and networking event", "2024-09-19", "18:00", address2, "rsvp@expomeeting.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Birthday of uncle John", "A happy time for our family", "2024-11-30", "15:00", address3, "Sunny");

        Console.WriteLine("\n ##### Lecture example #####\n");
        Console.WriteLine(lecture.StandardDetails() + "\n" + lecture.FullDetails() + "\n" + lecture.ShortDetails() + "\n");
        Console.WriteLine("\n ##### Reception example #####\n");
        Console.WriteLine(reception.StandardDetails() + "\n" + reception.FullDetails() + "\n" + reception.ShortDetails() + "\n");
        Console.WriteLine("\n ##### Outdoor Gathering example #####\n");
        Console.WriteLine(outdoorGathering.StandardDetails() + "\n" + outdoorGathering.FullDetails() + "\n" +outdoorGathering.ShortDetails() + "\n");
    }
}
