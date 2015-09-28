using System;
using System.Collections.Generic;

namespace RugbyWorldCup
{
    public class ResultsTable
    {
        public ResultsTable ()
        {
            int maxPoints = 0;
            teams = new List<Team>();
        }

        public void AddTeam(Team TeamName)
        {
            teams.Add(TeamName);
        }

        public void CalculateLeader()
        {
            foreach (Team team in teams)
            {
                maxPoints = Math.Max(team.Points, maxPoints);
                if (maxPoints == team.Points)
                {
                    Winner = team;
                }
            }
        }

        public Team Winner;
        private int maxPoints;
        private List<Team> teams;
    }
}

