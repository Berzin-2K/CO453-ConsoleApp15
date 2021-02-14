using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;

        private double feet; 

        /// <summary>
        /// 
        /// </summary>
        public void run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// prompt user to enter the distance in miles 
        /// inputs miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("You need to input the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);

        }
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }
        private void OutputFeet()
        {
            Console.WriteLine(miles + "miles is " + feet + "feet!");

        }

    }
}
