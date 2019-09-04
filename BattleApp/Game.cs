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

        public void Run()
        {
            while (!CheckForWin())
            {
                DoRound();
            }

            var winner = GetWinner();
            if (winner != null)
            {
                Console.WriteLine($"{winner?.Name} has won on round {Round}.");
            }
            else
            {
                Console.WriteLine($"Match has ended in a draw on round {Round}.");
            }
        }

        public void DoRound()
        {
            round++;
            Console.WriteLine($"Round {round} has started.");

            units[0].Attack(units[1]);
            units[1].Attack(units[0]);
        }

        public bool CheckForWin() => units[0].Health <= 0 || units[1].Health <= 0;

        public Unit GetWinner() => units.SingleOrDefault(x => x.Health > 0);
    }
}
