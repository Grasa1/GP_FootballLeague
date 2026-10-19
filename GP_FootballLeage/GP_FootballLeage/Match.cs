using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_FootballLeage
{
    public class Match
    {
        private Team _home;
        private Team _away;
        private int _homeGoals;
        private int _awayGoals;
        private bool _isPlayed;

        public Team Home
        {
            get { return _home; }
            set { _home = value; }
        }
        public Team Away
        {
            get { return _away; }
            set { _away = value; }
        }
        public int HomeGoals
        {
            get { return _homeGoals; }
            set { _homeGoals = value; }
        }
        public int AwayGoals
        {
            get { return _awayGoals; }
            set { _awayGoals = value; }
        }
        public bool IsPlayed
        {
            get { return _isPlayed; }
            set { _isPlayed = value; }
        }

        public Match(Team home, Team away)
        {
            _home = home;
            _away = away;
            _homeGoals = 0;
            _awayGoals = 0;
            _isPlayed = false;
        }

    }
}
