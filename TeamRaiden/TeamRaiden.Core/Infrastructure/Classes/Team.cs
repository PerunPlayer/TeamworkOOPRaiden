﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamRaiden.Core.Contracts.Team;
using TeamRaiden.Core.Infrastructure.Classes;
using TeamRaiden.Core.Infrastructure.Constants;
using TeamRaiden.Core.Infrastructure.Enumerations;


namespace TeamRaiden.Core.Infrastructure.Structs
{
    public class Team : ITeam
    {
        private readonly TeamName teamName;
        private ICollection<Player> players;
        private uint points = 0;
        private Coach coach;
        private int totalTeamCapability;

        public Coach Coach { get { return this.coach; } set { this.coach = value; } }
        public TeamName TeamName { get { return this.teamName; } }
        public ICollection<Player> Players { get { return this.players; } }
        public uint Points { get { return this.points; } private set { this.points = value; } }
        public int TotalTeamCapability { get { return this.totalTeamCapability; } set { this.totalTeamCapability = value; } }

        public Team(TeamName teamName, Coach coach, ICollection<Player> players)
        {
            this.teamName = teamName;
            this.coach = coach;
            this.players = players;
            this.totalTeamCapability = CalculateTotalTeamCapability();
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
        public void SwitchPlayers(Player a, Player b)  ///???????????
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
         this.Points=0;
      }
   }
}
