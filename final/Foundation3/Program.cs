using System;

class Program
{
    static void Main(string[] args)
    {
        Event lectureEvent = new LectureEvent("Lecture", "TED Talk Night", new DateTime(2023, 12, 15, 10, 0, 0), "123 Main St", "Mr. Johnson", 100);
        Event receptionEvent = new ReceptionEvent("Reception", "Wedding Celebration", new DateTime(2023, 12, 20, 18, 30, 0), "456 Elm St", "ethenl@live.com");
        Event outdoorEvent = new OutdoorEvent("Outdoor", "Enjoy the great outdoors", new DateTime(2023, 12, 25, 14, 0, 0), "789 Oak St", "Sunny");

        DisplayEventMarketing(lectureEvent);
        DisplayEventMarketing(receptionEvent);
        DisplayEventMarketing(outdoorEvent);

    static void DisplayEventMarketing(Event eventObj)
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(eventObj.GetStandardDetails());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(eventObj.GetFullDetails());

        Console.WriteLine("\nShort Description:");
        Console.WriteLine(eventObj.GetShortDescription());

        Console.WriteLine();
    }
    }
}