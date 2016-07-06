using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamRaiden.Core.Infrastructure.Enumerations;

namespace TeamRaiden.Core.Infrastructure.Classes
{
    //Титуляри
    public class Starter : Player
    {
        public Starter(string firstName, string lastName, byte playerNumber, PlayerType playerType) 
            : base(firstName, lastName, playerNumber, playerType)
        {
        }
    }
}
