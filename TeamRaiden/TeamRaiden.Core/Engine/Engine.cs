namespace TeamRaiden.Core.Engine
{
    using Infrastructure.Utils;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class Engine
    {
        public static void Start(int numberOfTeams)  ///Whole Euro league => Roundof16 => Grops => Teams => winners=>
                                                    // =>quarter-final => Grops => Teams => winners=>
                                                    // =>semi-final => Grops => Teams => winners=>
                                                    // =>final => Grops => Teams => winners=>
        {
            int numberOfGroups = numberOfTeams / 4;
            for (int i = 0; i < numberOfGroups; i++)
            {
                //DataGenerator.
            }

        }
    }
}
