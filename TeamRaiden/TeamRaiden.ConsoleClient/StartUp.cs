namespace TeamRaiden.ConsoleClient
{
    using Core.Engine;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static object DataGenerator { get; private set; }

        static void Main()
        {
            Console.WriteLine("Please,\r\nENTER A NAME OF YOUR LEAGUE:\r\n(Should consists of letters and/or digits and should be between 2 and 100 symbols long!)");
            string nameOfLeague = Console.ReadLine();
            try
            {
                if ((string.IsNullOrEmpty(nameOfLeague) || nameOfLeague.All(Char.IsLetterOrDigit)) && (nameOfLeague.Length >= 2 && nameOfLeague.Length <= 100))
                {
                    Console.WriteLine("ACCEPTED =)");
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Sorry, \r\nYou entered invalid league name! ");

            }

            Console.WriteLine("Please,\r\nENTER THE NUMNER OF ALL TEAMS IN THE LEAGUE:\r\n(ATTENTION: The number should be divisible by 4 and should be a power of 2!)");
            int numberOfTeams = int.Parse(Console.ReadLine());

            try
            {
                if (numberOfTeams > 0 && numberOfTeams % 4 == 0 && IsPowerOfTwo(numberOfTeams))
                {
                    Console.WriteLine("OK, Lets PLAY!");
                    Engine.Start(numberOfTeams);
                    
                }
                else
                {
                    throw new ArgumentException("The number of all teams in the league should be divisible by 4 and should be a power of 2!");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The number of all teams in the league should be divisible by 4 and should be a power of 2!");

            }
        }
        public static bool IsPowerOfTwo(int x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }

    }
}

