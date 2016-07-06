using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamRaiden.Core.Infrastructure.Classes
{
    public abstract class Participant
    {
        private readonly string firstName;
        private readonly string lastName;

        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }

        public Participant(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


    }
}
