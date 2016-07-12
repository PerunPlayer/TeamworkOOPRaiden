namespace TeamRaiden.Core.Infrastructure.Classes
{
    using System.Text;
    using TeamRaiden.Core.Contracts;
    using TeamRaiden.Core.Infrastructure.Enumerations.HumanEnumerations;

    public abstract class Participant : IHuman
    {
        private string firstName;
        private string lastName;
        private int iD;
        private int age;
        private int weigth;
        private int heigth;
        private RaceType raceType;
        private ReligionType religionType;
        private EyeColorType eyeColor;
        private FaceShapeType faceShape;
        private HairColorType hairColor;
        private BodyShapeType bodyShape;

        public Participant(string firstName, string lastName, int id, int age, int heigth, int weigth,
            RaceType raceType, ReligionType religionType, EyeColorType eyeColorType,
            FaceShapeType faceShape, HairColorType hairColor, BodyShapeType bodyShape)
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = id;
            this.Weight = weigth;
            this.Heigth = heigth;
            this.RaceType = raceType;
            this.Religion = religionType;
            this.EyeType = eyeColorType;
            this.FaceShape = faceShape;
            this.HairColor = hairColor;
            this.BodyShape = bodyShape;
        }
        public Participant(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("ID: {0}", this.ID));
            sb.AppendLine(string.Format("First name: {0}", this.FirstName));
            sb.AppendLine(string.Format("Last name: {0}", this.LastName));
            sb.AppendLine(string.Format("Age: {0}", this.Age));
            sb.AppendLine(string.Format("Height: {0}", this.Heigth));
            sb.AppendLine(string.Format("Weight: {0}", this.Weight));
            sb.AppendLine(string.Format("Race: {0}", this.RaceType));
            sb.AppendLine(string.Format("Religion: {0}", this.Religion));
            sb.AppendLine(string.Format("Color of eyes: {0}", this.EyeType));
            sb.AppendLine(string.Format("Face shape: {0}", this.FaceShape));
            sb.AppendLine(string.Format("Hair color: {0}", this.HairColor));
            sb.AppendLine(string.Format("Body shape: {0}", this.BodyShape));
            return sb.ToString();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.lastName = value;
            }
        }
        public int ID
        {
            get
            {
                return this.iD;
            }
            private set
            {
                this.iD = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }
        public int Heigth
        {
            get
            {
                return this.heigth;
            }
            private set
            {
                this.heigth = value;
            }
        }
        public int Weight
        {
            get
            {
                return this.weigth;
            }
            private set
            {
                this.weigth = value;
            }
        }
        public RaceType RaceType
        {
            get
            {
                return this.raceType;
            }
            private set
            {
                this.raceType = value;
            }
        }
        public ReligionType Religion
        {
            get
            {
                return this.religionType;
            }
            private set
            {
                this.religionType = value;
            }
        }
        public EyeColorType EyeType
        {
            get
            {
                return this.eyeColor;
            }
            private set
            {
                this.eyeColor = value;
            }
        }
        public FaceShapeType FaceShape
        {
            get
            {
                return this.faceShape;
            }
            private set
            {
                this.faceShape = value;
            }
        }
        public HairColorType HairColor
        {
            get
            {
                return this.hairColor;
            }
            private set
            {
                this.hairColor = value;
            }
        }
        public BodyShapeType BodyShape
        {
            get
            {
                return this.bodyShape;
            }
            private set
            {
                this.bodyShape = value;
            }
        }
    }
}
