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
            Horses.Add(horse);
        }
    }
}
