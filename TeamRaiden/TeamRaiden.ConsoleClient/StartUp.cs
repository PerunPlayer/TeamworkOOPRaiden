namespace TeamRaiden.ConsoleClient
{
    using Core.Infrastructure.Classes;
    using Core.Infrastructure.Enumerations;
    using Core.Infrastructure.Structs;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        static void Main()
        {
            Coach coach = new Coach("dd", "dd");
            List<Player> players = new List<Player>();
            Team t1 = new Team(TeamName.Albania, coach, players);
            Team t2 = new Team(TeamName.Armenia, coach, players);
            Team t3 = new Team(TeamName.Andorra, coach, players);
            Team t4 = new Team(TeamName.Belgium, coach, players);
            List<Team> teams = new List<Team>() { t1, t2, t3 };
            Group g = new Group(teams, GroupName.C);
            Console.WriteLine(g);
            g.AddTeam(t4);
            Console.WriteLine(g);
            g.RemoveTeam(t1);
            Console.WriteLine(g);
        }


    }
}
