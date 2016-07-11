namespace TeamRaiden.Core.Contracts.Team
{
   using Infrastructure.Classes;
   using Infrastructure.Enumerations;
   using Infrastructure.Structs;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

    public interface ITeam
    {
        TeamName TeamName { get; }
        ICollection<Player> Players { get; }
        Coach Coach { get; }
        uint Points { get; }
        int TotalTeamCapability { get; set; }

        void AddPoints(uint points);
        void SwitchPlayers(Player a, Player b);
        void ClearPoints();
   }
}
