namespace TeamRaiden.Core.Contracts.Group
{
    using Infrastructure.Structs;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Team;
   public interface IGroup
   {
        void AddTeam(Team team);
        void RemoveTeam(Team team);
    }
}
