using System;
using System.Collections.Generic;
using System.Text;

namespace EricConsoleApp.RPSGame
{

    public enum RPS_Players
    {
        NONE,
        COMPUTER,
        PLAYER
    }

    public enum RPS_Choices
    {
        UNKOWN,
        ROCK,
        PAPER,
        SCISSORS,
    }

    /// <summary>
    /// This class plays ...
    /// Author: Derek
    /// Started: 12/02/2019
    /// Modified : 26/02/2020
    /// </summary>
    public class RPS_Game
    {
        public const string COMPUTER_NAME = "Computer";

        public string PlayerName { get; set; }
        //public string ComputerName { get; set; }
        public string WinnerName { get; set; }

        public RPS_Choices ComputerChoice { get; set; }
        public RPS_Choices PlayerChoice { get; set; }

        private Random randomGenerator = new Random();

        public void Start(string player)
        {
            PlayerName = player;
            WinnerName = "Unkown";
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void End()
        {
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);

            if (choice == 0)
            {
                ComputerChoice = RPS_Choices.SCISSORS;
            }
            else
            {
                ComputerChoice = RPS_Choices.UNKOWN;
            }
        }


        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void WorkoutWinner()
        {
            if (PlayerChoice == ComputerChoice)
            {
                WinnerName = "You have Drawn!!!";
            }
            else
            {
                WinnerName = "Not Yet Determined!!!";
            }

        }
    }
}