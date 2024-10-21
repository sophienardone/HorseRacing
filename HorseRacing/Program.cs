﻿using HorseRacing.Classes;

namespace HorseRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<RaceEvent> raceEvents = new List<RaceEvent>();

            while (true)
            {

                menuOptions();
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {

                    case "1":
                        CreateEvent(raceEvents);
                        break;

                    case "2":
                        AddRaceToEvent(raceEvents);
                        break;

                    case "3":
                        AddHorseToRace(raceEvents);
                        break;

                    case "4":
                        DisplayEventDetails(raceEvents);
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid option, Try Again");
                        break;
                }
            }
        }


        static void menuOptions()
        {
            Console.WriteLine("\nHello and Welcome to HorseHaven Racing Management System");
            Console.WriteLine("1. Create an Event");
            Console.WriteLine("2. Add a Race to an Event");
            Console.WriteLine("3. Add a Horse to a Race");
            Console.WriteLine("4. Display Event Details");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose an option: ");

        }

        static void CreateEvent(List<RaceEvent> raceEvents)
        {
            Console.WriteLine("Enter the name of the event you want to create");
            string eventName = Console.ReadLine();
            Console.WriteLine("Enter the location of the event");
            string eventLocation = Console.ReadLine();
            Console.WriteLine("Enter the number of races you want in the event");
            if (!int.TryParse(Console.ReadLine(), out int raceCount))
            {
                Console.WriteLine("Invalid input, please enter a valid number");
                return;
            }

            RaceEvent newEvent = new RaceEvent(eventName, eventLocation, raceCount);
            raceEvents.Add(newEvent);
            Console.WriteLine("Event created");
        }

        static void AddRaceToEvent(List<RaceEvent> raceEvents)
        {
            if (raceEvents.Count == 0)
            {
                Console.WriteLine("No events available, please create an event");
                return;
            }
            Console.WriteLine("Available Events:");
            for (int i = 0; i < raceEvents.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {raceEvents[i].eventName} - {raceEvents[i].eventLocation}");
            }

            Console.Write("Enter the number of the event to add a race: ");
            if (!int.TryParse(Console.ReadLine(), out int eventIndex) || eventIndex < 1 || eventIndex > raceEvents.Count)
            {
                Console.WriteLine("Invalid event number");
                return;
            }

            RaceEvent selectedEvent = raceEvents[eventIndex - 1];

            Console.Write("Enter the name of the race: ");
            string raceName = Console.ReadLine();

            Console.Write("Enter the start time of the race");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime startTime))
            {
                Console.WriteLine("Invalid date and time format, please use YYYY-MM-DD HH:MM");
                return;
            }

            selectedEvent.AddRace(new Race(raceName, startTime));
            Console.WriteLine("Race added successfully.");
        }



    }
}


