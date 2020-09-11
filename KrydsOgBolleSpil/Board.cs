using System;
using System.Collections.Generic;
using System.Text;

namespace KrydsOgBolleSpil
{
    class Board
    {
        // 2 dimensionel array til at lave boardet med
        public char[,] boardBox = new char[3, 3];
        public char placeHolder = '?';

        // Ligeså snart Board bliver instantieret vil InstantiateBoard blive kaldt
        public Board()
        {
            InstantiateBoard();
        }

        // Laver den første board når objektet bliver instantieret med placeholders i felterne
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

        // DrawBoard() funktionen tegner det rigtige board og overskriver InstantiateBoard()
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

        // resetter boardest værdier til at bliver placeholders
        public void BoardReset()
        {
            InstantiateBoard();
        }

        // Indsætter værdier i arrayet x, y og symbol
        public void InsertPiece(int x, int y, char symbol)
        {
            boardBox[x, y] = symbol;
        }
    }


}
