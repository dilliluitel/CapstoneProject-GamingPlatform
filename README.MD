# Gaming Platform

This is a gaming platform where user will be able to play a couple of online games like Sudoko, Tic-Tac-Toe and Hangmam(word guessing). Currently, only Sudoku game is available for playing.
</br></br>

### What does this application do?

I have attempted to create a gaming platform with user login info. Login info is defaulted for now. The application has option to select the game user wants to play. Currently, Sudoku is the only game which a user can play.</br>
This application is completely built on C# using C# windows forms for GUI purposes. Once the application is lunched, the platform will prompt for user login (which is defaulted for now). By default, Sudoku is the selected game. You can either click or enter to lunch the game.
A sudoku puzzle is loaded by default. But the application has option to randomly load a sudoku puzzle by selecting the puzzle level from the level combo box at top right corner. </br>
User can solve the puzzle and submit it by clicking the Submit button. The application will check if the puzzle is successfully solved and display a message. If the grid is not fully populated the application will display a notification saying so. </br>
User can also directly hit the Solve button and the application will solve the puzzle and display the solved sudoku grid if the grid is solvable.
There is a third button to clear the board any time the user wants to clear the board. </br>
The sudoku board accepts only the decimal digits from 1 through 9 and the control keys. The application is programmed not to accept any other key and thus throws an error message if other keys are pressed. </br>

This application is far from being fully completed at this point. Since the original idea was to create a gaming platform. I have two more games in the panel to be coded and completed. Once all the games are coded, I would like to go ahead and collect the games statics and push it to the SQL data base. </br>

### Challenges

Multiple challenges came during the time of designing and implementing this project. I had to learn C# windows form for the GUI implementations and revisit many of the C# lessons. Coming up with the two-dimensional GUI grid for sudoku board was primary challenge and controlling and navigating the board dynamically was even bigger challenge afterwards. And of course, solving the sudoku grid was the biggest challenge of all. It took more than a week to just come up with the sudoku solver. But I have fairly enjoyed working on this project and excited about the other avenues this project can open up in future.
