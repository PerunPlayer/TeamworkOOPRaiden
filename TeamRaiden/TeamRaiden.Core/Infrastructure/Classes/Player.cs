﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamRaiden.Core.Contracts;
using TeamRaiden.Core.Infrastructure.Enumerations;

namespace TeamRaiden.Core.Infrastructure.Classes
{
    public class Player : Participant , IPlayer
    {

        public readonly uint playerNumber;
        public readonly PlayerPositionType playerPosition;
        public readonly PlayerType playerType;

        public uint PlayerNumber
        {
            get { return this.playerNumber; }
        }

        public PlayerPositionType PlayerPosition
        {
            get { return this.playerPosition; }
        }

        public PlayerType PlayerType {
            get { return this.playerType; }
        }



        public Player(string firstName, string lastName, uint playerNumber, PlayerPositionType playerPosition, PlayerType playerType)
            : base(firstName, lastName)
        {
            this.playerNumber = playerNumber;
            this.playerType = playerType;
            this.playerPosition = playerPosition;
        }

        public void SwitchPlayer()
        {
            //throw new NotImplementedException();
        }
    }
}