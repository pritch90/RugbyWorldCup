using System;
using System.Collections.Generic;

namespace RugbyWorldCup
{
    class Program
    {
        static void Main ()
        {
            ResultsTable pool1 = new ResultsTable();

            Team Wales = new Team("Wales");
            Team England = new Team("England");
            Team Australia = new Team("Australia");
            Team Fiji = new Team("Fiji");
            Team Uruguay = new Team("Uruguay");

            pool1.AddTeam(Wales);
            pool1.AddTeam(England);
            pool1.AddTeam(Australia);
            pool1.AddTeam(Fiji);
            pool1.AddTeam(Uruguay);

            Match walesEngland = new Match(Wales, England, 20, 15);
            Match walesFiji = new Match(Wales, Fiji, 80, 47);
            Match walesUruguay = new Match(Wales, Uruguay, 25, 10);
            Match walesAustralia = new Match(Wales, Australia, 12, 15);
            Match australiaEngland = new Match(Australia, England, 35, 15);
            Match australiaFiji = new Match(Australia, Fiji, 12, 0);
            Match australiaUruguay = new Match(Australia, Uruguay, 0, 15);
            Match englandFiji = new Match(England, Fiji, 18, 21);
            Match englandUruguay = new Match(England, Uruguay, 22, 10);
            Match fijiUruguay = new Match(Fiji, Uruguay, 4, 7);

            pool1.CalculateLeader();
            Console.WriteLine("The winner of pool 1 is {0}", pool1.Winner.Name);

            Console.WriteLine("{0} winner is {1}", walesAustralia.Name, walesAustralia.Winner.Name);
        }
    }
}