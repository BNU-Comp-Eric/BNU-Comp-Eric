using System;
using System.Collections.Generic;
using System.Text;

namespace EricConsoleApp.Unit5
{
    /// <summary>
    /// Task 5.1 and Task 5.3
    /// This class gets and displays an array of tournament scores for 
    /// an array of players (names)
    /// 
    /// Author : Derek Peacock
    /// Modified by : Eric Man
    /// </summary>
    public class Tournament
    {
        public const int MAXN_SCORES = 9;
        private int[] scores;

        private string[] names;

        /// <summary>
        /// Class Constructor 
        /// </summary>
        public Tournament()
        {
            scores = new int[MAXN_SCORES];
            names = new string[]
            {
                "Godfrey",
                "Eric",
                "Georgia",
                "Dylan",
                "Oluyemi",
                "Shamial",
                "Numan",
                "Liam",
                "Gita"
            };
        }
        /// <summary>
        /// This method will ask the user to 
        /// enter a score for each player 
        /// </summary>
        public void GetScores()
        {
            SimpleIO.WriteTitle("Enter Tournament Scores", "Task 5.1");

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.Write("Enter score for player " + (i + 1) + " > ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        /// <summary>
        /// This method will ask the user
        /// for the names of players and 
        /// their scores
        /// </summary>
        public void GetDetails()
        {
            SimpleIO.WriteTitle("Enter Tournament Scores", "Task 5.1");

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.Write("Enter player name " + (i + 1) + "> ");
                names[i] = Console.ReadLine();

                Console.Write("Enter score for player " + (i + 1) + " > ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        /// <summary>
        /// This method will show the players' scores
        /// </summary>
        public void ShowScores()
        {
            SimpleIO.WriteTitle("Show Tournament Scores", "Task 5.1");

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.WriteLine("Player " + (i + 1) + " scored " + scores[i]);
            }
        }

        /// <summary>
        /// This method will show the names
        /// of players and their scores
        /// </summary>
        public void ShowDetails()
        {
            SimpleIO.WriteTitle("Show Tournament Scores", "Task 5.1");

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.WriteLine("Player " + names[1] + " scored " + scores[i]);
            }
        }
    }
}
