using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamRaiden.Core.Contracts.Group;
using TeamRaiden.Core.Contracts.Team;
using TeamRaiden.Core.Infrastructure.Enumerations;
using TeamRaiden.Core.Infrastructure.Structs;

namespace TeamRaiden.Core.Infrastructure.Classes
{
   public class Group : IGroup
   {
      private int[,] results;
      private IList<ITeam> teams = new List<ITeam>();
      private readonly GroupName groupName;

      public Group(IList<ITeam> teams, GroupName groupName)
      {
         this.Teams = teams;
         this.groupName = groupName;
         results = new int[teams.Count, teams.Count];
      }

      public IList<ITeam> Teams { get { return this.teams; } set { this.teams = value; } }
      public GroupName GroupName { get { return this.groupName; } }

      public ICollection<ITeam> GroupWinners()
      {
         if (this.Teams.Count > 2)
         {
            for (int i = 0; i < this.Teams.Count; i++)
            {
               for (int j = i + 1; j < this.Teams.Count; j++)
               {
                  if (i != j)
                  {
                     var result = Match.Play(Teams[i], Teams[j]);
                     if (result == 1)
                     {
                        Teams[i].AddPoints(3);
                     }
                     else if (result == 0)
                     {
                        Teams[i].AddPoints(1);
                        Teams[j].AddPoints(1);
                     }
                     else if (result == -1)
                     {
                        Teams[j].AddPoints(3);
                     }
                  }
               }
            }
            var pesho = from x in this.Teams
                        orderby x.Points
                        select x;

            foreach (var item in this.Teams)
            {
               item.ClearPoints();
            }
            return pesho.ToList().GetRange(0, Teams.Count / 2);
         }
         else
         {
            return DirectEliminations(Match.Play(Teams[0], Teams[1]));
         }
      }

      public List<ITeam> DirectEliminations(int result)
      {
         if (result == 1)
         {
            return new List<ITeam>() { this.Teams[0] };
         }
         else if (result == 0)
         {
            return DirectEliminations(Match.Penalties(this.Teams[0], this.Teams[1]));
         }
         else
         {
            return new List<ITeam>() { this.Teams[1] };
         }
      }

      public override string ToString()
      {
         var result = new StringBuilder();
         result.AppendLine("GROUP: " + GroupName.ToString());
         foreach (var item in teams)
         {
            result.AppendLine(item.TeamName.ToString());
         }

         return result.ToString();
      }
   }
}
