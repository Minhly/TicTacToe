using System;
using System.Collections.Generic;
using System.Text;

namespace KrydsOgBolleSpil
{
    class Board
    {
        public char[,] boardBox = new char[3, 3];
        public char placeHolder = '?';

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
                    boardBox[i,c] = placeHolder;
                }
            }
        }

        public void DrawBoard()
        {
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                for(int c = 0; c < 3; c++)
                {
                    Console.Write("    "+boardBox[i, c]+" ");
                }
                Console.WriteLine("\n");
            }
        }

        public void InsertPiece(int x, int y, char symbol)
        {
            boardBox[x, y] = symbol;
        }
    }


}
