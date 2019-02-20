using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadMiner.Enemy
{
    class Pig:Enemies.Enemy
    {
        
        public Pig(int health, int damage) : base(health, damage)
        {
            this.health = 20;
            this.damage = 0;
        }

        
    }
}
