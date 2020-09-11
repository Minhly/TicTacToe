using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KrydsOgBolleSpil
{
    class GameController
    {
        // instantiere Board og Player class
        Board board = new Board();
        Player playerZ = new Player();
        private int turnCounter = 0;
        private bool loop = true;
        private int x;
        private int y;

        // StartGame() kører som det første når programmet startes så spilles en runde som looper så længe loop er true
        // Hvis turnCounter når at tælle til 10 vil spillet fortælle at det blev uafgjort og stoppe loopet 
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
                    // Her køres en runde af spillet som loopes
                    this.playerZ.playerTurnn = 0;
                    PlacePiece();
                    this.board.DrawBoard();
                    this.playerZ.playerTurnn = 1;
                    PlacePiece();
                    this.board.DrawBoard();
                    turnCounter++;
                }
            }
        }

        // Når spilleren har indtastet hvor brikken skal lægges vil den sætte informationerne i InsertPiece() metoden i Board klassen
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
            Console.Clear();
            WinConditions();
        }

        // Checker om der hvor spilleren vil placer sin brik allerede har en brik liggende
        // Hvis der ligger en brik allerede skal spilleren indtaste nye kordinater
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


        #region Win Conditions Vertical, Horizontal and Diagonal

        // Her er alle vinder reglernes metoder samlet i et sted
        public void WinConditions()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            VerticalWin();
            HorizontalWin();
            DiagonalWin();
            Console.ResetColor();
        }


        // Checker om spilleren har 3 på stribe vertical
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
                        Console.WriteLine("Player 1, WINNER WINNER CHICKEN DINNER!.\nWhat a beautiful vertical win!\n\nI played my Asian friend in Tic Tac Toe\nIt was a Thai.\n\nNext game is already waiting for ya!\n");
                    }
                    else
                    {
                        Console.WriteLine("Player 2, WINNER WINNER CHICKEN DINNER!.\nWhat a beautiful vertical win!\n\nI played my Asian friend in Tic Tac Toe\nIt was a Thai.\n\nNext game is already waiting for ya!\n");
                    }
                    turnCounter = 0;
                    this.board.BoardReset();
                    break;
                }
            }
        }

        // Checker om spilleren har 3 på stribe horizontal
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
                        Console.WriteLine("Player 1 , WINNER WINNER CHICKEN DINNER!.\nWhat a beautiful horizontal win!\n\nI played my Asian friend in Tic Tac Toe\nIt was a Thai.\n\nNext game is already waiting for ya!\n");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 , WINNER WINNER CHICKEN DINNER!.\nWhat a beautiful horizontal win!\n\nI played my Asian friend in Tic Tac Toe\nIt was a Thai.\n\nNext game is already waiting for ya!\n");
                    }
                    turnCounter = 0;
                    this.board.BoardReset();
                    break;
                }
            }
        }

        // Checker om spilleren har 3 på stribe diagonal
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
                        Console.WriteLine("Player 1 , WINNER WINNER CHICKEN DINNER!.\nWhat a beautiful diagonal win!\n\nI played my Asian friend in Tic Tac Toe\nIt was a Thai.\n\nNext game is already waiting for ya!\n");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 , WINNER WINNER CHICKEN DINNER!.\nWhat a beautiful diagonal win!\n\nI played my Asian friend in Tic Tac Toe\nIt was a Thai.\n\nNext game is already waiting for ya!\n");
                    }
                    turnCounter = 0;
                    this.board.BoardReset();
                    break;
                }
            }
        }
        #endregion
    }
}
