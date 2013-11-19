using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerGame
{
    public class Club
    {
        #region Fields

        private string _clubName;
        private string _managerName;
        private int _squadSize;
        private List<Player> _squad;

        #endregion

        #region Constructors

        public Club(List<Player> squad, string clubName, string managerName, int squadSize)
        {
            this.Squad = squad;
            this.ClubName = clubName;
            this.SquadSize = squadSize;
        }

        #endregion

        #region Properties

        public string ClubName
        {
            get { return _clubName; }
            set { _clubName = value; }
        }

        public string ManagerName
        {
            get { return _managerName; }
            set { _managerName = value; }
        }

        public int SquadSize
        {
            get { return _squadSize; }
            set { _squadSize = value; }
        }

        public List<Player> Squad
        {
            get { return _squad; }
            set { _squad = value; }
        }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return ClubName + ", Squad size: " + SquadSize;
        }

        #endregion
    }
}
