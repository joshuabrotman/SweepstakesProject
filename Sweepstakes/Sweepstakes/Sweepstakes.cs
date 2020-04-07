using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<string, int> contestants = new Dictionary<string, int>();
        string name;
        string Name;
        
        public void SweepStakes(string name)
        {

        }

        public void RegisterContestant(Contestant contestant)
        {

        }

        public Contestant PickWinner()
        {
            return null;
        }

        void PrintContestantInfo(Contestant contestant) 
        {
            Console.WriteLine(contestant.fName+" "+contestant.lName+" "+contestant.eMail+" "+contestant.registrationNum);
        }


    }
}
