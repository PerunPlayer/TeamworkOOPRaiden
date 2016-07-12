namespace TeamRaiden.Core.Engine
{
    using Contracts.Team;
    using Infrastructure.Classes;
    using Infrastructure.Utils;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public static class Engine
    {
        public static void Start(int numberOfTeams)
        {
            //Console.WriteLine(DataGenerator.GenerateCoach().ToString());
            //Console.WriteLine(DataGenerator.GeneratePlayer().ToString());          
            //Console.WriteLine(DataGenerator.GenerateTeam().ToString());

            int numberOfGroups = numberOfTeams / 4;
            IList<Group> groupfInLeague = new List<Group>();

            for (int i = 0; i < numberOfGroups; i++)
            {

                groupfInLeague.Add(DataGenerator.GenerateGroup());
            }

            var winnersOfTheGroup = groupfInLeague[0].GroupWinners();
            var nextGroup = new Group(winnersOfTheGroup as IList<ITeam>, Infrastructure.Enumerations.GroupName.A);
            var winner = nextGroup.GroupWinners();

            foreach (var item in winner)
            {
                Console.WriteLine(item.ToString());
            }
            
        }
    }
}
