using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadMiner.Enemy
{
    class Sheep : Enemies.Enemy
    {
        public Sheep(int health, int damage) : base(health, damage)
        {
            this.health = 10;
            this.damage = 0;
        }
    }
}
