using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KrydsOgBolleSpil
{
    class GameController
    {
        Board board = new Board();
        int playerTurn = 0;
        public char symbols;

        public void StartGame()
        {
            board.DrawBoard();
            while (true) {
                playerTurn = 0;
                PlacePiece();
                board.DrawBoard();
                playerTurn = 1;
                PlacePiece();
                board.DrawBoard();
            }
        }

        public void PlacePiece()
        {
            if (playerTurn == 0)
            {
                Console.WriteLine("Your symbol is X");
                symbols = 'X';
            }
            else if (playerTurn == 1)
            {
                Console.WriteLine("Your symbol is O");
                symbols = 'O';
            }
            Console.WriteLine("Type a number from 0 to 2 - vertical X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a number from 0 to 2 - horizontal Y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            this.board.InsertPiece(x,y,symbols);
        }

        public void DuplicatePieceRule()
        {

        }


    }
}
