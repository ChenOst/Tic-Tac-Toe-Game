using System;

namespace TicTacToeGame
{
    class Program
    {
        public static Board board = new Board();
        public static Player player = new Player();
        public static Computer computer = new Computer();
        public static int turn = 0;
        static void Main(string[] args)
        {
            startGame();
        }
        // The function that starts the game
        private static void startGame()
        {
            Dialog.openingDialog();
            Dialog.rules();
            bool flip = Dialog.flipCoin();
            player.setIsFirst(flip);
            computer.setIsFirst(!flip);
            // Keep playing the game as long as the board is not full.
            while (!board.isFull())
            {
                // Compuer making the first move
                if (computer.getIsFirst())
                {
                    computerTurn();
                    playerTurn();
                }
                // Player making the first move
                else
                {
                    playerTurn();
                    computerTurn();
                }
            }
        }

        private static void computerTurn()
        {
            turn++;
            computer.strategy(board, turn);
            // After each turn print the board.
            board.printBoard();
            // There can be winners starting in the fifth round
            if ( turn > 4 && (checkForWinners() || board.isFull()))
            {
                if (board.isFull())
                {
                    Dialog.noOneWins();
                }
                // If won exit the game
                System.Environment.Exit(1);
            }
        }
        private static void playerTurn()
        {
            turn++;
            player.doYourMove(board);
            // After each turn print the board.
            board.printBoard();
            // There can be winners starting in the fifth round
            if (turn > 4 && (checkForWinners() || board.isFull()))
            {
                if (board.isFull())
                {
                    Dialog.noOneWins();
                }
                // If won exit the game
                System.Environment.Exit(1);
            }
        }
        // Check for winners, checks for a full row/ cole or diagonal
        private static bool checkForWinners()
        {
            // Loop that checks for 3 in a row
            for (int i=1; i<=7; i = i + 3)
            {
                if (board.getPlace(i) == board.getPlace(i + 1) && board.getPlace(i + 1) == board.getPlace(i + 2) && board.getPlace(i)!=-1) 
                {
                    DetermineTheWinner(board.getPlace(i));
                    return true;
                }
            }
            // Loop that checks for 3 in a column
            for (int i = 1; i <=3 ; i = i + 1)
            {
                if (board.getPlace(i) == board.getPlace(i + 3) && board.getPlace(i + 3) == board.getPlace(i + 6) && board.getPlace(i) != -1)
                {
                    DetermineTheWinner(board.getPlace(i));
                    return true;
                }
            }
            // Check the first diagonal
            if (board.getPlace(1) == board.getPlace(5) && board.getPlace(5) == board.getPlace(9) && board.getPlace(1) != -1)
            {
                DetermineTheWinner(board.getPlace(1));
                return true;
            }
            // Check the second diagonal
            if (board.getPlace(3) == board.getPlace(5) && board.getPlace(5) == board.getPlace(7) && board.getPlace(3) != -1)
            {
                DetermineTheWinner(board.getPlace(3));
                return true;
            }
            return false;
        }
        // If found full row/ cole or diagonal find out who is the winner.
        private static void DetermineTheWinner(int location)
        {
            // Computer is the winner
            if (location == computer.getNum())
            {
                Dialog.theComputerWins();
            }
            // Player is the winner
            else if (location == player.getNum())
            {
                Dialog.thePlayerWins();
            }
        }
    }
}
