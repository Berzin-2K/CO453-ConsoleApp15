using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App05;

namespace ConsoleApp.tests
{
    [TestClass]
    class RPS_Gametest
    {
        private Game game = new Game("Berzin");

        [TestMethod]
        public void TestGameStart()
        {
            game.Start();

            Assert.AreEqual(0, game.human.Score);
            Assert.AreEqual(0, game.computer.Score);
            Assert.AreEqual(1, game.Round);

            Assert.AreEqual(GamePlayers.Player, game.CurrentPlayer.PlayerType);

            Assert.AreEqual("Berzin", game.human.Name);
            Assert.AreEqual("CPU", game.computer.Name);
        }
    }
}
