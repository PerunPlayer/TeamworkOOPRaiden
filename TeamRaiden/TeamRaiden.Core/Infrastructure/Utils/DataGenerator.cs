using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TeamRaiden.Core.Infrastructure.Constants;

namespace TeamRaiden.Core.Infrastructure.Utils
{
    class DataGenerator
    {
        private static int initialID;
        private static string[] firstNames;
        private static string[] middleNames;
        private static string[] lastNames;
        private static Random random;

        static DataGenerator()
        {
            initialID = 1;
            firstNames = new string[] { "first names" };
            middleNames = new string[] { " middle names" };
            lastNames = new string[] { "last names" };
            random = new Random();
        }
        public static int GenerateID()
        {
            return Interlocked.Increment(ref initialID);
        }

        public static string GenerateFirstName()
        {
            int indexFirstName = random.Next(0, firstNames.Length);
            return firstNames[indexFirstName];
        }
        public static string GenerateMiddleName()
        {
            int indexMiddleName = random.Next(0, middleNames.Length);
            return middleNames[indexMiddleName];
        }
        public static string GenerateLastlName()
        {
            int indexLastName = random.Next(0, lastNames.Length);
            return lastNames[indexLastName];
        }
        public static int GeneratePlayerNumber()
        {
            return random.Next(GlobalConstants.PlayerNumberMin, GlobalConstants.PlayerNumberMax);
        }
        public static int GenerateCapability()
        {
            return random.Next(GlobalConstants.CapabilityMinInPercents, GlobalConstants.CapabilityMaxInPercents);
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
    }
}
