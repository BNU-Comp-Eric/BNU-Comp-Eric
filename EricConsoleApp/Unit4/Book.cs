using System;
using System.Collections.Generic;
using System.Text;

namespace EricConsoleApp.Unit4
{
    /// <summary>
    /// This class will write out a two chapter 
    /// story for the user 
    /// 
    /// For Tasks 4.2 and 4.3 
    /// 
    /// Author      : Dr Derek Peacock
    /// Modified by : Eric Man
    /// </summary>
    class Book
    {
        // Attributes of Book

        private string author, name, town;
        private string animal, weapon, job;

        public Book()
        {
            author = SimpleIO.AUTHOR;
            
        }

        /// <summary>
        /// Prompt the user for an answer as a string and return it
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns>answer</returns>
        public string GetString(string prompt)
        {
            string answer;
            Console.Write(prompt);
            answer = Console.ReadLine();
            return answer;
        }

        /// <summary>
        /// Get the details of the author, name, town, animal
        /// job and weapon used in the books stories
        /// </summary>
        public void GetDetails() // keep using ask() to get information
        {
            author = SimpleIO.AUTHOR;
            name = GetString("Please type a friend's name : ");
            town = GetString("Now give me the name of a town : ");
            animal = GetString("Now a type of animal : ");
            job = GetString("Now a type of job : ");
            weapon = GetString("And your weapon of choice : ");

            
        }

        /// <summary>
        /// This method creates a the first chapter of a story using 
        /// all the attributes of the class
        /// </summary>
        public void WriteChapter1()
        {
            Console.Clear();

            Console.WriteLine("A Horror Story : by " + author);
            Console.WriteLine("===============================");

            Console.WriteLine("It was a dark night in " + town + " and " + name
                + " could hear " + animal + "s screaming in the distance.");

            Console.WriteLine(name + " staggered terrified through the streets of "
                + town + ", realising he had been followed.");

            Console.WriteLine("In the shadow of a doorway, a demented " + job
                + " waited, clutching a menacing " + weapon);
        }
        public void WriteChapter2()
        {
            Console.WriteLine("The " + job + " hit him with the " + weapon);
        }
    }
}

