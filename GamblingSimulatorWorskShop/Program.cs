using System;

namespace GamblingSimulatorWorskShop
{
    public class Program
    {
        /// <summary>
        /// UC1
        /// constants
        /// </summary>
        public const int STARTING_DAILY_STAKE = 100;
        public const int BET = 1;
        public const int DAYS = 20;

        /// variales
        public static int totalWin = 0;
        public static int totalLoss = 0;

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling simulator");
            int dayAmount = STARTING_DAILY_STAKE;
            int checkWin = RandomCheck();

            /// UC4
            for (int i=0; i < DAYS; i++)
            {
                int dailyWin = 0;
                int dailyLoss = 0;
                while (checkResign(STARTING_DAILY_STAKE, dayAmount) != 1)
                {
                    /// It Checks if returned values is 1 then gambler win 
                    /// It not gamber not win
                    if (checkWin == 1)
                    {
                        dayAmount +=BET;
                        dailyWin +=BET;
                    }
                    else
                    {
                        dayAmount -=BET;
                        dailyLoss += BET;
                    }
                }
                totalWin += dailyWin;
                totalLoss += dailyLoss;
            }

            Console.WriteLine("Starting Daily stake :" + STARTING_DAILY_STAKE);
            Console.WriteLine("Bet :" + BET);
            Console.WriteLine("Total win :" + totalWin);
            Console.WriteLine("Total loss :" + totalLoss);

        }

        /// <summary>
        /// UC2
        /// Randoms the check.
        /// </summary>
        /// <returns></returns>
        public static int RandomCheck()
        {
            /// Create references for Random class
            Random random = new Random();
            /// Returns random value
            return random.Next(0, 2);
        }

        /// <summary>
        /// UC3
        /// Checks the resign.
        /// </summary>
        /// <param name="STARTING_DAILY_STAKE">The starting daily stake.</param>
        /// <param name="dayAmount">The day amount.</param>
        /// <returns></returns>
        private static int checkResign(int STARTING_DAILY_STAKE, int dayAmount)
        {
            double winResigmAmt = 1.5 * STARTING_DAILY_STAKE;
            double lossResignAmt = 0.5 * STARTING_DAILY_STAKE;
            if (dayAmount >= winResigmAmt || dayAmount <= lossResignAmt)
                return 1;
            else
                return 0;
        }
    }
}
