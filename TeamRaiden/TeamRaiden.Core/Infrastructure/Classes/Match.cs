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
      /// Takes team1 and team2 and returns result of the match "x:y" as string where x are goals for team1 and y - team2.
      /// </summary>
      public static string Play(ITeam team1,ITeam team2)
      {
         string result = string.Empty;

         Random rng = new Random();
         result = $"{rng.Next(team1.TotalTeamCapability / 90,team1.TotalTeamCapability / 20)}:{rng.Next(team2.TotalTeamCapability / 90,team2.TotalTeamCapability / 20)}";
         
         return result;
      }
   }
}
