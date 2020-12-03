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
        public const double winResignAmt = 0;
        public const double lossResignAmt = 0;

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling simulator");
            int dayAmount = STARTING_DAILY_STAKE;
            int checkWin = RandomCheck();

            while (checkResign(STARTING_DAILY_STAKE, dayAmount) != 1)
            {
                /// It Checks if returned values is 1 then gambler win 
                /// It not gamber not win
                if (checkWin == 1)
                {
                    dayAmount = dayAmount + BET;
                    Console.WriteLine("Gambler Win");
                }
                else
                {
                    dayAmount = dayAmount - BET;
                    Console.WriteLine("Gambler Loose");
                }
            }
            Console.WriteLine("Starting Daily stake :" + STARTING_DAILY_STAKE);
            Console.WriteLine("Bet :" + BET);
            Console.WriteLine("Bet :" + dayAmount);

        }

        /// <summary>
        /// Randoms the check.
        /// </summary>
        /// <returns></returns>
        public static int RandomCheck()
        {
            /// Create references for Random class
            Random random = new Random();
            /// Returns random value
            return random.Next(0, 1);
        }

        /// <summary>
        /// Checks the resign.
        /// </summary>
        /// <param name="STARTING_DAILY_STAKE">The starting daily stake.</param>
        /// <param name="dayAmount">The day amount.</param>
        /// <returns></returns>
        private static int checkResign(int STARTING_DAILY_STAKE, int dayAmount)
        {
            double winResigmAmt = 0.5f * 0.5f * STARTING_DAILY_STAKE;
            double lossResignAmt = 0.5f * STARTING_DAILY_STAKE;
            if (dayAmount >= winResignAmt || dayAmount <= lossResignAmt)
                return 1;
            else
                return 0;
        }
    }
}
