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
        private double height;

        private double weight;

        public void converter()
        {
            OutputHeader();
            doubleBMIIndex = 0;
            int Unit = GetUnits();
            if (Unit == 1) BMIIndex = convertMetricBMI();
            else if (Unit == 2) BMIIndex = ConvertMetricBMI();
            else Console.WriteLine(" Invalid - you must choose either the Imperial or Metric unit option ");
            Console.WriteLine(" If you are Black, Asian or other minority ethnic groups, you have a higher risk ");
            
    

        }
        public void OutputHeader()
        {
            Console.WriteLine();
            Console.WriteLine("........................................");
            Console.WriteLine(" BMI Calculator ");
            Console.WriteLine(" By Berzin Daruwala ");
            Console.WriteLine("........................................");
            Console.WriteLine();
        }
        private int GetUnits()
        {
            int unit = 0;
            string value = Console.ReadLine();
            if (string.Equals(value, "metric")) unit = 1;
            else if (string.Equals(value, "imperial")) unit = 2;
            return unit;
        }

    }
}