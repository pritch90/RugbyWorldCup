using System;

namespace RugbyWorldCup
{
    public class Match
    {
        public Match(Team team1, Team team2, int pointsTeam1, int pointsTeam2)
        {
            Name = team1.Name + " vs " + team2.Name;
           
            Team1 = team1;
            Team2 = team2;

            if (pointsTeam1 > pointsTeam2)
            {
                int numTries = pointsTeam1 % 7;

                Winner = Team1;

                if (numTries >= 4)
                {
                    Team1.Points += 5;
                }
                else 
                {
                    Team1.Points += 4;
                }

                if (pointsTeam1 - pointsTeam2 <= 7)
                {
                    Team2.Points += 1;
                }
            }

            if (pointsTeam1 < pointsTeam2)
            {
                int numTries = pointsTeam2 % 7;

                Winner = Team2;

                if (numTries >= 4)
                {
                    Team2.Points += 5;
                }
                else
                {
                    Team2.Points += 4;
                }

                if (pointsTeam2 - pointsTeam1 <= 7)
                {
                    Team1.Points += 1;
                }
            }

            if (pointsTeam1 == pointsTeam2)
            {
                Winner = null;
                Team1.Points += 2;
                Team2.Points += 2;
            }
        }

        public Team Team1 { get ; set ; }
        public Team Team2 { get ; set ; }
        public Team Winner;
        public string Name { get ; set ; }
    }
}

