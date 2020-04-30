using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    /**
     * Contains all dialogs that the program makes with the user.
     * Each line in all dialogs is separated with `System.Threading.Thread.Sleep(500)` 
     * in order to create a controlled flow and that the user will not feel that a lot
     * information is being dropped at once.
     **/
    class Dialog
    {
        //  Opening dialogue that welcomes the user.
        public static void openingDialog()
        {
            Console.WriteLine("Hello and welcome!");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("This is a Tic Tac Toe game!");
        }
        // Explains to the player the rules of the game and how to act in order to play.
        public static void rules()
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("But before we get started let's go over the rules.");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("The rules are very simple:");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("You can choose an empty space on the board from 1 to 9.");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Just write the number of the wanted space:");
            System.Threading.Thread.Sleep(500);
            Board.printBoardBegining();
            System.Threading.Thread.Sleep(500);
        }
        // Determines who will start first the game, the computer or the player.
        public static bool flipCoin()
        {
            Console.WriteLine("In order to decide how is starting lets flip a coin.");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Choose your side: H/T");
            bool flag = true;
            string playerChoise = "";
            while (flag)
            {
                playerChoise = Console.ReadLine();
                if (playerChoise.Equals("H") || playerChoise.Equals("T"))
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("you didnt enter the right input!\ntry againg");
                }
            }
            Random random = new Random();
            int flip = random.Next(0, 2);
            string coinResult = "";
            if (flip == 0)
            {
                coinResult = "H";
            }
            else
            {
                coinResult = "T";
            }
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("The result is: " + coinResult);
            System.Threading.Thread.Sleep(500);
            if (playerChoise.Equals(coinResult))
            {
                Console.WriteLine("You are starting first!");
                return true;
            }
            else
            {
                Console.WriteLine("I am starting first!");
                return false;
            }
        }
        // The message is sent if the player has won the computer.
        public static void thePlayerWins()
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Congratulations! you are the winner");
        }
        // The message is sent if the computer has won the player.
        public static void theComputerWins()
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("I WON !!! Better luck next time!");
        }
        // The message is sent if the board is full, which means that no one won.
        public static void noOneWins()
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("You are a decent competitor!\nNow it's over with tie but next time I'll beat you!");
        }
    }
}
