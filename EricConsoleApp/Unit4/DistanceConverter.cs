using System;
using System.Collections.Generic;
using System.Text;

namespace EricConsoleApp.Unit4
{
    /// <summary>
    /// This class will convert miles to whole feet, or feet to miles
    ///  Author: Eric Man
    ///  Student ID: 21815369
    ///   </summary>
    class DistanceConverter
    {
        /// <summary>
        /// This method will take a number
        /// of feet and convert them to miles
        /// </summary>
        /// <returns></returns>
        public double ToFeet(double miles)
        {
            return miles * 1760.00 * 3;
        }

        /// <summary>
        /// This method will take a number of miles
        /// and convert them to feet
        /// </summary>
        /// <returns></returns>
        public double ToMiles(double feet)
        {
            return feet / (1760.00 * 3);
        }

        /// <summary>
        /// This method will prompt the user to enter the 
        /// number of feet or miles that they want to convert
        /// </summary>
        public double GetDouble(string prompt)
        {
            Console.WriteLine("Please enter the number of " + prompt);

            string input = Console.ReadLine();
            double number = Convert.ToDouble(input);

            return number;
        }
    }
}
