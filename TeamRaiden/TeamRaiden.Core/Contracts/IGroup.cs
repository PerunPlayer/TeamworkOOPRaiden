namespace TeamRaiden.Core.Contracts.Group
{
    using Infrastructure.Enumerations;
    using Infrastructure.Structs;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Team;
   public interface IGroup
   {
      IList<ITeam> Teams { get; }
      GroupName GroupName { get; }
   }
}
