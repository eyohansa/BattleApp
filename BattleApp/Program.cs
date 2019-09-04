using System;

namespace BattleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var unitA = new Unit
            {
                Name = "A",
                Health = 10,
                Damage = 3
            };

            var unitB = new Unit
            {
                Name = "B",
                Health = 11,
                Damage = 2
            };

            var game = new Game(unitA, unitB);
            while(!game.CheckForWin())
            {
                game.DoRound();
            }

            Console.WriteLine($"{game.GetWinner()?.Name} has won on round {game.Round}");
            Console.ReadLine();
        }
    }
}
