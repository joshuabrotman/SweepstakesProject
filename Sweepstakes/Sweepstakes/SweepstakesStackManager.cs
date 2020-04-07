using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {

        Stack<int> stack = new Stack<int>();

        public void PushOnToStack(int numToPush)
        {
            

            stack.Push(numToPush);
            
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }

        public Sweepstakes GetSweepstakes()
        {
            return null;
        }
    }
}
