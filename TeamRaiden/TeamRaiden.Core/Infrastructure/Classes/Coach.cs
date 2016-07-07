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
        private int coachCapability;
        public int CoachCapability { get { return this.coachCapability; } }

        public Coach(string firstName, string middleName, string lastName, int id, int age, int heigth, int weigth,
            RaceType raceType, ReligionType religionType, EyeColorType eyeColorType,
            FaceShapeType faceShape, HairColorType hairColor, BodyShapeType bodyShape, int coachCapability)
            : base(firstName, middleName, lastName, id, age, heigth, weigth, raceType, religionType, eyeColorType, faceShape, hairColor, bodyShape)
        {
            this.coachCapability = coachCapability;
        }


    }
}
