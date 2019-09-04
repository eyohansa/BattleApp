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
                Health = 12,
                MinDamage = 3,
                MaxDamage = 4
            };

            var unitB = new Unit
            {
                Name = "B",
                Health = 13,
                MinDamage = 2,
                MaxDamage = 5,
            };

            var game = new Game(unitA, unitB);
            game.Run();
            Console.ReadLine();
        }
    }
}
