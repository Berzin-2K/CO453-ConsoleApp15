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
        public const string METRIC = "METRIC";
        public const string IMPERIAL = "IMPERIAL";

        public double weight;
        public double height;

        public string SelectedUnit;

        public double bmiResult;

        public string[] MenuChoices = { METRIC, IMPERIAL};
        public void OutpuUnits()
        {
            ConsoleHelper.OutputMenu(MenuChoices);

           
        }
        public string GetUnit()
        {
            SelectedUnit = Console.ReadLine().ToUpper();
            return SelectedUnit;
        }

        public double GetWeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("please enter the weight in KGs:");
            }
            else
            {
                Console.WriteLine("please enter the weight in Stones");
                Console.WriteLine("please enter the weight in Pounds");
            }
            weight = Convert.ToDouble(Console.ReadLine());
            return weight;
        }
        public double GetHeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("please enter the height in CMs:");
            }
            else
            {
                Console.WriteLine("please enter the height in Feet:");
                Console.WriteLine("please enter the height in Inches:");
            }
            height = Convert.ToDouble(Console.ReadLine());
            return height;
        }
        public void CalculateBMI()
        {
            if (SelectedUnit == METRIC)
            {
                bmiResult = (weight / height / height) * 10000;
            }
        }


            public void OutputResult()
        {
            Console.WriteLine(SelectedUnit + " " + bmiResult);
        }
    }
}