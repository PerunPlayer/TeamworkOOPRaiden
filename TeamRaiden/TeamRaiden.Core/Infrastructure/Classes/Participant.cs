﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamRaiden.Core.Contracts;
using TeamRaiden.Core.Infrastructure.Enumerations.HumanEnumerations;

namespace TeamRaiden.Core.Infrastructure.Classes
{
    public abstract class Participant : IHuman
    {
        private readonly string firstName;
        private readonly string middleName;
        private readonly string lastName;
        private readonly int iD;
        private readonly int age;
        private readonly int weigth;
        private readonly int heigth;
        private readonly RaceType raceType;
        private readonly ReligionType religionType;
        private readonly EyeColorType eyeColor;
        private readonly FaceShapeType faceShape;
        private readonly HairColorType hairColor;
        private readonly BodyShapeType bodyShape;

        public string FirstName { get { return this.firstName; } }
        public string MiddleName { get { return this.middleName; } }
        public string LastName { get { return this.lastName; } }
        public int ID { get { return this.iD; } }
        public int Age { get { return this.age; } }
        public int Heigth { get { return this.heigth; } }
        public int Weight { get { return this.weigth; } }
        public RaceType RaceType { get { return this.raceType; } }
        public ReligionType Religion { get { return this.religionType; } }
        public EyeColorType EyeType { get { return this.eyeColor; } }
        public FaceShapeType FaceShape { get { return this.faceShape; } }
        public HairColorType HairColor { get { return this.hairColor; } }
        public BodyShapeType BodyShape { get { return this.bodyShape; } }


        public Participant(string firstName, string middleName, string lastName, int id, int age,int heigth, int weigth, 
            RaceType raceType,ReligionType religionType, EyeColorType eyeColorType, 
            FaceShapeType faceShape, HairColorType hairColor, BodyShapeType bodyShape)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.iD = id;
            this.weigth = weigth;
            this.heigth = heigth;
            this.raceType = raceType;
            this.religionType = religionType;
            this.eyeColor = eyeColorType;
            this.faceShape = faceShape;
            this.hairColor = hairColor;
            this.bodyShape = bodyShape;
        }
        
    }
}
