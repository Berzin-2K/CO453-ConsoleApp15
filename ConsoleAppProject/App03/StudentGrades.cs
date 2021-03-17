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

        public int[] Marks { get; set; }

        public int[] moduleNo { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

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

            Marks = new int[Students.Length];

        }
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark < HighestMark)
            {
                return Grades.A;
            }
            else return Grades.X;
        }

        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach (int marks in Marks)
            {
                if (marks > Maximum) Maximum = marks;
                if (marks > Minimum) Minimum = marks;

                total += marks;
            }

            Mean = total / Marks.Length;
        }
        private void OutputGradeProfile()
        {
            Grades grade = Grades.X;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% count {count}");
                grade++;
            }
            Console.WriteLine();

        }
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;

                OutputGradeProfile();
            }




        }
        public void CalculateMark()

        {
            OutputHeading();

            string[] choices = { " input Marks ", " Output Marks ", "Output stats", "Output Grade profile", "Quit" };

            int choiceNo = ConsoleHelper.SelectChoice(choices);

            if (choiceNo == 1)
                Console.WriteLine("Inputmarks");

            else if (choiceNo == 2)
                Console.WriteLine("output marks");

            else if (choiceNo == 3)
                Console.WriteLine("Output stats");

            else if (choiceNo == 4)
                OutputGradeProfile();

            else if (choiceNo == 5)
                System.Environment.Exit(0);


        }
        public static void OutputHeading()
        {
            Console.WriteLine(" .................................. ");
            Console.WriteLine("Student Grades Calculator");
            Console.WriteLine("By Berzin Daruwala");
            Console.WriteLine(" .................................. ");

        }


        internal void InputMarks(int[] Marks)


        {

        }
    }
}
