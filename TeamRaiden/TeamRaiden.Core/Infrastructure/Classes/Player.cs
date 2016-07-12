namespace TeamRaiden.Core.Infrastructure.Classes
{
    using System.Text;
    using TeamRaiden.Core.Contracts;
    using TeamRaiden.Core.Infrastructure.Enumerations;
    using TeamRaiden.Core.Infrastructure.Enumerations.HumanEnumerations;
    public class Player : Participant, IPlayer
    {

        private int playerNumber;
        private int capability;
        private PlayerPositionType playerPosition;
        private PlayerType playerType;

        public override bool Equals(object obj)
        {
            Player player = obj as Player;
            if (player == null)
            {
                return false;
            }
            if (player.ID != this.ID)
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

        public Player(string firstName, string lastName, int id, int age, int heigth, int weigth, RaceType raceType,
            ReligionType religionType, EyeColorType eyeColorType, FaceShapeType faceShape, HairColorType hairColor, BodyShapeType bodyShape,
            int playerNumber, PlayerPositionType playerPosition, PlayerType playerType, int capability)
            : base(firstName, lastName, id, age, heigth, weigth, raceType, religionType, eyeColorType, faceShape, hairColor, bodyShape)
        {
            this.PlayerNumber = playerNumber;
            this.PlayerType = playerType;
            this.PlayerPosition = playerPosition;
            this.Capability = capability;
        }

        //for testing purpose
        public Player(string firstName, string lastName, int age, int capability)
           : base(firstName, lastName, age)
        {
            this.Capability = capability;
        }
        public override string ToString()
        {
            string firstLine = "PLAYER:";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(firstLine);
            sb.Append(base.ToString());
            sb.AppendLine(string.Format("Player capability: {0}", this.Capability));
            sb.AppendLine(string.Format("Player number in team: {0}", this.PlayerNumber));
            sb.AppendLine(string.Format("Position: {0}", this.PlayerPosition));
            sb.AppendLine(string.Format("Player type: {0}", this.PlayerType));

            return sb.ToString();
        }

        public int PlayerNumber
        {
            get
            {
                return this.playerNumber;
            }
            private set
            {
                this.playerNumber = value;
            }
        }
        public PlayerPositionType PlayerPosition
        {
            get
            {
                return this.playerPosition;
            }
            private set
            {
                this.playerPosition = value;
            }
        }
        public PlayerType PlayerType
        {
            get
            {
                return this.playerType;
            }
            set
            {
                this.playerType = value;
            }
        }
        public int Capability
        {
            get
            {
                return this.capability;
            }
            private set
            {
                this.capability = value;
            }
        }
    }
}
