using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleApp
{
    public class Game
    {
        Unit[] units;
        uint round = 0;

        public uint Round { get => round; }

        public Game(Unit a, Unit b)
        {
            units = new Unit[2] { a, b };
        }

        public void DoRound()
        {
            round++;
            Console.WriteLine($"Round {round} has started.");

            units[0].Health -= units[1].Damage;
            units[1].Health -= units[0].Damage;

            Console.WriteLine($"{units[0].Name} dealt {units[0].Damage} to {units[1].Name} (HP: {units[1].Health})");
            Console.WriteLine($"{units[1].Name} dealt {units[1].Damage} to {units[0].Name} (HP: {units[0].Health})");
        }

        public bool CheckForWin() => units[0].Health <= 0 || units[1].Health <= 0;

        public Unit GetWinner() => units.SingleOrDefault(x => x.Health > 0);
    }
}
