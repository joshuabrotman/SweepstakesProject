using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<int> queue = new Queue<int>();
        public void EnqueueOnQueue(int numToEnqueue)
        {
            
            queue.Enqueue(numToEnqueue);
            
        }
    }
}
