using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Berzin Daruwala
    /// </author>
    public class BMI
    {
        public const string METRIC = "Metric";
        public const string IMPERIAL = "Imperial";

        public string SelectedUnit;

        public string[] MenuChoices;
        public void SelectUnit()
        {
            Console.WriteLine("Please choose either");
            Console.WriteLine("1. " + METRIC);
            Console.WriteLine("2. " + IMPERIAL);

           
        }
        public string GetUnit()
        {
            SelectedUnit = Console.ReadLine().ToUpper();
            return SelectedUnit;
        }
    }
}