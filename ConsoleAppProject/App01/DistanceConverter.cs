﻿using System;
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
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading();
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMetres()
        {
            OutputHeading();
            InputMiles();
            CalculateMetres();
            OutputMetres();
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
        private void InputFeet()
        {
            Console.Write("You need to input the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }
        private void InputMetres()
        {
            Console.Write("You need to input the number of metres > ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
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
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine(" Feet to miles converter ");
            Console.WriteLine(" By Berzin Daruwala ");
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine();
        }
    }
}
