using System;
using System.Collections.Generic;
using System.Text;

namespace EricConsoleApp.Unit4
{
    /// <summary>
    /// This class will calculate the BMI
    /// of the user
    /// Author: Eric Man
    /// </summary>
    class BMI
    {
       
        private double kg, height;
        public double GetDetails(string prompt)
        {
            kg = SimpleIO.GetDouble("Please enter your weight");
            height = SimpleIO.GetDouble("Please enter your height");
            return;
        }

    }
}
