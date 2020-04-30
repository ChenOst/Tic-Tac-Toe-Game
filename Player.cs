using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    /**
    * Contains all the elements that define the player.
    **/
    class Player
    {
        private bool isFirst;
        private int num;

        public Player()
        {
            this.isFirst = false;
        }
        // Sets the player as the first or second player to play the game.
        public void setIsFirst(bool first)
        {
            isFirst = first;
            if (first)
            {
                num = 1;
            }
            else
            {
                num = 0;
            }
        }
        public int getNum()
        {
            return num;
        }
        // The players move.
        // The player should choose the spot he wants to put his sign.
        public void doYourMove(Board board)
        {
            Console.WriteLine("Choose your place: ");
            int playerChoise;
            bool flag = true;
            while (flag)
            {
                playerChoise = Convert.ToInt32(Console.ReadLine());
                if (playerChoise > 9 || playerChoise < 1)
                {
                    Console.WriteLine("You need to choose number between 1 to 9");
                }
                else if (board.isNotTaken(playerChoise))
                {
                    board.setPlace(playerChoise, this.num);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("This place is taken, try anoter one!");
                }
            }
        }
    }
}
