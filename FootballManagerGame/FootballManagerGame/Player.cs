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

        private string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string Club
        {
            get { return _club; }
            set { _club = value; }
        }

        private double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private bool Active
        {
            get { return _active; }
            set { _active = value; }
        }

        private string GenerateName()
        {
            return "fisk";
        }
    }
}
