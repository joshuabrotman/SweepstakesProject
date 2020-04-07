using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {

        public void AddContestant()
        {
            Contestant NewContestant = new Contestant();
            Console.WriteLine("Please enter the contestants first name:");
            NewContestant.fName = Console.ReadLine();
            Console.WriteLine("Please enter the contestants last name:");
            NewContestant.lName = Console.ReadLine();
            Console.WriteLine("Please enter the contestants E-Mail:");
            NewContestant.eMail = Console.ReadLine();
            NewContestant.registrationNum = registrationNum.count();

        }
    }
}
