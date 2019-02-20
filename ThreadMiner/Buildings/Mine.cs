using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadMiner.Building
{
    class Mine
    {
        private int gold;
        private float worktime;
        private static int workersInMine = 5;
        
        
       
        
        
        public Mine()
        {
            this.gold = 10000;
            this.worktime = 5;
            Thread mWorker = new Thread(WorkingInMine);
            for (int i = 0; workersInMine > 5; i++)
            {
                mWorker.Start();
            }
            mWorker.IsBackground = true;
        }

        public static void WorkingInMine()
        {
               
            while (workersInMine > 5)
            {
                workersInMine++;
                
            }
            
        }
    }
}
