using System;
using System.Collections.Generic;
using System.Text;

namespace KrydsOgBolleSpil
{
    class GamePieces
    {
        private int position;
        private char symbol;

        public GamePieces(int position, char symbol)
        {
            this.position = position;
            this.symbol = symbol;
        }
    }
}
