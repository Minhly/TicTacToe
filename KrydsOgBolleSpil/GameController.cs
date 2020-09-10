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
        int turnCounter = 0;
        bool loop = true;
        int x;
        int y;

        public void StartGame()
        {
            board.DrawBoard();
            while (loop == true) {
                if(turnCounter == 10) {
                    loop = false;
                    Console.WriteLine("It was a tie");
                }
                else
                {
                    playerTurn = 0;
                    PlacePiece();
                    board.DrawBoard();
                    playerTurn = 1;
                    PlacePiece();
                    board.DrawBoard();
                    turnCounter++;
                }
            }
        }

        public void PlacePiece()
        {
            PlayerTurn();
            Console.WriteLine("Type a number from 0 to 2 - vertical X");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Type a number from 0 to 2 - horizontal Y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            DuplicatePieceRule();
            Console.WriteLine("\n");
            this.board.InsertPiece(x,y,symbols);
        }

        public void DuplicatePieceRule()
        {
            while (this.board.boardBox[x,y] != this.board.placeHolder)
            {
                Console.WriteLine("Theres already a piece here!");
                Console.WriteLine("Type a number from 0 to 2 - vertical X");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Type a number from 0 to 2 - horizontal Y");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
            }  
        }

        public void PlayerTurn()
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
        }
    }
}
