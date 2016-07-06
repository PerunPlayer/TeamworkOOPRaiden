namespace TeamRaiden.Core.Contracts.Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamRaiden.Core.Infrastructure.Enumerations.HumanEnumerations;
    interface IHuman
    {
        int Age { get; }
        string FirstNAme { get; }
        string MiddleName { get; }
        string LastNAme { get; }
        RaceType RaceTypeType { get; }
        ReligionType Religion { get; }
        int Heigth { get; }
        int Weight { get; }
        EyeColor EyeType { get; }
        FaceShape FaceSgapeType { get; }
        HairColor HairColorType { get; }
        BodyShape BodyShapeType { get; }
    }
}
