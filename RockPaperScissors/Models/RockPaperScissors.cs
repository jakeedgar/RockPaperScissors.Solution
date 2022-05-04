public class Game 
{
  // private fields
  private string _userOneInput;
  private string _userTwoInput;

  public Game(string userOneInput, string userTwoInput)
  {
    _userOneInput = userOneInput;
    _userTwoInput = userTwoInput;
  }

  public string ReturnUserOne()
  {
    return _userOneInput;
  }
}

// if (_userOneInput == "rock" && _userTwoInput == "rock")
// {
//   return "This Is A Draw";
// }
// else if (_userOneInput == "rock" && _userTwoInput == "scissors")
// {
//   return "Player 1 Wins!";
// }
// else if (_userOneInput == "rock" && _userTwoInput == "paper")
// {
//   return "Player 2 Wins!";
// }