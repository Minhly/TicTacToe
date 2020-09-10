using System;
using System.Dynamic;

namespace KrydsOgBolleSpil
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController game = new GameController();

            game.StartGame();

            Console.ReadLine();
        }
    }
}
