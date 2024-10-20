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
            Races.Add(race);
            RaceCount = Races.Count;
        }

        public override void displayDetails()
        {
            Console.WriteLine($"Event: {eventName}, Location: {eventLocation}, Amount of Races: {RaceCount}");

            foreach (var race in Races)
            {
                Console.WriteLine($"Race Name: {race.Name}, Start Time: {race.StartTime}");
                foreach (var horse in race.Horses)
                {
                    Console.WriteLine($"Horse Name: {horse.Name}, Horse ID: {horse.HorseId}");
                }
            }
        }
    }

   
}
