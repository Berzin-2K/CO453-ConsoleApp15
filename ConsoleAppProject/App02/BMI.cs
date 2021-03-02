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
                Console.WriteLine(" You have chosen metric - please enter the weight in KGs:");
            }
            else
            {
                Console.WriteLine("please enter the weight in Stones");
            }
            if (SelectedUnit == IMPERIAL)
            {
                Console.WriteLine(" You have chosen Imperial - Please enter weight In pounds");
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
            
            if (SelectedUnit == IMPERIAL)
            {
                Console.WriteLine("please enter the height in  Inches");
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
            else if (SelectedUnit == IMPERIAL)
            {
                bmiResult = (weight / height / height) * 703;
            }
        }


            public void OutputResult()
        {
            Console.WriteLine(SelectedUnit + " " + bmiResult);
        }
    }
}