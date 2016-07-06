using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamRaiden.Core.Infrastructure.Enumerations;

namespace TeamRaiden.Core.Infrastructure.Classes
{
    //Резерви
    public class Substitute : Player
    {
        public Substitute(string firstName, string lastName, byte playerNumber, PlayerType playerType) 
            : base(firstName, lastName, playerNumber, playerType)
        {
        }
    }
}
