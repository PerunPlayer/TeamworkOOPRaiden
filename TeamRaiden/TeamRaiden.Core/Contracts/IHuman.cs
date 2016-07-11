namespace TeamRaiden.Core.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamRaiden.Core.Infrastructure.Enumerations.HumanEnumerations;
    public interface IHuman
    {      
        string FirstName { get; }        
        string LastName { get; }
        int ID { get; }
        int Age { get; }
        int Heigth { get; }
        int Weight { get; }
        RaceType RaceType { get; }
        ReligionType Religion { get; }        
        EyeColorType EyeType { get; }
        FaceShapeType FaceShape { get; }
        HairColorType HairColor { get; }
        BodyShapeType BodyShape { get; }       
    }
}
