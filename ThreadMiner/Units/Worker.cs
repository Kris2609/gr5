using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadMiner.Units
{
    class Worker:Unit
    {
       

        public Worker(int health, string name, int damage,int cost) :base(health,name,damage, cost)
        {
            this.health = 20;
            this.name = "Worker";
            this.damage = 2;
            this.cost = 90;
        }

       

    }
}
