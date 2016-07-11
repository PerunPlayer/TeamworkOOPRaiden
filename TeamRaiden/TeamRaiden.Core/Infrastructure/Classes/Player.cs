using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamRaiden.Core.Contracts;
using TeamRaiden.Core.Infrastructure.Enumerations;
using TeamRaiden.Core.Infrastructure.Enumerations.HumanEnumerations;

namespace TeamRaiden.Core.Infrastructure.Classes
{
    public class Player : Participant, IPlayer
    {

        private readonly int playerNumber;
        private int capability;
        private readonly PlayerPositionType playerPosition;
        private PlayerType playerType;

        public int PlayerNumber { get { return this.playerNumber; } }
        public PlayerPositionType PlayerPosition { get { return this.playerPosition; } }
        public PlayerType PlayerType { get { return this.playerType; } set { this.playerType = value; } }
        public int Capability { get { return this.capability; } private set { this.capability = value; } }
        
        public override bool Equals(object obj)
        {
            Player player = obj as Player;
            if (player == null)
            {
                return false;
            }
            if(player.ID != this.ID)
            {
                return false;
            }
            return true;
        }
        public static bool operator ==(Player player1,
                                Player player2)
        {
            return Player.Equals(player1, player2);
        }
        public static bool operator !=(Player player1,
                              Player player2)
        {
            return !(Player.Equals(player1, player2));
        }
        
        public Player(string firstName, string middleName, string lastName, int id, int age, int heigth, int weigth, RaceType raceType, 
            ReligionType religionType, EyeColorType eyeColorType, FaceShapeType faceShape, HairColorType hairColor, BodyShapeType bodyShape,
            int playerNumber, PlayerPositionType playerPosition, PlayerType playerType, int capability)
            : base(firstName, middleName, lastName, id, age, heigth, weigth, raceType, religionType, eyeColorType, faceShape, hairColor, bodyShape)
        {
            this.playerNumber = playerNumber;
            this.playerType = playerType;
            this.playerPosition = playerPosition;
            this.capability = capability;
        }

      //for testing purpose
      public Player(string firstName, string lastName, int age, int capability)
         :base(firstName,lastName,age)
      {
         this.Capability = capability;
      }
    }
}
