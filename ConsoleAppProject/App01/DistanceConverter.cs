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
        private const int FEET_IN_MILES = 5280;

        private const double Metres_IN_MILES = 1609.34;

        private double miles;
        
        private double feet;

        private double metres;

        /// <summary>
        /// 
        /// </summary>

        public void MilesToFeet()
        {
            OutputHeading1();
            miles = InputDistance("please enter the number of miles > ");
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading2();
            feet = InputDistance("please enter the number of feet > ");
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMetres()
        {
            OutputHeading3();
            miles = InputDistance("please enter the number of miles > ");
            CalculateMetres();
            OutputMetres();
        }

        /// <summary>
        /// prompt user to enter the distance in miles 
        /// inputs miles as a double number
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
           return Convert.ToDouble(value);

        }
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }
        private void CalculateMetres()
        {
            metres = miles * Metres_IN_MILES;
        }
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! ");

        }
        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles! ");
        }
        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres! ");
        }
        private void OutputHeading1()
        {
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine(" Feet to Miles converter ");
            Console.WriteLine(" By Berzin Daruwala ");
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine();
        }
        private void OutputHeading2()
        {
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine(" Miles to Feet converter ");
            Console.WriteLine(" By Berzin Daruwala ");
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine();
        }
        private void OutputHeading3()
        {
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine(" Miles to Metres converter ");
            Console.WriteLine(" By Berzin Daruwala ");
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine();
        }
    }
}
