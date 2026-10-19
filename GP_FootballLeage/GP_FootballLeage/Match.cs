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



        public bool Play(int homeGoals, int awayGoals)
        {
            if (_isPlayed || homeGoals < 0 || awayGoals < 0)
            {
                return false;
            }
            _homeGoals = homeGoals;
            _awayGoals = awayGoals;
            _isPlayed = true;
            _home.AddResult(homeGoals, awayGoals);
            _away.AddResult(awayGoals, homeGoals);
            return true;

        }
        public string Describe()
        {
            if (_isPlayed)
            {
                return $"{_home.Name} - {_away.Name} {_homeGoals}:{_awayGoals}";
            }
            else
            {
                return $"{_home.Name} - {_away.Name} (még nem játszották)";
            }
        }
    }
}
