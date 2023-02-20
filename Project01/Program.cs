using System;
using System.Collections.Generic;

namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Event> events = new List<Event>();
            bool userWantsToAddAnotherEvent;
            do
            {
                events.Add(AcceptEventDetails());
                Console.WriteLine();

                Console.Write("Do you wan to add another event (Y/ N)? ");
                string userResponse = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                userResponse = userResponse.ToLower();
                userWantsToAddAnotherEvent = (userResponse == "y")? true : false;
            } while (userWantsToAddAnotherEvent);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Displaying days left to events");
            Console.WriteLine();

            foreach (Event _event in events)
            {
                Console.WriteLine(_event);
                Console.WriteLine($"Happening after {_event.CalculateDaysLeftToEvent()} day(s)");
            }
        }

        static Event AcceptEventDetails()
        {
            Console.Write("Enter Event title: ");
            string title = Console.ReadLine();
            Console.Write("Enter day (Eg. 1 - 31): ");
            string day = Console.ReadLine();
            Console.Write("Enter month (Eg. 1 - 12): ");
            string month = Console.ReadLine();
            Console.Write("Enter year (Eg. 2024, 2023): ");
            string year = Console.ReadLine();
            DateTime date = ConvertToDate(year, month, day);
            Event _event = new Event(date, title);
            return _event;
        }

        static DateTime ConvertToDate(string year, string month, string day)
        {
            string dateAsString = $"{year}-{month}-{day}";
            DateTime eventDate = DateTime.Parse(dateAsString);

            return eventDate;
        }
    }
}
