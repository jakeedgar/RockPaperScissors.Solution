using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
  [TestMethod]
    public void ReturnUserOneInput_ShouldReturnInputInformation_Rock()
    {
      string userOneInput = "rock";
      string userTwoInput = "paper";
      Game newGame = new Game (userOneInput, userTwoInput);
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("rock", newGame.ReturnUserOne());
    }

    [TestMethod]
    public void RunGame_ShouldReturnDraw_Rock()
    {
      string userOneInput = "rock";
      string userTwoInput = "rock";
      Game newGame = new Game(userOneInput, userTwoInput);
      Assert.AreEqual("This Is A Draw!", newGame.RunGame());
    }

    [TestMethod]
    public void RunGame_ShouldReturnPlayerOneWins_Rock()
    {
      string userOneInput = "rock";
      string userTwoInput = "scissors";
      Game newGame = new Game(userOneInput, userTwoInput);
      Assert.AreEqual("Player 1 Wins!", newGame.RunGame());
    }

    [TestMethod]
    public void RunGame_ShouldReturnPlayerTwoWins_Rock()
    {
      string userOneInput = "rock";
      string userTwoInput = "paper";
      Game newGame = new Game(userOneInput, userTwoInput);
      Assert.AreEqual("Player 2 Wins!", newGame.RunGame());
    }

    [TestMethod]
    public void RunGame_ShouldReturnDraw_Paper()
    {
      string userOneInput = "paper";
      string userTwoInput = "paper";
      Game newGame = new Game(userOneInput, userTwoInput);
      Assert.AreEqual("This Is A Draw!", newGame.RunGame());
    }

    [TestMethod]
    public void RunGame_ShouldReturnPlayerOneWins_Paper()
    {
      string userOneInput = "paper";
      string userTwoInput = "rock";
      Game newGame = new Game(userOneInput, userTwoInput);
      Assert.AreEqual("Player 1 Wins!", newGame.RunGame());
    }

    [TestMethod]
    public void RunGame_ShouldReturnPlayerTwoWins_Paper()
    {
      string userOneInput = "paper";
      string userTwoInput = "scissors";
      Game newGame = new Game(userOneInput, userTwoInput);
      Assert.AreEqual("Player 2 Wins!", newGame.RunGame());
    }


  }
}