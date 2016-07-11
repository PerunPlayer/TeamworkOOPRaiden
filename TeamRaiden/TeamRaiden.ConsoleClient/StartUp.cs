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

         List<Player> peshovci = new List<Player>()
         {
            new Player("pesho","peshkov",12,100),
            new Player("gosho","hodor!",35,100),
         };
         Coach penata = new Coach("dimityr", "penev", 70, 100);
         Team PFCpesho = new Team((TeamName)8, penata, peshovci);

         Console.WriteLine(Match.Play(PFCpesho, PFCpesho));

         //!!!!!!!!!!!
         Engine.Start(); // We can put all this info in the engin and to start it when predenting.


      }


   }
}
