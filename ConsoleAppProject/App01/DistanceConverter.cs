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
       
        private const double Feet_IN_Metres = 3.28084;

        private const string FEET = "feet";
        private const string METRES = "metres";
        private const string MILES = "miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;


        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }
        /// <summary>
        /// 
        /// </summary>

        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" please select the from distance unit > ");
            toUnit = SelectUnit(" please select the to distance unit > ");

            Console.WriteLine($" Converting {fromUnit} to {toUnit}");


            fromDistance = InputDistance($" please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * Metres_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / Metres_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * Feet_IN_Metres;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / Feet_IN_Metres;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

           string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;

        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
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
        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance}  {fromUnit}" +
                $" is {toDistance}  {toUnit}!");

        }
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine(" Distance Converter ");
            Console.WriteLine(" By Berzin Daruwala ");
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine();

            
        }
       
    }
}
