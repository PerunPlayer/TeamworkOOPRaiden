﻿namespace TeamRaiden.Core.Infrastructure.Structs
{
    using System.Collections.Generic;
    using System.Text;
    using TeamRaiden.Core.Contracts.Team;
    using TeamRaiden.Core.Infrastructure.Classes;
    using TeamRaiden.Core.Infrastructure.Enumerations;
    public class Team : ITeam
    {
        private string teamName;
        private ICollection<Player> players;
        private uint points = 0;
        private Coach coach;
        private int totalTeamCapability;

        public Team(string teamName, Coach coach, ICollection<Player> players)
        {
            this.TeamName = teamName;
            this.Coach = coach;
            this.Players = players;
            this.TotalTeamCapability = CalculateTotalTeamCapability();
        }
        public int CalculateTotalTeamCapability()
        {
            int teamCapability = 0;
            foreach (Player player in this.players)
            {
                teamCapability += player.Capability;
            }
            teamCapability /= players.Count;
            teamCapability += coach.CoachCapability;
            teamCapability /= 2;
            return teamCapability;
        }

        public void AddPoints(uint points)
        {
            this.points += points;
        }
        public void SwitchPlayers(Player a, Player b)
        {
            foreach (var player in this.players)
            {
                if (player == a)
                {
                    player.PlayerType = PlayerType.Substitute;
                }
                if (player == b)
                {
                    player.PlayerType = PlayerType.Starter;
                }
            }

        }

        public void ClearPoints()
        {
            this.Points = 0;
        }
        public override string ToString()
        {
            string teamName = "TEAM:";
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(new string('#', 80)));
            sb.AppendLine(teamName);
            sb.AppendLine(this.TeamName);
            sb.Append(this.Coach.ToString());
            foreach (var player in this.Players)
            {
                sb.Append(player.ToString());

            }
            sb.Append(string.Format(new string('#', 80)));
            return sb.ToString();
        }

        public Coach Coach
        {
            get
            {
                return this.coach;
            }
            set
            {
                this.coach = value;
            }
        }
        public string TeamName
        {
            get
            {
                return this.teamName;
            }
            private set
            {
                this.teamName = value;
            }
        }
        public ICollection<Player> Players
        {
            get
            {
                return this.players;
            }
            private set
            {
                this.players = value;
            }
        }
        public uint Points
        {
            get
            {
                return this.points;
            }
            private set
            {
                this.points = value;
            }
        }
        public int TotalTeamCapability
        {
            get
            {
                return this.totalTeamCapability;
            }
            private set
            {
                this.totalTeamCapability = value;
            }
        }
    }
}
