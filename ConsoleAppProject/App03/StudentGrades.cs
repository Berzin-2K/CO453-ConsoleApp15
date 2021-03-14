using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
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
            throw new NotImplementedException();
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
