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
        private static string[] lastNames= {
           "Messi",
           "Ronaldo",
           "Iniesta",
           "Ibrahimovic",
           "Falcao",
           "van Persie ",
           "Pirlo",
           "Toure",
           "Cavani",
           "Aguero",
           "Casillas",
           "Busquets",
           "Alonso",
           "Silva",
           "Ozil",
           "Silva",
           "Schweinsteiger",
           "Buffon",
           "Suarez",
           "Ramos",
           "Kompany",
           "Pique",
           "Lahm",
           "Reus",
           "Ribery",
           "Neuer",
           "Cole",
           "Rooney",
           "Mata",
           "Muller",
           "Götze",
           "Benzema",
           "Fabregas",
           "Mascherano",
           "Bale",
           "Zanetti",
           "De Rossi",
           "Alves",
           "Cech",
           "Hummels",
           "Puyol",
           "Di Maria",
           "Tevez",
           "Drogba",
           "Chiellini",
           "Defender",
           "El Shaarawy",
           "Kroos",
           "Eto’o",
           "Alba",
           "Gomez",
           "Vidal",
           "Hazard",
           "Rodriguez",
           "Fellaini",
           "Villa",
           "Jan Huntelaar",
           "Vidic",
           "Hart",
           "Robben",
           "Balotelli",
           "Valbuena",
           "Aubameyang",
           "Lewandowski",
           "Cazorla",
           "Eriksen",
           "Lavezzi",
           "Moutinho",
           "Mandžukić",
           "Evra",
           "Luiz",
           "Modric",
           "Wanyama",
           "Yanga - M’Biwa",
           "Srna",
           "Mayuka",
           "Terry",
           "Asamoah",
           "Bonucci",
           "Pastore",
           "Mkhitaryan",
           "Dembele",
           "Ben Arfa",
           "Nasri",
           "Kagawa",
           "Sneijder",
           "Defender",
           "Hamsik",
           "Martinez",
           "Forlan"
      };
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