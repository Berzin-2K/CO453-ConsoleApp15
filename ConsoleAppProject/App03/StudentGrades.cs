using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {

        //constants (grade boundaries)

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        public string[] Students { get; set; }

        public int[] marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double[] Mean { get; set; }

        public int [] Minimum { get; set; }

        public int [] Maxmimum { get; set; }

        public StudentGrades()
        {
            Students = new string[]
                {
                  "Daniel", "Dylan", "Eric",
                  "Georgia", "Hassan", "Hamza",
                  "Jack", "Liam", "shan",
                  "shamial",
                };
            GradeProfile = new int[(int)Grades.A + 1];

            marks = new int[Students.Length]; 

        }
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else return Grades.D;
        }

        public void CalculateStats()
        {
            throw new NotImplementedException();
        }

        public void CalculateGradeProfile()
        {
            throw new NotImplementedException(); 
        }

    }
}
