namespace TeamRaiden.Core.Contracts
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   interface ICoach: IHuman
   {
        int CoachCapability { get; }
   }
}
