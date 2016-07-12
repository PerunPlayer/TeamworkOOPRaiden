namespace TeamRaiden.Core.Infrastructure.Classes
{
    using System.Collections.Generic;
    using TeamRaiden.Core.Infrastructure.Enumerations;
    using TeamRaiden.Core.Infrastructure.Structs;

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
