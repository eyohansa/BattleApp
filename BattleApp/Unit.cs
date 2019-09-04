using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleApp
{
    public class Unit
    {
        public string Name { get; set; } = "Unknown";
        public int Health { get; set; }
        public int MinDamage { get; set; } = 1;
        public int MaxDamage { get; set; } = 1;

        public void Attack(Unit target)
        {
            var random = new Random();
            var damage = random.Next(MinDamage, MaxDamage);
            target.Health -= damage;
            Console.WriteLine($"{Name} dealth {damage} to {target.Name} (HP: {target.Health})");
        }
    }
}
