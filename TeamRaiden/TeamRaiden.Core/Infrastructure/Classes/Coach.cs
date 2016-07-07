using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamRaiden.Core.Contracts;
using TeamRaiden.Core.Infrastructure.Enumerations.HumanEnumerations;

namespace TeamRaiden.Core.Infrastructure.Classes
{
    public class Coach : Participant, IHuman, ICoach
    {
        public Coach(string firstName, string lastName) 
            : base(firstName, lastName)
        {

        }        
    }
}
