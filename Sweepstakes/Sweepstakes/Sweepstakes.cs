using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        string name;
        string Name;
        
        public void SweepStakes(string name)
        {

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNum = contestants.Count;
            contestants.Add(contestant.registrationNum, contestant);
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
