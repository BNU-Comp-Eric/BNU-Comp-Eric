using System;
using System.Collections.Generic;
using System.Text;

namespace EricConsoleApp.Unit5
{
    public class Tournament
    {
        const int MAXN_SCORES = 6;

        // Another way of initialising attributes
        private int[] scores = new int[MAXN_SCORES];

        private string[] names;

        /// <summary>
        /// Class Constructor (not needed)
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

        public void GetScores()
        {
            SimpleIO.WriteTitle("Enter Tournament Scores", "Task 5.1");

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.Write("Enter score for player " + (i + 1) + " > ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }


        public void ShowScores()
        {
            SimpleIO.WriteTitle("Show Tournament Scores", "Task 5.1");

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.WriteLine("Player " + (i + 1) + " scored " + scores[i]);
            }
        }
    }
}
