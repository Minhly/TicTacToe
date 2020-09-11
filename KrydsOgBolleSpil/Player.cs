using System;
using System.Collections.Generic;
using System.Text;

namespace KrydsOgBolleSpil
{
    class Player
    {
        public char symbols;
        public int playerTurnn = 0;

        // PlayerTurn metoden skifter spillerens tur afhængig af om playerTurnn er 0 eller 1
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
