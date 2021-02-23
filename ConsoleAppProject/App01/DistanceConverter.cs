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
            OutputHeading($"Converting {fromUnit} to {toUnit}");
            fromDistance = InputDistance($"please enter the number of {fromUnit} > ");
            
            //CalculateFeet();
            OutputDistance();
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
        private void OutputHeading(string Prompt)
        {
            Console.WriteLine();
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine(" Distance Converter ");
            Console.WriteLine(" By Berzin Daruwala ");
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine();

            Console.WriteLine(Prompt);
            Console.WriteLine();
        }
       
    }
}
