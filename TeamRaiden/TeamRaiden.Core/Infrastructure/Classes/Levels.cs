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
 

    public class Levels
    {
        private LevelType level;
        private IList<Team> teams;

        public Levels(LevelType newLevel, List<Team> newTeams)
        {
            this.level = newLevel;
            this.teams = newTeams; 
        }


    }
}
