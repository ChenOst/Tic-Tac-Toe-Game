using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    /**
     * Contains all the elements that define the game board.
     * The board object contains an array of 9 places initialized to -1.
     * During the game the player and the computer receive the numbers 0 and 1.
     * When they choose a particular location, the position in the array change accordingly.
     * Because the value the user can enter ranges from 1 to 9 and the arrays range
     * is from 0 to 8 the function loses 1 of the resulting value.
     * */
    class Board
    {
        public int[] board;
        public Board()
        {
            board = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        }
        // Checks if a certain place on the board is occupied. 
        public bool isNotTaken(int place)
        {

            if (board[place - 1] == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Goes all over the board and checks if it's full.
        public bool isFull()
        {
            for (int i = 0; i < board.Length; i++)
            {  
                if (board[i] == -1)
                {
                    return false;
                }
            }
            return true;
        }
        // Setting in the board a certain position for a giving number (0 or 1);
        public void setPlace(int place, int num)
        {
            board[place - 1] = num;
        }
        // Returns the value that is in the location.
        public int getPlace(int place)
        {
            return board[place - 1];
        }
        // Prints the board after each round with its updated values.
        // Depending on the values the player and the computer put in each slot print X or O at each slot.
        public void printBoard()
        {
            for (int i=0; i <= 12 ; i++)
            {
                for (int j = 0; j <= 12 ; j++)
                {  
                    if (i % 4 == 0 && j % 4 == 0)
                    {
                        Console.Write(" ");
                    }        
                    else if (i % 4 == 0)
                    {
                        Console.Write("-");
                    }
                    else if (j % 4 == 0)
                    {
                        Console.Write("|");
                    }
                    else if (i == 2 && j == 2 && board[0] != -1)
                    {
                        if (board[0] == 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    else if (i == 2 && j == 6 && board[1] != -1)
                    {
                        if (board[1] == 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    else if (i == 2 && j == 10 && board[2] != -1)
                    {
                        if (board[2] == 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    else if (i == 6 && j == 2 && board[3] != -1)
                    {
                        if (board[3] == 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    else if (i == 6 && j == 6 && board[4] != -1)
                    {
                        if (board[4] == 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    else if (i == 6 && j == 10 && board[5] != -1)
                    {
                        if (board[5] == 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    else if (i == 10 && j == 2 && board[6] != -1)
                    {
                        if (board[6] == 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    else if (i == 10 && j == 6 && board[7] != -1)
                    {
                        if (board[7] == 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    else if (i == 10 && j == 10 && board[8] != -1)
                    {
                        if (board[8] == 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    else
                    {
                            Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
        // Prints the board at the beginning of the game with the values 
        // 1 to 9 to explain to the player the rules and how to select the slot he wants.
        public static void printBoardBegining()
        {
            for (int i = 0; i <= 12; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    if (i % 4 == 0 && j % 4 == 0)
                    {
                        Console.Write(" ");
                    }

                    else if (i % 4 == 0)
                    {
                        Console.Write("-");
                    }

                    else if (j % 4 == 0)
                    {
                        Console.Write("|");
                    }
                    else if (i == 2 && j == 2)
                    {
                        Console.Write("1");
                    }
                    else if (i == 2 && j == 6)
                    {
                        Console.Write("2");
                    }
                    else if (i == 2 && j == 10)
                    {
                        Console.Write("3");
                    }
                    else if (i == 6 && j == 2)
                    {
                        Console.Write("4");
                    }
                    else if (i == 6 && j == 6)
                    {
                        Console.Write("5");
                    }
                    else if (i == 6 && j == 10)
                    {
                        Console.Write("6");
                    }
                    else if (i == 10 && j == 2 )
                    {
                        Console.Write("7");
                    }
                    else if (i == 10 && j == 6)
                    {
                        Console.Write("8");
                    }
                    else if (i == 10 && j == 10)
                    {
                        Console.Write("9");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
