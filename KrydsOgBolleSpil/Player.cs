using System;
using System.Collections.Generic;
using System.Text;

namespace KrydsOgBolleSpil
{
    class Player
    {
        public char symbols;
        public int playerTurnn = 0;

        public void PlayerTurn()
        {
            if (playerTurnn == 0)
            {
                Console.WriteLine("Your symbol is X");
                symbols = 'X';
            }
            else if (playerTurnn == 1)
            {
                Console.WriteLine("Your symbol is O");
                symbols = 'O';
            }
        }
    }
}
