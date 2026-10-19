using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_FootballLeage
{
    public class League
    {
        private string _name;
        private List<Team> _teams;
        private List<Match> _matches;

        public string Name { get { return _name; } set { _name = value; } }
        public List<Team> Teams { get { return _teams; } }
        public List<Match> Matches { get { return _matches; } }

        public League(string name)
        {
            _name = name;
            _teams = new List<Team>();
            _matches = new List<Match>();
        }

        public void AddTeam(Team team)
        {
            _teams.Add(team);
        }

        public bool AddMatch(Team team1, Team team2)
        {
            if(team1 == team2)
            {
                return false;
            }
            Match match = new Match(team1, team2);
            _matches.Add(match);
            return true;
        }

    }
}
