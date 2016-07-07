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
        List<Player> Players { get; }
        Coach Coach { get; }
        int Points { get; set; }

        void AddPoints(uint points);
        void SwitchPlayers(Player a, Player b);
       
    }
}
