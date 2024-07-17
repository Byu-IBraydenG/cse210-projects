using System;

namespace EventPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address address1 = new Address("123 Main St", "Salt Lake", "Utah", "12345");
            Address address2 = new Address("456 Oak St", "New York City", "New York", "67890");
            Address address3 = new Address("789 Pine St", "Detroit", "Michigan", "13579");

            // Create events
            Lecture lecture = new Lecture("AI and the Future", "A talk on artificial intelligence", new DateTime(2024, 8, 20), new TimeSpan(15, 30, 0), address1, "Dr. Smith", 100);
            Reception reception = new Reception("Annual Gala", "A formal gathering to celebrate the year's achievements", new DateTime(2024, 9, 10), new TimeSpan(18, 0, 0), address2, "rsvp@beautybeast.com");
            OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "A fun outdoor picnic", new DateTime(2024, 7, 25), new TimeSpan(12, 0, 0), address3, "Cloudy with a chance of meatballs");

            // Generate and display marketing messages
            Event[] events = { lecture, reception, outdoorGathering };

            foreach (var ev in events)
            {
                Console.WriteLine(ev.GetStandardDetails());
                Console.WriteLine();
                Console.WriteLine(ev.GetFullDetails());
                Console.WriteLine();
                Console.WriteLine(ev.GetShortDescription());
                Console.WriteLine();
                Console.WriteLine(new string('-', 50));
                Console.WriteLine();
            }
        }
    }
}
