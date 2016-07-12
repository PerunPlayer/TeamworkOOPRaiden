namespace TeamRaiden.Core.Infrastructure.Classes
{
    using System.Text;
    using TeamRaiden.Core.Contracts;
    using TeamRaiden.Core.Infrastructure.Enumerations.HumanEnumerations;

    public class Coach : Participant, IHuman, ICoach
    {
        private int coachCapability;
     
        public Coach(string firstName, string lastName, int id, int age, int heigth, int weigth,
            RaceType raceType, ReligionType religionType, EyeColorType eyeColorType,
            FaceShapeType faceShape, HairColorType hairColor, BodyShapeType bodyShape, int coachCapability)
            : base(firstName, lastName, id, age, heigth, weigth, raceType, religionType, eyeColorType, faceShape, hairColor, bodyShape)
        {
            this.CoachCapability = coachCapability;
        }
        public Coach(string firstName, string lastName, int age, int capability) : base(firstName, lastName, age)
        {
            this.CoachCapability = capability;
        }
        public override string ToString()
        {
            string firstLine = "COACH:";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(firstLine);
            sb.Append(base.ToString());
            sb.AppendLine(string.Format("Coach capability: {0}", this.CoachCapability));
            return sb.ToString();
        }
        public int CoachCapability
        {
            get
            {
                return this.coachCapability;
            }
            private set
            {
                this.coachCapability = value;
            }
        }
    }
}
