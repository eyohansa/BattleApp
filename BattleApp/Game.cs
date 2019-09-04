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
            units[0].Health -= units[1].Damage;
            units[1].Health -= units[0].Damage;
        }

        public bool CheckForWin() => units[0].Health <= 0 || units[1].Health <= 0;

        public Unit GetWinner() => units.SingleOrDefault(x => x.Health > 0);
    }
}
