using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamRaiden.Core.Infrastructure.Classes;
using TeamRaiden.Core.Infrastructure.Enumerations;
using TeamRaiden.Core.Infrastructure.Structs;

namespace _01.TeamRaiden.WFClient.TeamsInfo
{
    public class TeamsInfo
    {
        public void Info()
        {
            #region Albania
            List<Starter> albaniaStarters = new List<Starter>();
            albaniaStarters.Add(new Starter("Berisha", "Etrir", 1, PlayerType.GoalKeeper));
            albaniaStarters.Add(new Starter("Lenjami", "Ermir", 2, PlayerType.Defender));
            albaniaStarters.Add(new Starter("Hysaj", "Elseid", 3, PlayerType.Defender));
            albaniaStarters.Add(new Starter("Mavraj", "Mergim", 4, PlayerType.Defender));
            albaniaStarters.Add(new Starter("Abrashi", "Amir", 5, PlayerType.Defender));
            albaniaStarters.Add(new Starter("Lila", "Andi", 6, PlayerType.MiddleFielder));
            albaniaStarters.Add(new Starter("Basha", "Migjen", 7, PlayerType.MiddleFielder));
            albaniaStarters.Add(new Starter("Xhaka", "Taulant", 8, PlayerType.MiddleFielder));
            albaniaStarters.Add(new Starter("Kukeli", "Burim", 9, PlayerType.MiddleFielder));
            albaniaStarters.Add(new Starter("Gashi", "Shkelzen", 10, PlayerType.Attacker));
            albaniaStarters.Add(new Starter("Shala", "Herolind", 11, PlayerType.Attacker));

            List<Substitute> albaniaSubstitutes = new List<Substitute>();
            albaniaSubstitutes.Add(new Substitute("Sheshi", "Orges", 12, PlayerType.GoalKeeper));
            albaniaSubstitutes.Add(new Substitute("Agolli", "Ansi", 13, PlayerType.Defender));
            albaniaSubstitutes.Add(new Substitute("Ajeti", "Arlind", 14, PlayerType.Defender));
            albaniaSubstitutes.Add(new Substitute("Aliji", "Naser", 15, PlayerType.Defender));
            albaniaSubstitutes.Add(new Substitute("Veseli", "Freddie", 16, PlayerType.Defender));
            albaniaSubstitutes.Add(new Substitute("Cana", "Lorik", 17, PlayerType.MiddleFielder));
            albaniaSubstitutes.Add(new Substitute("Kace", "Ergys", 18, PlayerType.MiddleFielder));
            albaniaSubstitutes.Add(new Substitute("Memushaj", "Ledian", 19, PlayerType.MiddleFielder));
            albaniaSubstitutes.Add(new Substitute("Rashica", "Milot", 20, PlayerType.MiddleFielder));
            albaniaSubstitutes.Add(new Substitute("Cikalleshi", "Sokol", 21, PlayerType.Attacker));
            albaniaSubstitutes.Add(new Substitute("Sadiku", "Armando", 22, PlayerType.Attacker));

            Team Albania = new Team(TeamName.Albania, albaniaStarters, albaniaSubstitutes);
            #endregion


        }

    }
}
                             