using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App05;

namespace ConsoleApp.tests
{
    [TestClass]
    public class Gametest
    {
        //Arrange
        private Game game = new Game("Berzin");

        [TestMethod]
        public void TestGameStart()


        {

            //Act 
            game.Start();

            //Assert

            Assert.AreEqual(0, game.human.Score);
            Assert.AreEqual(0, game.computer.Score);
            Assert.AreEqual(1, game.Round);

            Assert.AreEqual(GamePlayers.Player, game.CurrentPlayer.PlayerType);

            Assert.AreEqual("Berzin", game.human.Name);
            Assert.AreEqual("CPU", game.computer.Name);
        }
        [TestMethod]
        public void TestComputerChoiceisRandom()
        {
            int[] Choices = new int[4];

            game.Start();

            for (int i = 0; i < 10000; i++)
            {
                game.MakeComputerChoice();
                int ChoiceNo = (int)game.computer.Choice;
                Choices[ChoiceNo]++;
            }
            Assert.IsTrue(Choices[0] == 0);
            Assert.IsTrue(Choices[1] > 3000);
            Assert.IsTrue(Choices[2] > 3000);
            Assert.IsTrue(Choices[3] > 3000);

        }

        [TestMethod]

        public void TestScoreForIceandFire()
        {
            game.Start();

            game.human.Choice = GameChoices.Ice;
            game.computer.Choice = GameChoices.Fire;

            game.ScoreRound();

            Assert.AreEqual(0, game.human.Score);
            Assert.AreEqual(2, game.computer.Score);
            Assert.AreEqual(game.winner.PlayerType, GamePlayers.Computer);
        }
    }
}
