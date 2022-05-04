// Tests //

Test 1 :

Describe: It should save the input of user 1 and user 2 as a variable, and return those values correctly. 

  Code: userOneInput("rock")
  Code: userTwoInput("paper")
  Expected Output: "rock", "paper"

Describe: It should compare user's input according to game logic, and return the winning user.
    Game Logic: Rock beats Scissors. Scissors Beats Paper. Paper beats Rock. A matching pair is always a draw. 

  Code: userOneInput("rock")
  Code: userTwoInput("paper")
  Expected Output: "userTwo Wins!"

  Code: userOneInput("rock")
  Code: userTwoInput("rock")
  Expected Output: "It is a Draw. :-("

Describe: It should return an error message if the user does not input a correct choice. 

  Code: userOneInput("toilet")
  Code: userTwoInput("paper")
  Expected Output: "Please enter a rock, paper, or scissors."

  Code: userOneInput("rocks")
  Code: userTwoInput("paper")
  Expected Output: "Please enter a rock, paper, or scissors."