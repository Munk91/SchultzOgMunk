using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerGame
{
    public interface IPlayer
    {
        string Name { get; set; }
        string Nationality { get; set; }
        string Foot { get; set; }
        string Club { get; set; }
        string Value { get; set; }
        string CareerInjuries { get; set; }
        int Age { get; set; }
        int Height { get; set; }
        int Weight { get; set; }
        DateTime DateOfBirth { get; set; }
        bool Active { get; set; }
    }
}
