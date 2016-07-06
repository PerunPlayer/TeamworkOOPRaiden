using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamRaiden.Core.Contracts.Team;
using TeamRaiden.Core.Infrastructure.Classes;
using TeamRaiden.Core.Infrastructure.Enumerations;


namespace TeamRaiden.Core.Infrastructure.Structs
{
    public class Team : ITeam
    {
        public readonly TeamName teamName;
        private ICollection<Player> players;
        private uint teamPoints;
        private Coach coach;

        public Coach Coach
        {
            get { return this.coach; }
            set { this.coach = value; }
        }

        public TeamName TeamName
        {
            get { return this.teamName; }
        }

        public ICollection<Player> Players
        {
            get { return this.players; }
        }

        public uint TeamPoints
        {
            get { return this.teamPoints; }
            private set { this.teamPoints = value; }
        }

        public Team(TeamName teamName,Coach coach, ICollection<Player> players, uint teamPoints = 0)
        {
            this.teamName = teamName;
            this.coach = coach;
            this.players = players;
            this.teamPoints = teamPoints;
        }

        public void AddPoints(uint points)
        {
            this.teamPoints += points;
        }
    }
}
