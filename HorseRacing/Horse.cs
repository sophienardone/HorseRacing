using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing
{
    public class Horse
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string HorseId { get; set; }
        public Horse(string name, DateTime dateOfBirth, string horseID) {
            Name = name;
            DateOfBirth = dateOfBirth;
            HorseId = horseID;

        }

    }
}
