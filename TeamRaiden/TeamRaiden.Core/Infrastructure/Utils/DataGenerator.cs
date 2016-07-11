using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TeamRaiden.Core.Contracts;
using TeamRaiden.Core.Infrastructure.Classes;
using TeamRaiden.Core.Infrastructure.Constants;
using TeamRaiden.Core.Infrastructure.Enumerations;
using TeamRaiden.Core.Infrastructure.Structs;

namespace TeamRaiden.Core.Infrastructure.Utils
{
   class DataGenerator
   {

      private static int initialID;
      private static ICollection<string> firstNames;
      private static ICollection<string> lastNames;
      private static Random random;
      private static ICollection<string> teamNames;

      static DataGenerator()
      {
         initialID = 1;
         teamNames = GlobalConstants.TeamNames;
         firstNames = GlobalConstants.FirstNames;
         lastNames = GlobalConstants.LastNames;
         random = new Random();
      }
      public static int GenerateID()
      {
         return Interlocked.Increment(ref initialID);
      }

        public static string GenerateFirstName()
        {
            int indexFirstName = random.Next(0, GlobalConstants.FirstNames.Count-1);
            return GlobalConstants.FirstNames[indexFirstName];
        }
      
        public static string GenerateLastlName()
        {
            int indexLastName = random.Next(0, GlobalConstants.LastNames.Count);
            return GlobalConstants.LastNames[indexLastName];
        }
        public static int GeneratePlayerNumber()
        {
            return random.Next(GlobalConstants.PlayerNumberMin, GlobalConstants.PlayerNumberMax);
        }
        public static int GeneratePlayerCapability()
        {
            return random.Next(GlobalConstants.CapabilityMinInPercents, GlobalConstants.CapabilityMaxInPercents);
        }
        private static int GenerateCoachCapability()
        {
            return random.Next(GlobalConstants.CoachCapabilityMinInPercents, GlobalConstants.CoachCapabilityMaxInPercents);
        }
        public static int GeneratePlayerAge()
        {
            return random.Next(GlobalConstants.PlayerAgeMin, GlobalConstants.PlayerAgeMax);
        }
        public static int GenerateCoachAge()
        {
            return random.Next(GlobalConstants.CoachAgeMin, GlobalConstants.CoachAgeMax);
        }
        public static int GenerateWeigth()
        {
            return random.Next(GlobalConstants.WeigthMin, GlobalConstants.WeigthMax);
        }
        public static int GenerateHeigth()
        {
            return random.Next(GlobalConstants.HeigthMin, GlobalConstants.HeigthMax);
        }
        public static Player GeneratePlayer()
        {
            return new Player(GenerateFirstName(), GenerateLastlName(),GeneratePlayerAge(),GeneratePlayerCapability());
        }
        public static Coach GenerateCoach()
        {
            return new Coach(GenerateFirstName(),GenerateLastlName(), GenerateCoachAge(), GenerateCoachCapability());
        }        
        public static Team GenerateTeam()
        {
            ICollection<Player> players = new List<Player>();
            for (int i = 0; i < GlobalConstants.TotalNumbersOfPlayers; i++)
            {
                players.Add(GeneratePlayer());
            }
            return new Team(GlobalConstants.TeamNames[random.Next(0, GlobalConstants.TeamNames.Count - 1)],
                GenerateCoach(),players);            
        }
        public static Group GenerateGroup()
        {
            ICollection<Team> teams = new List<Team>();
            for (int i = 0; i < GlobalConstants.TotalNumberGroups; i++)
            {
                while (!teams.Contains(GenerateTeam()))
                {
                    teams.Add(GenerateTeam()); // !!!!!!!!!!!!!ATTENTION
                }                  
            }
            return new Group(teams, (GroupName)(random.Next((int)GroupName.NotSet, (int)GroupName.F)));
        }
    }
}            