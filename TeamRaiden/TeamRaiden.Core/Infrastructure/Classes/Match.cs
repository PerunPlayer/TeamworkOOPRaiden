namespace TeamRaiden.Core.Infrastructure.Classes
{
   using Contracts.Team;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public static class Match
   {
      static Match()
      {

      }

      /// <summary>
      /// Takes team1 and team2 and returns indication of their goals values.
      /// </summary>
      public static int Play(ITeam team1, ITeam team2)
      {
         int result = 0;

         Random rng = new Random();
         var team1Goals = rng.Next(team1.TotalTeamCapability / 90, team1.TotalTeamCapability / 20);
         var team2Goals = rng.Next(team2.TotalTeamCapability / 90, team2.TotalTeamCapability / 20);

         result = team1Goals.CompareTo(team2Goals);

         return result;
      }

      public static int Penalties(ITeam team1,ITeam team2)
      {
         Random rng = new Random();
         return rng.Next(-1, 1);
      }
   }
}
