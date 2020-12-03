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
            Console.WriteLine("Starting Daily stake :"+ STARTING_DAILY_STAKE);
            Console.WriteLine("Bet :" + BET);
        }
    }
}
