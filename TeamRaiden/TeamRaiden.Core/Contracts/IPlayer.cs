using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamRaiden.Core.Contracts
{
    interface IPlayer : IHuman
    {
        int Capability { get; }
        int PlayerNumber { get; }
    }
}
