
namespace RockPaperScissors 
{

  public class Game
  {
    // private fields
    private string _userOneInput;
    private string _userTwoInput;
    public string result;

    public Game(string userOneInput, string userTwoInput)
    {
      _userOneInput = userOneInput;
      _userTwoInput = userTwoInput;
    }

    public string ReturnUserOne()
    {
      return _userOneInput;
    }

    public string RunGame()
    {
      if (_userOneInput == "rock" && _userTwoInput == "rock")
      {
        return result = "This Is A Draw!";

      }
      else if (_userOneInput == "rock" && _userTwoInput == "scissors")
      {
        return result =  "Player 1 Wins!";
      }
      else if (_userOneInput == "rock" && _userTwoInput == "paper")
      {
        return result = "Player 2 Wins!";
      }
      else if (_userOneInput == "paper" && _userTwoInput == "paper")
      {
        return result = "This Is A Draw!";
      }
      else if (_userOneInput == "paper" && _userTwoInput == "rock")
      {
        return result = "Player 1 Wins!";
      }
      else if (_userOneInput == "paper" && _userTwoInput == "scissors")
      {
        return result = "Player 2 Wins!";
      }
      else if (_userOneInput == "scissors" && _userTwoInput == "scissors")
      {
        return result = "This Is A Draw!";
      }
      else if (_userOneInput == "scissors" && _userTwoInput == "paper")
      {
        return result = "Player 1 Wins!";
      }
      else if (_userOneInput == "scissors" && _userTwoInput == "rock")
      {
        return result = "Player 2 Wins!";
      }
      else
      {
        return result = "please enter rock, paper, or scissors";
      }
    }
  }

}