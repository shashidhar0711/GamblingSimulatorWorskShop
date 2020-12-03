using System;

namespace GamblingSimulatorWorskShop
{
    public class Program
    {
        /// <summary>
        /// constants
        /// </summary>
        public const int STARTING_DAILY_STAKE = 100;
        public const int BET = 1;

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling simulator");

            int checkWin = RandomCheck();
            /// It Checks if returned values is 1 then gambler win 
            /// It not gamber not win
            if(checkWin == 1)
            {
                Console.WriteLine("Gambler Win");
            }
            else
            {
                Console.WriteLine("Gambler Loose");
            }
            Console.WriteLine("Starting Daily stake :" + STARTING_DAILY_STAKE);
            Console.WriteLine("Bet :" + BET);
        }
        public static int RandomCheck()
        {
            /// Create references for Random class
            Random random = new Random();
            /// Returns random value
            return random.Next(0, 1);
        }
    }
}
