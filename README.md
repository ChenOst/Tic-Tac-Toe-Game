# Tic Tac Toe Game
The game is done as part of the course: [gamedev-5780](https://github.com/erelsgl-at-ariel/gamedev-5780)

**Created by:**

[Chen Ostrovski](https://github.com/ChenOst)

[Enna Grigor](https://github.com/ennagrigor)

Tic Tac Toe game that is built so that the player plays against the computer.

## Program

##### Contains 6 main methods:

## Board
Contains all the elements that define the game board.
The board object contains an array of 9 places initialized to -1.
During the game the player and the computer receive the numbers 0 and 1.
When they choose a particular location, the position in the array change accordingly.
##### Contains 6 methods:

- **isNotTaken** - Checks if a certain place on the board is occupied. 
Because the value the user can enter ranges from 1 to 9 and the arrays range
is from 0 to 8 the function loses 1 of the resulting value.
- **isFull** - Goes all over the board and checks if it's full.

- **setPlace** - Setting in the board a certain position for a giving number (0 or 1);
Because the value the user can enter ranges from 1 to 9 and the arrays range
is from 0 to 8 the function loses 1 of the resulting value.

- **getPlace** - Returns the value that is in the location.
Because the value the user can enter ranges from 1 to 9 and the arrays range
is from 0 to 8 the function loses 1 of the resulting value.

- **printBoard** - Prints the board after each round with its updated values.
Depending on the values the player and the computer put in each slot print X or O at each slot.

- **printBoardBegining** - Prints the board at the beginning of the game with the values 
1 to 9 to explain to the player the rules and how to select the slot he wants.

## Computer

##### Contains 6 methods:

## Player

##### Contains 6 methods:

## Dialog
Contains all dialogs that the program makes with the user.
Each line in all dialogs is separated with `System.Threading.Thread.Sleep(500)` 
in order to create a controlled flow and that the user will not feel that a lot
information is being dropped at once.
##### Contains 6 methods:
- **openingDialog** - Opening dialogue that welcomes the user.

  ```
  Hello and welocome!
  This is a Tic Tac Toe game!
  ```

- **rules** - Explains to the player the rules of the game and how to act in order to play.
 this function calles to another function from class Board `printBoardBegining`
 the function print the board as written above. The player should choose empty
 space in the board and write its number.
 
  ```
  But before we get started let's go over the rules.
  The rules are very simple:
  You can choose an empty space on the board from 1 to 9.
  Just write the number of the wanted space:
   --- --- ---
  | 1 | 2 | 3 |
   --- --- ---
  | 4 | 5 | 6 |
   --- --- ---
  | 7 | 8 | 9 |
   --- --- ---
   ```
- **flipCoin** - The only method that returns a value, after the rules dialog the player has to flip a coin 
in order to determine who will start first the game, the computer or the player.
The player can choose between H or T.
If the user chose something different the program send him message, it also announces who won.

    ```
  In order to decide how is starting lets flip a coin.
  Choose your side: H/T
  The result is:
   ``` 

- **thePlayerWins** - The message is sent if the player has won the computer.

    ```
  Congratulations! you are the winner
   ```

- **theComputerWins** - The message is sent if the computer has won the player.

    ```
  I WON !!! Better luck next time!

- **noOneWins** - The message is sent if the board is full, which means that no one won.

    ```
  You are a decent competitor!
  Now it's over with tie but next time I'll beat you!
  ```



