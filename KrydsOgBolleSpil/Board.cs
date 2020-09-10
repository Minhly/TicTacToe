using System;
using System.Collections.Generic;
using System.Text;

namespace KrydsOgBolleSpil
{
    class Board
    {

        string[,] boardBox = new string[3, 3];

        public Board()
        {
            InstantiateBoard();
        }

        public void InstantiateBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 3; c++)
                {
                    boardBox[i,c] = " ? ";
                }
            }
        }

        public void DrawBoard()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int c = 0; c < 3; c++)
                {
                    Console.Write(boardBox[i, c]);
                }
                Console.WriteLine("\n");
            }
        }

        public void InsertPiece(int x, int y, char symbol)
        {
            boardBox[x, y] = " " + symbol.ToString() + " ";
        }
    }


}
