using System;

class Program
{
    static void Main(string[] args)
       {
        // Creating example events
        Address address1 = new Address
        {
            Street = "123 Main Street",
            City = "New York",
            State = "NY",
            PostalCode = "10001"
        };

        Lecture lectureEvent = new Lecture("Conference", "Learn about the Church of Jesus Christ", new DateTime(2023, 7, 20), new TimeSpan(9, 0, 0), address1, "John Doe", 100);

        Address address2 = new Address
        {
            Street = "456 Elm Street",
            City = "Los Angeles",
            State = "CA",
            PostalCode = "90001"
        };

        Reception receptionEvent = new Reception("Networking Mixer", "Connect with professionals", new DateTime(2023, 7, 22), new TimeSpan(18, 30, 0), address2, "abibi@gmail.com");

        Address address3 = new Address
        {
            Street = "789 Oak Street",
            City = "Seattle",
            State = "WA",
            PostalCode = "98101"
        };

        OutdoorGathering outdoorGatheringEvent = new OutdoorGathering("Picnic in the Park", "Enjoy food and games", new DateTime(2023, 7, 25), new TimeSpan(12, 0, 0), address3, "Sunny");

        // Generating marketing messages
        Console.WriteLine("--- Standard Details ---");
        Console.WriteLine(lectureEvent.GetEventDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetEventDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGatheringEvent.GetEventDetails());
        Console.WriteLine();

        Console.WriteLine("--- Full Details ---");
        Console.WriteLine(lectureEvent.GetEventDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetEventDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGatheringEvent.GetEventDetails());
        Console.WriteLine();

        Console.WriteLine("--- Short Description ---");
        Console.WriteLine($"Type: Lecture\nTitle: {lectureEvent.Title}\nDate: {lectureEvent.Date.ToShortDateString()}");
        Console.WriteLine();
        Console.WriteLine($"Type: Reception\nTitle: {receptionEvent.Title}\nDate: {receptionEvent.Date.ToShortDateString()}");
        Console.WriteLine();
        Console.WriteLine($"Type: Outdoor Gathering\nTitle: {outdoorGatheringEvent.Title}\nDate: {outdoorGatheringEvent.Date.ToShortDateString()}");

        Console.ReadLine();
    }
}



