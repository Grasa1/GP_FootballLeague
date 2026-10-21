namespace GP_FootballLeage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            League league = new League("League");
            Team team1 = new Team("Team A");
            Team team2 = new Team("Team B");
            Team team3 = new Team("Team C");
            league.AddTeam(team1);
            league.AddTeam(team2);
            league.AddTeam(team3);

            Console.WriteLine(league.AddMatch(team1, team2));
            Console.WriteLine(league.AddMatch(team2, team3));
            Console.WriteLine(league.AddMatch(team1, team3));
            Console.WriteLine(league.AddMatch(team1, team1)); // This should return false

            Console.WriteLine(league.Matches[0].Play(1, 0));
            Console.WriteLine(league.Matches[1].Play(0, 3));
            Console.WriteLine(league.Matches[0].Play(2, 2));

            Console.WriteLine(league.UnplayedCount());
            Console.WriteLine(league.Matches[0].Describe());
            Console.WriteLine(league.Matches[1].Describe());
            Console.WriteLine(league.Matches[2].Describe());

            Console.WriteLine(league.Leader().Describe());
            
            







            
        }
    }
}
