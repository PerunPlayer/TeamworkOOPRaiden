namespace TeamRaiden.ConsoleClient
{
    using TeamRaiden.Core.Infrastructure.Enumerations.HumanEnumerations;
    using Core.Engine;
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
            //Coach coach = new Coach("dd", "dd");
            //List<Player> players = new List<Player>()
            //{
            //    new Player("a","a", 1,PlayerPositionType.Attacker, PlayerType.Starter),
            //    new Player("b","b",2,PlayerPositionType.Attacker, PlayerType.Substitute)
            //};

            //Team t1 = new Team(TeamName.Albania, coach, players);
            //Team t2 = new Team(TeamName.Albania, coach, players);

            //foreach (var item in players)
            //{

            //    Console.WriteLine(item.playerType);

            //}

            //t1.SwitchPlayers(players[0], players[1]);

            //foreach (var item in players)
            //{

            //    Console.WriteLine(item.playerType);

            //}

            Console.WriteLine("Please,\r\nEnter a name of your league:");
            string nameOfLeague = Console.ReadLine();
            Console.WriteLine("Please,\r\nEnter the number of all teams in the league:\r\n(ATTENTION: The number should be divisible by 4 and should be a power of 2!)");
            int numberOfTeams = int.Parse(Console.ReadLine());

            try
            {
                if (numberOfTeams > 0 && numberOfTeams % 4 == 0 && IsPowerOfTwo(numberOfTeams))
                {
                    Engine.Start(numberOfTeams);
                }
                else
                {
                    throw new ArgumentException("The number of all teams in the league should be divisible by 4 and should be a power of 2!");
                }
            }           
            catch (ArgumentException)
            {
                Console.WriteLine("The number of all teams in the league should be divisible by 4 and should be a power of 2!");

            }
        }
        public static bool IsPowerOfTwo(int x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }

    }
}
