using System;

namespace RugbyWorldCup
{
    public class Team
    {
        public Team(string name)
        {
            Name = name;
        }

        public string Name { get ; set ; }
        public int Pool { get ; set ; }
        public int Points { get ; set ; }
    }
}

