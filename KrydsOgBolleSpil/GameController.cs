using System;
using System.Collections.Generic;
using System.Text;

namespace KrydsOgBolleSpil
{
    class GameController
    {
        Board board = new Board();
        
        public void StartGame()
        {
            board.DrawBoard();
        }
    }
}
