namespace TeamRaiden.Core.Contracts.Group
{
    using Infrastructure.Enumerations;
    using Infrastructure.Structs;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Team;
    public interface IGroup
    {
        ICollection<Team> Teams { get; }
        GroupName GroupName { get; }
        void AddTeam(Team team);
        void RemoveTeam(Team team);
    }
}
