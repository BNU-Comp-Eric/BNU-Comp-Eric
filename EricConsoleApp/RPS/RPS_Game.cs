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
    /// This class plays the game
    /// Author: Derek
    /// Started: 12/02/2019
    /// Modified : 26/02/2020
    /// </summary>
    public class RPS_Game
    {
        public const string COMPUTER_NAME = "Computer";

        public int ComputerScore { get; set; }
        public int PlayerScore { get; set; }
        public string PlayerName { get; set; }

        public string WinnerName { get; set; }

        public RPS_Choices ComputerChoice { get; set; }
        public RPS_Choices PlayerChoice { get; set; }

        private Random randomGenerator = new Random(123);

      
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
                ComputerChoice = RPS_Choices.ROCK;
            }
            else if (choice == 1)
            {
                ComputerChoice = RPS_Choices.PAPER;
            }
            else if (choice == 2)
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
        /// This method will determine whether the computer
        /// has won, or the player has won, or it is a draw.
        /// *******************************************************
        /// </summary>
        public void WorkoutWinner()
        {
           if (PlayerChoice == RPS_Choices.ROCK && ComputerChoice == RPS_Choices.SCISSORS)
            {
                WinnerName = PlayerName;
                PlayerScore = PlayerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.PAPER && ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = PlayerName;
                PlayerScore = PlayerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.SCISSORS && ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = PlayerName;
                PlayerScore = PlayerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.PAPER && ComputerChoice == RPS_Choices.SCISSORS)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore = ComputerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.ROCK && ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore = ComputerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.SCISSORS && ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore = ComputerScore + 2;
            }
            else 
            {
                WinnerName = "You have Drawn!!!";
                ComputerScore++;
                PlayerScore++;
            }
        }
    }
}