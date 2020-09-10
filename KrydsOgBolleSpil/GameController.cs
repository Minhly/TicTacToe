using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KrydsOgBolleSpil
{
    class GameController
    {
        Board board = new Board();
        Player playerZ = new Player();
        private int turnCounter = 0;
        private bool loop = true;
        private int x;
        private int y;

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
                    this.playerZ.playerTurnn = 0;
                    PlacePiece();
                    board.DrawBoard();
                    this.playerZ.playerTurnn = 1;
                    PlacePiece();
                    board.DrawBoard();
                    turnCounter++;
                }
            }
        }

        public void PlacePiece()
        {
            playerZ.PlayerTurn();
            Console.WriteLine("Type a number from 0 to 2 - vertical X");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Type a number from 0 to 2 - horizontal Y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            DuplicatePieceRule();
            Console.WriteLine("\n");
            this.board.InsertPiece(x,y,this.playerZ.symbols);
            WinConditions();
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

        public void WinConditions()
        {
            VerticalWin();
            HorizontalWin();
            DiagonalWin();
        }

        public void VerticalWin()
        {
            char[] symbolsXO = { 'X', 'O' };

            foreach (char symbolXO in symbolsXO)
            {
                if (((this.board.boardBox[0,0] == symbolXO) && (this.board.boardBox[1,0] == symbolXO) && (this.board.boardBox[2,0] == symbolXO))
                    || ((this.board.boardBox[0,1] == symbolXO) && (this.board.boardBox[1,1] == symbolXO) && (this.board.boardBox[2,1] == symbolXO))
                    || ((this.board.boardBox[0,2] == symbolXO) && (this.board.boardBox[1,2] == symbolXO) && (this.board.boardBox[2,2] == symbolXO)))
                {
                    Console.Clear();
                    if (symbolXO == 'X')
                    {
                        Console.WriteLine("Player 1, that was Fantastic.\nA vertical win!\nYou're the Tic Tac Toe Master!\n");
                    }
                    else
                    {
                        Console.WriteLine("Player 2, that was Fantastic.\nA vertical win!\nYou're the Tic Tac Toe Master!\n");
                    }
                    break;
                }
            }
        }

        public void HorizontalWin()
        {
            char[] symbolsXO = { 'X', 'O' };

            foreach (char symbolXO in symbolsXO)
            {
                if (((this.board.boardBox[0, 0] == symbolXO) && (this.board.boardBox[0, 1] == symbolXO) && (this.board.boardBox[0, 2] == symbolXO))
                    || ((this.board.boardBox[1, 0] == symbolXO) && (this.board.boardBox[1, 1] == symbolXO) && (this.board.boardBox[1, 2] == symbolXO))
                    || ((this.board.boardBox[2, 0] == symbolXO) && (this.board.boardBox[2, 1] == symbolXO) && (this.board.boardBox[2, 2] == symbolXO)))
                {
                    Console.Clear();
                    if (symbolXO == 'X')
                    {
                        Console.WriteLine("Player 1 , that was Fantastic.\nA horizontal win!\nYou're the Tic Tac Toe Master!\n");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 , that was Fantastic.\nA horizontal win!\nYou're the Tic Tac Toe Master!\n");
                    }
                    break;
                }
            }
        }

        public void DiagonalWin()
        {
            char[] symbolsXO = { 'X', 'O' };

            foreach (char symbolXO in symbolsXO)
            {
                if (((this.board.boardBox[0, 0] == symbolXO) && (this.board.boardBox[1, 1] == symbolXO) && (this.board.boardBox[2, 2] == symbolXO))
                    || ((this.board.boardBox[2, 0] == symbolXO) && (this.board.boardBox[1, 1] == symbolXO) && (this.board.boardBox[0, 2] == symbolXO)))
                {
                    Console.Clear();
                    if (symbolXO == 'X')
                    {
                        Console.WriteLine("Player 1 , that was Fantastic.\nA Diagonal win!\nYou're the Tic Tac Toe Master!\n");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 , that was Fantastic.\nA Diagonal win!\nYou're the Tic Tac Toe Master!\n");
                    }
                    break;
                }
            }
        }
    }
}
