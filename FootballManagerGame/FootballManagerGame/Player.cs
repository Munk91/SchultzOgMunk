using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerGame
{
    public class Player
    {
        private string _name;
        private string _club;
        private int _age;
        private double _value;
        private bool _active;

        public Player(string name, int age, string club, double value, bool active)
        {
            Name = name;
            Age = age;
            Club = club;
            Value = value;
            Active = active;
        }

        string Name { get; set; }
        string Club { get; set; }
        double Value { get; set; }
        int Age { get; set; }
        bool Active { get; set; }
    }
}
