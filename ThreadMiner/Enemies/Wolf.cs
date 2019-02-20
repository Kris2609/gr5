using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadMiner.Enemy
{
    class Wolf:Enemies.Enemy
    {
        

        public Wolf(int health, int damage) :base(health,damage)
        {
            
            this.health = 50;
            this.damage = 3;
        }

        //public void ReceiveGold()
        //{
        //    if (Wolf.health += 0)
        //    {
        //        gold++;
        //    }
        //}

        public void Attack()
        {

        }
    }
}
