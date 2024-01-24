using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emre_duman_tic_tac_toe
{
    public class Func
    {

        public void DrawGameBoard(string[] board)
        {
            int cellIndex = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j <= 11; j++)
                {
                    if (j % 4 == 0)
                    {
                        Console.Write("|");
                    }
                    else if (j % 2 == 0)
                    {
                        if (board[cellIndex] == "X" || board[cellIndex] == "O")
                        {
                            Console.Write(board[cellIndex]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        cellIndex++;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                if (i < 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("---+---+---");
                }
            }
            Console.WriteLine();
        }

        public bool checkWinner(string[] board, string player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i * 3] == player && board[i * 3 + 1] == player && board[i * 3 + 2] == player
                    || board[i] == player && board[i + 3] == player && board[i + 6] == player)
                    return true;
            }
            if (board[0] == player && board[4] == player && board[8] == player || board[2] == player && board[4] == player && board[6] == player)
                return true;
            return false;
        }

    }
}
