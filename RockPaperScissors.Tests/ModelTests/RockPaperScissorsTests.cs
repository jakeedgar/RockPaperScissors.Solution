using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
  [TestMethod]
    public void RunGameTest_ShouldReturnInputInformation_Rock()
    {
      string userOneInput = "rock";
      string userTwoInput = "paper";
      Game newGame = new Game (userOneInput, userTwoInput);
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("rock", newGame.ReturnUserOne());
    }
  }
}