using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing.Classes
{
    public abstract class Event
    {
        public string eventName {  get; set; }
        public string eventLocation { get; set; }
        public Event(string eventName, string eventLocation)
        {
            this.eventName = eventName;
            this.eventLocation = eventLocation;

        }

        public abstract void displayDetails();
    }
}
