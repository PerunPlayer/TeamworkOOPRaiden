namespace TeamRaiden.Core.Infrastructure.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using TeamRaiden.Core.Contracts.Team;
    using TeamRaiden.Core.Infrastructure.Classes;
    using TeamRaiden.Core.Infrastructure.Constants;
    using TeamRaiden.Core.Infrastructure.Enumerations;
    using TeamRaiden.Core.Infrastructure.Enumerations.HumanEnumerations;
    using TeamRaiden.Core.Infrastructure.Structs;

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
            int indexFirstName = random.Next(0, GlobalConstants.FirstNames.Count - 1);
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
            Random rand = new Random();
            var change = rand.Next(GlobalConstants.PlayerAgeMin, GlobalConstants.PlayerAgeMax);
            change= rand.Next(GlobalConstants.PlayerAgeMin, GlobalConstants.PlayerAgeMax);
            return change;
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
        public static RaceType GenerateRace()
        {
            return (RaceType)random.Next((int)(RaceType.NotSet), (int)(RaceType.Negroid));
        }
        public static ReligionType GenerateReligion()
        {
            return (ReligionType)random.Next((int)(ReligionType.NotSet), (int)(ReligionType.Ateizm));
        }
        public static FaceShapeType GenerateFace()
        {
            return (FaceShapeType)random.Next((int)(FaceShapeType.NotSet), (int)(FaceShapeType.Heart));
        }
        public static EyeColorType GenerateEyes()
        {
            return (EyeColorType)random.Next((int)(EyeColorType.NotSet), (int)(EyeColorType.Black));
        }
        public static BodyShapeType GenerateBody()
        {
            return (BodyShapeType)random.Next((int)(BodyShapeType.NotSet), (int)(BodyShapeType.InvertedTriangle));
        }
        public static HairColorType GenerateHair()
        {
            return (HairColorType)random.Next((int)(HairColorType.NotSet), (int)(HairColorType.Red));
        }
        public static PlayerType GeneratePlayerType()
        {
            return (PlayerType)random.Next((int)(PlayerType.Starter), (int)(PlayerType.Starter));
        }
        public static PlayerPositionType GeneratePlayerPosition()
        {
            return (PlayerPositionType)random.Next((int)(PlayerPositionType.GoalKeeper), (int)(PlayerPositionType.Attacker));
        }
        public static string GenerateTeamName()
        {
            int indexTeamName = random.Next(0, GlobalConstants.TeamNames.Count - 1);
            return GlobalConstants.TeamNames[indexTeamName];
        }
        
        public static Player GeneratePlayer()
        {
            return new Player(GenerateFirstName(), GenerateLastlName(), GenerateID(), GeneratePlayerAge(), GenerateHeigth(),
                GenerateWeigth(), GenerateRace(), GenerateReligion(), GenerateEyes(), GenerateFace(), GenerateHair(), GenerateBody(),
                GeneratePlayerNumber(), GeneratePlayerPosition(), GeneratePlayerType(), GeneratePlayerCapability());
        }
        public static Coach GenerateCoach()
        {
            return new Coach(GenerateFirstName(), GenerateLastlName(), GenerateID(), GenerateCoachAge(), GenerateHeigth(),
               GenerateWeigth(), GenerateRace(), GenerateReligion(), GenerateEyes(), GenerateFace(), GenerateHair(), GenerateBody(), GenerateCoachCapability());
        }
        public static Team GenerateTeam()
        {
            ICollection<Player> players = new List<Player>();
            for (int i = 0; i < GlobalConstants.TotalNumbersOfPlayers; i++)
            {
                players.Add(GeneratePlayer());
            }
            return new Team(GlobalConstants.TeamNames[random.Next(0, GlobalConstants.TeamNames.Count - 1)],
                GenerateCoach(), players);
        }
        public static Group GenerateGroup()
        {
            IList<ITeam> teams = new List<ITeam>();
            for (int i = 0; i < GlobalConstants.TotalNumberGroups; i++)
            {
                while (!teams.Contains(GenerateTeam()))
                {
                    teams.Add(GenerateTeam());   // !!!!!!!!!!!!!ATTENTION
                }
            }
            return new Group(teams, (GroupName)(random.Next((int)GroupName.NotSet, (int)GroupName.F)));
        }
    }
}