using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadMiner.Enemies
{
    class Enemy
    {
        protected int health;
        protected int damage;

        

        public Enemy(int health, int damage)
        {
            this.health = health;
            this.damage = damage;
        }

        public void target()
        {

        }
    }
}
