using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamRaiden.Core.Infrastructure.Enumerations;

namespace TeamRaiden.Core.Infrastructure.Classes
{
    public abstract class Player
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly uint playerNumber;
        private readonly PlayerType playerType;

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }
        public uint PlayerNumber
        {
            get { return this.playerNumber; }
        }
        public PlayerType PlayerType
        {
            get { return this.playerType; }
        }

        public Player(string firstName, string lastName, uint playerNumber, PlayerType playerType)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.playerNumber = playerNumber;
            this.playerType = playerType;
        }

    }
}
