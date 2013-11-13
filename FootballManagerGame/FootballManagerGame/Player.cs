using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerGame
{
    public class Player 
    {
        #region Fields

        private string _name;
        private string _club;
        private int _age;
        private double _value;
        private bool _active;
        Skills skills = new Skills();

        #endregion

        #region Constructors

        public Player(int age, string club, double value, bool active)
        {
            _name = GenerateName();
            Age = age;
            Club = club;
            Value = value;
            Active = active;

            List<int> skillList = new List<int>();
            skillList = skills.skillGenerator(age);

            skills.Attacking = skillList[0];
            skills.Midfielding = skillList[1];
            skills.Defending = skillList[2];
            skills.Goalkeeping = skillList[3];

        }

        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
        }

        public string Club
        {
            get { return _club; }
            set { _club = value; }
        }

        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }

        #endregion

        #region Private Methods

        private string GenerateName()
        {
            List<string> firstNames = new List<string>(File.ReadAllLines("firstNames.txt"));
            List<string> secondNames = new List<string>(File.ReadAllLines("secondNames.txt"));

            return firstNames[RNG.rand.Next(0, firstNames.Count)] + " " + secondNames[RNG.rand.Next(0, secondNames.Count)];
        }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return "Name: " + Name + "\n" + "Age: " + Age + "\n" +
                "Attacking: " + skills.Attacking + " Midfielding: " + skills.Midfielding + "\n" +
                "Defending: " + skills.Defending + " Goalkeeping: " + skills.Goalkeeping + "\n";
        }

        #endregion
    }
}
