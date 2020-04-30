using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    /**
     * Contains all the elements that define the computer.
     **/
    class Computer
    {
        private bool isFirst;
        private int num;
        private int enemyNum;
        private int path = 0;

        public Computer()
        {
            this.isFirst = false;
        }
        // Sets the compuer as the first or second player to play the game.
        // Sets the compuer and the enemy number.
        public void setIsFirst(bool first)
        {
            isFirst = first;
            if (first)
            {
                num = 1;
                enemyNum = 0;
            }
            else
            {
                num = 0;
                enemyNum = 1;
            }
        }
        public int getNum()
        {
            return num;
        }
        public bool getIsFirst()
        {
            return isFirst;
        }

        // The computer stratagy for the game.
        // Every round the computer has a different technique.
        public void strategy(Board board, int turn)
        {
            Console.WriteLine("OK...let me think");
            // The compuer is starting first
            if (this.isFirst)
            {
                if (turn == 1)
                {
                    board.setPlace(5, num);
                }
                else if(turn == 3)
                {
                    if (board.isNotTaken(1))
                    {
                        board.setPlace(1, num);
                        path = 1;
                    }
                    else if (board.isNotTaken(3))
                    {
                        board.setPlace(3, num);
                        path = 2;
                    }
                }
                else if (turn == 5)
                {
                    // Always check first if can win
                    // If the compuer can't win check if the player can win and if he can block him.
                    int canWin = makeAMove(board, this.num);
                    int block = makeAMove(board, this.enemyNum);
                    if (canWin != -1)
                    {
                        board.setPlace(canWin, num);
                    }
                    else if (block != -1)
                    {
                        board.setPlace(block, num);
                    }
                    // If the compuer or the player can't win. put in random spot
                    // contains the path that started last turn.
                    else
                    {
                        if(path == 1)
                        {
                            if (board.isNotTaken(2) && board.isNotTaken(8) && board.isNotTaken(3))
                            {
                                board.setPlace(2, num);
                            }
                            else if(board.isNotTaken(4) && board.isNotTaken(6) && board.isNotTaken(7))
                            {
                                board.setPlace(4, num);
                            }
                        }
                        else if(path == 2)
                        {
                            if (board.isNotTaken(2) && board.isNotTaken(8) && board.isNotTaken(1))
                            {
                                board.setPlace(2, num);
                            }
                            else if (board.isNotTaken(6) && board.isNotTaken(4) && board.isNotTaken(9))
                            {
                                board.setPlace(6, num);
                            }
                        }
                    }
                }
                else if (turn == 7)
                {
                    // Always check first if can win
                    // If the compuer can't win check if the player can win and if he can block him.
                    int canWin = makeAMove(board, this.num);
                    int block = makeAMove(board, this.enemyNum);
                    if (canWin != -1)
                    {
                        board.setPlace(canWin, num);
                    }
                    else if (block != -1)
                    {
                        board.setPlace(block, num);
                    }
                    // If the compuer or the player can't win. put in random spot
                    else
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            if (board.getPlace(i+1) == -1)
                            {
                                board.setPlace(i + 1, num);
                                break;
                            }
                        }
                    }
                }
                else if (turn == 9)
                {
                    // Fill in the only place that got left
                    for (int i=0; i<9; i++)
                    {
                        if (board.getPlace(i+1) == -1)
                        {
                            board.setPlace(i+1, num);
                        }
                    }
                }
            }
            // The compuer is starting second
            else
            {
                // Try to get the center, if its already taken, choose a path
                if (turn == 2)
                {
                    if (board.isNotTaken(5))
                    {
                        board.setPlace(5, num);
                    }
                    else
                    {
                        if (board.isNotTaken(1))
                        {
                            board.setPlace(1, num);
                            path = 1;
                        }
                        else if (board.isNotTaken(3))
                        {
                            board.setPlace(3, num);
                            path = 2;
                        }
                    }
                }
                else if (turn == 4)
                {
                    // Check if the player can win and if he can block him.
                    int block = makeAMove(board, this.enemyNum);
                    if (block != -1)
                    {
                        board.setPlace(block, num);
                    }
                    else
                    {
                        if (path == 1)
                        {
                            if (board.isNotTaken(2)&& board.isNotTaken(3))
                            {
                                board.setPlace(3, num);
                            }
                            else if (board.isNotTaken(4) && board.isNotTaken(7))
                            {
                                board.setPlace(7, num);
                            }
                        }
                        else if (path == 2)
                        {
                            if (board.isNotTaken(1) && board.isNotTaken(2))
                            {
                                board.setPlace(1, num);
                            }
                            else if (board.isNotTaken(6) && board.isNotTaken(9))
                            {
                                board.setPlace(9, num);
                            }
                        }
                    }
                }
                else if (turn == 6)
                {
                    // Always check first if can win
                    // If the compuer can't win check if the player can win and if he can block him.
                    int canWin = makeAMove(board, this.num);
                    int block = makeAMove(board, this.enemyNum);
                    if (canWin != -1)
                    {
                        board.setPlace(canWin, num);
                    }
                    else if (block != -1)
                    {
                        board.setPlace(block, num);
                    }
                    else
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            if (board.getPlace(i + 1) == -1)
                            {
                                board.setPlace(i + 1, num);
                                break;
                            }
                        }
                    }
                }
                else if (turn == 8)
                {
                    // Always check first if can win
                    // If the compuer can't win check if the player can win and if he can block him.
                    int canWin = makeAMove(board, this.num);
                    int block = makeAMove(board, this.enemyNum);
                    if (canWin != -1)
                    {
                        board.setPlace(canWin, num);
                    }
                    else if (block != -1)
                    {
                        board.setPlace(block, num);
                    }
                    else
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            if (board.getPlace(i+1) == -1)
                            {
                                board.setPlace(i + 1, num);
                                break;
                            }
                        }
                    }
                }
            }
        }
        // Based on the board information determine the next step.
        private int makeAMove(Board board, int kkk)
        {
            // Loop that checks for 2 in a row
            for (int i = 1; i <= 7; i = i + 3)
            {
                if (board.getPlace(i) == board.getPlace(i + 1) && board.getPlace(i) == kkk && board.getPlace(i + 2)==-1)
                {
                    return i + 2;
                }
                else if (board.getPlace(i) == board.getPlace(i + 2) && board.getPlace(i) == kkk && board.getPlace(i + 1) == -1)
                {
                    return i + 1;
                }
                else if (board.getPlace(i+1) == board.getPlace(i + 2) && board.getPlace(i + 1) == kkk && board.getPlace(i) == -1)
                {
                    return i;
                }
            }
            // Loop that checks for 2 in a column
            for (int i = 1; i <= 3; i = i + 1)
            {
                if (board.getPlace(i) == board.getPlace(i + 3) && board.getPlace(i) == kkk && board.getPlace(i + 6) == -1)
                {
                    return i + 6;
                }
                else if (board.getPlace(i) == board.getPlace(i + 6) && board.getPlace(i) == kkk && board.getPlace(i + 3) == -1)
                {
                    return i + 3;
                }
                else if (board.getPlace(i + 3) == board.getPlace(i + 6) && board.getPlace(i + 3) == kkk && board.getPlace(i) == -1)
                {
                    return i;
                }
            }
            // Check the first diagonal
            if (board.getPlace(1) == board.getPlace(5) && board.getPlace(1) == kkk && board.getPlace(9)==-1)
            {
                return 9;
            }
            else if (board.getPlace(1) == board.getPlace(9) && board.getPlace(1) == kkk && board.getPlace(5) == -1)
            {
                return 5;
            }
            else if (board.getPlace(5) == board.getPlace(9) && board.getPlace(5) == kkk && board.getPlace(1) == -1)
            {
                return 1;
            }
            // Check the second diagonal
            if (board.getPlace(3) == board.getPlace(5) && board.getPlace(3) == kkk && board.getPlace(7) == -1)
            {
                return 7;
            }
            else if (board.getPlace(3) == board.getPlace(7) && board.getPlace(3) == kkk && board.getPlace(5) == -1)
            {
                return 5;
            }
            else if (board.getPlace(5) == board.getPlace(7) && board.getPlace(5) == kkk && board.getPlace(3) == -1)
            {
                return 3;
            }
            return -1;
        }
    }
}
