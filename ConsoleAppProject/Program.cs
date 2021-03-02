using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Berzin Daruwala 14/02/2021
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            ConsoleHelper.OutputHeading("\tBMI Calculator\n\t By Berzin Daruwala ");
            ConsoleHelper.OutputIntroduction(" Note - if you are Black, Asian or an ethnic minority you have a much higher risk" +
                 " Adults 23.0 or more are at risk, " +
                 " as well as adults at 27.00 or more ");


            BMI calculator = new BMI();
            calculator.OutpuUnits();
            calculator.GetUnit();
            calculator.GetWeight();
            calculator.GetHeight();
            calculator.CalculateBMI();
            calculator.OutputResult();

        }
    }
}
