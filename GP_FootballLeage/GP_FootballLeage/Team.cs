using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_FootballLeage
{
    public class Team
    {
        private string _name;
        private int _points;
        private int _goalsFor;
        private int _goalsAgainst;

        public string Name { get { return _name; } set { _name = value; } }
        public int Points { get { return _points; } set {_points = value; } }
        public int GoalsFor { get { return _goalsFor; } set { _goalsFor= value; } }
        public int GoalsAgainst { get { return _goalsAgainst; } set { _goalsAgainst = value;} }

        public Team(string name)
        {
            _name = name;
            _points = 0;
            _goalsFor = 0;
            _goalsAgainst = 0;
        }


        public void AddResult(int lott, int kapott)
        {
            _goalsFor += lott;
            _goalsAgainst += kapott;

            if(_goalsAgainst < _goalsFor)
            {
                _points += 3;
            }
            else if(_goalsAgainst == _goalsFor)
            {
                _points += 1;
            }
           
        }

        public int GoalDifference()
        {
            return _goalsFor - _goalsAgainst;
        }

        public string Describe()
        {
            return $"{_name}: {_points} pont, {_goalsFor}-{_goalsAgainst}";
        }
    }
}
