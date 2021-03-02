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

        private const double Feet_IN_Metres = 3.28084;

        public const string FEET = "feet";
        public const string METRES = "metres";
        public const string MILES = "miles";

        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public string FromUnit { get; set; }
        public string ToUnit { get; set; }


        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }
        /// <summary>
        /// 
        /// </summary>

        public void ConvertDistance()
        {
            OutputHeading();

            FromUnit = SelectUnit(" please select the from distance unit > ");
            ToUnit = SelectUnit(" please select the to distance unit > ");

            Console.WriteLine($" Converting {FromUnit} to {ToUnit}");


            FromDistance = InputDistance($" please enter the number of {FromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        public void CalculateDistance()
        {
            
            if (FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == METRES)
            {
                ToDistance = FromDistance * Metres_IN_MILES;
            }
            else if (FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = FromDistance / Metres_IN_MILES;
            }
            else if (FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = FromDistance * Feet_IN_Metres;
            }
            else if (FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = FromDistance / Feet_IN_Metres;
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
            else Console.Write("Invalid choice");

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
        /// 
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
           return Convert.ToDouble(value);

        }
        private void OutputDistance()
        {
            Console.WriteLine($" {FromDistance}  {FromUnit}" +
                $" is {ToDistance}  {ToUnit}!");

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
