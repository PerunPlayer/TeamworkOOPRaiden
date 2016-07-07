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
        private ICollection<Team> teams= new List<Team>();
        private readonly GroupName groupName;

        public ICollection<Team> Teams { get { return this.teams; } set { this.teams = value; } }
        public GroupName GroupName { get { return this.groupName; } }

        public Group(ICollection<Team> teams, GroupName groupName)
        {
            this.Teams = teams;
            this.groupName = groupName;
        }

        public void AddTeam(Team team)
        {
            this.teams.Add(team);
        }

        public void RemoveTeam(Team team)
        {
            this.teams.Remove(team);
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
