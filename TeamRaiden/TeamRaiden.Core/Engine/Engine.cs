namespace TeamRaiden.Core.Engine
{
    using Infrastructure.Utils;
    using System;
    public static class Engine
    {
        public static void Start(int numberOfTeams)
        {
            
            //Console.WriteLine(DataGenerator.GenerateCoach().ToString());
            //Console.WriteLine(DataGenerator.GenerateCoach().ToString());
            //Console.WriteLine(DataGenerator.GeneratePlayer().ToString());
            //Console.WriteLine(DataGenerator.GeneratePlayer().ToString());
            Console.WriteLine(DataGenerator.GenerateTeam().ToString());
            int numberOfGroups = numberOfTeams / 4;

            for (int i = 0; i < numberOfGroups; i++)
            {
                DataGenerator.GenerateGroup();
            }

        }
    }
}
