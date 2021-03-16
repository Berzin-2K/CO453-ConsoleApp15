using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleAppProjects.test
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades
            studentGrades = new StudentGrades();

        private readonly int[] StatsMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };

        private int[] testmarks;

        public TestStudentGrades()
        {
            testmarks = new int[]
                {
                    10, 20, 30, 40, 50, 60, 70, 80, 90, 100
                };
        }

        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            //Arrange

            Grades expectedGrade = Grades.F;

            //Act

            Grades actualGrade = studentGrades.ConvertToGrade(0);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);

        }
        [TestMethod]
        public void TestConvert39ToGradeF()
        {
            //Arrange

            Grades expectedGrade = Grades.F;

            //Act

            Grades actualGrade = studentGrades.ConvertToGrade(39);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]

        public void TestCalculateMean()
        {
            studentGrades.Marks = testmarks;
            double expectedMean = 55.0;
            studentGrades.CalculateStats();

            Assert.AreEqual(expectedMean, studentGrades.Mean);
        }

        [TestMethod]
        public void TestCalculateMin()
        {
            //arrange
            studentGrades.Marks = StatsMarks;
            int expectedmin = 10;

            //act
            studentGrades.CalculateStats();

            Assert.AreEqual(expectedmin, studentGrades.Minimum);
        }
        [TestMethod]
        public void TestCalculateMax()
        {
            //arrange
            studentGrades.Marks = StatsMarks;
            int expectedmax = 100;

            //act
            studentGrades.CalculateStats();

            Assert.AreEqual(expectedmax, studentGrades.Maximum);
        }
    

        [TestMethod]
        public void TestGradeProfile()
        {
            //arrange
            studentGrades.Marks = StatsMarks;
            bool expectedProfile = false;

            //act
            studentGrades.CalculateGradeProfile();

            expectedProfile = ((studentGrades.GradeProfile[0] ==3) &&
                            (studentGrades.GradeProfile[1] == 1) &&
                            (studentGrades.GradeProfile[2] == 1) &&
                            (studentGrades.GradeProfile[3] == 1) &&
                            (studentGrades.GradeProfile[4] == 4));

            //Assert

            Assert.IsTrue(expectedProfile);

        }
    }
}
