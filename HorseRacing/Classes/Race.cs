using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing.Classes
{
    public class Race
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public List<Horse> Horses { get; set; }

        public Race(string name, DateTime startTime)
        {
            Name = name;
            StartTime = startTime;
            Horses = new List<Horse>();
        }

        public void AddHorse(Horse horse)
        {

            if (horse == null) throw new ArgumentException("Horse cannot be null");

            foreach (var h in Horses)
            {
                if(h.HorseId == horse.HorseId)
                {
                    throw new InvalidOperationException("Horse is already added to the race");
                }
            }
            Horses.Add(horse);
        }

        public void UploadHorses(List<Horse> horses)
        {

            if(horses == null || horses.Count == 0)
            {
                throw new ArgumentException("Horse list cannot be null or empty");
            }

            foreach (var horse in horses)
            {
                AddHorse(horse);
            }
        }

        public void DisplayDetailsFromRace()
        {
            Console.WriteLine($"Race: {Name}, Start Time: {StartTime}");
            foreach (var horse in Horses)
            {
                Console.WriteLine($"Horse: {horse.Name}, Horse ID: {horse.HorseId}");
            }
        }
    }
}
