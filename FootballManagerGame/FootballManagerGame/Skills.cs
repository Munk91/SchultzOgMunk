using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerGame
{
    public class Skills
    {
        #region Fields

        private int _attacking;
        private int _midfielding;
        private int _defending;
        private int _goalkeeping;
        const int TOTAL_LEVELS = 30;

        #endregion

        #region Constructors

        public Skills()
        {

        }

        public Skills(int attacking, int midfielding, int defending, int goalkeeping)
        {
            this.Attacking = attacking; //20 niveuaer
            this.Midfielding = midfielding;
            this.Defending = defending;
            this.Goalkeeping = goalkeeping;
        }

        #endregion

        #region Properties

        public int Attacking
        {
            get { return _attacking; }
            set { _attacking = value; }
        }

        public int Midfielding
        {
            get { return _midfielding; }
            set { _midfielding = value; }
        }

        public int Defending
        {
            get { return _defending; }
            set { _defending = value; }
        }

        public int Goalkeeping
        {
            get { return _goalkeeping; }
            set { _goalkeeping = value; }
        }

        #endregion

        public List<int> skillGenerator(int age)
        {
            List<int> skillStat = new List<int>();
            int attack = 0;
            int midfield = 0;
            int defend = 0;
            int gk = 0;

            int totalSkillsSet = 10;
            double maxLevels = TOTAL_LEVELS / (TOTAL_LEVELS / 8d);

            int i = 0;
            while (i < totalSkillsSet)
	        {
	            int tempo = RNG.rand.Next(0, 4);

                if (tempo == 0 && attack <= maxLevels)
                {
                    attack++;
                    i++;
                }
                else if (tempo == 1 && midfield <= maxLevels)
                {
                    midfield++;
                    i++;
                }
                else if (tempo == 2 && defend <= maxLevels)
                {
                    defend++;
                    i++;
                }
                else if (tempo == 3 && gk <= maxLevels)
                {
                    gk++;
                    i++;
                } 
	        }

                
                //int temp = RNG.rand.Next(0, maxLevels + 1);
                //attack = temp;
                //totalSkillsSet -= temp;
            

            skillStat.Add(attack);
            skillStat.Add(midfield);
            skillStat.Add(defend);
            skillStat.Add(gk);

            return skillStat;
        }
    }
}
