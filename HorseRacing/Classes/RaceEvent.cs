using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing.Classes
{
    public class RaceEvent : Event
    {
        public int RaceCount { get; set; }
        public List<Race> Races { get; set; }

        public RaceEvent(string eventName, string eventLocation, int raceCount) : base(eventName, eventLocation)
        {
            RaceCount = raceCount;
            Races = new List<Race>();
        }


        public void AddRace(Race race)
        {
            if (race == null) throw new ArgumentException("Race cannot be null");

            foreach (var r in Races)
            {
                if (r.Name == race.Name)
                {
                    throw new InvalidOperationException("Race already added to event");
                }
            }
            Races.Add(race);
            RaceCount = Races.Count;
        }

        public override void displayDetails()
        {

            if(Races.Count == 0)
            {
                Console.WriteLine("No race results for this event");
                return;
            }

            Console.WriteLine($"Event: {eventName}, Location: {eventLocation}, Amount of Races: {RaceCount}");

            foreach (var race in Races)
            {
                race.DisplayDetailsFromRace();

                if(race.Horses.Count == 0)
                {
                    Console.WriteLine($"Race '{race.Name}' has no horses.");
                }
            }
        }
    }

   
}
