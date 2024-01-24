
using emre_duman_tic_tac_toe;

Func func = new Func();

do
{
    Console.WriteLine("1. New game");
    Console.WriteLine("2. About the author");
    Console.WriteLine("3. Exit");
    Console.Write("> ");
    string menu = Console.ReadLine();
    Console.WriteLine();
    if (menu == "1")
    {
        int moveCount = 0;
        string[] board = new string[9];
        func.DrawGameBoard(board);

        do
        {
            if (moveCount != 9)
            {
                string currentPlayer;
                if (moveCount % 2 == 0)
                {
                    currentPlayer = "X";
                }
                else
                {
                    currentPlayer = "O";
                }
                Console.Write($"{currentPlayer}'s move > ");

                int userMove = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine();
                if (board[userMove] == "X" || board[userMove] == "O" || userMove < 0 || board.Length <= userMove)
                {
                    Console.WriteLine("Illegal move! Try again.");
                    continue;
                }

                board[userMove] = currentPlayer;
                moveCount++;
                func.DrawGameBoard(board);

                if (func.checkWinner(board, currentPlayer))
                {
                    Console.WriteLine($"\n{currentPlayer} won!");
                    Console.Write("[Press Enter to return to main menu...]");
                    Console.ReadLine();
                    Console.WriteLine();
                    break;
                }
            }
            else
            {
                moveCount++;
                Console.WriteLine("Game over!");
            }
        } while (moveCount < 10);
    }
    else if (menu == "2")
    {
        Console.WriteLine("Made by Emre Duman");
        Console.Write("[Press Enter to return to main menu...]");
        Console.ReadLine();
        Console.WriteLine();
    }
    else if (menu == "3")
    {
        Console.WriteLine("Are you sure you want to quit? [y/n]");
        Console.Write("> ");
        string temp = Console.ReadLine();
        if (temp.ToLower() == "y") break;
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
    }
} while (true);

