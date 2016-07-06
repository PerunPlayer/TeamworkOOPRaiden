using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamRaiden.Core.Infrastructure.Classes;
using TeamRaiden.Core.Infrastructure.Enumerations;

namespace TeamRaiden.Core.Infrastructure.Structs
{
    public struct Team
    {
        private readonly TeamName teamName;
        private readonly ICollection<Starter> starters;
        private readonly ICollection<Substitute> substitutes;


        public TeamName TeamName
        {
            get { return this.teamName; }
        }
        public ICollection<Starter> Starters
        {
            get { return this.starters; }
        }
        public ICollection<Substitute> Substitutes
        {
            get { return this.substitutes; }
        }

        public uint TeamPoints { get; set; }

        public Team(TeamName teamName, ICollection<Starter> starters, ICollection<Substitute> substitutes, uint teamPoints = 0)
        {
            this.teamName = teamName;
            this.starters = starters;
            this.substitutes = substitutes;
            this.TeamPoints = teamPoints;
        }

    }
}
