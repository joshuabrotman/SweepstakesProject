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
            Contestant NewConstestant = new Contestant();
            Console.WriteLine("Please enter the contestants first name:");
            NewConstestant.fName = Console.ReadLine();
            Console.WriteLine("Please enter the contestants last name:");
            NewConstestant.lName = Console.ReadLine();
            Console.WriteLine("Please enter the contestants E-Mail:");
            NewConstestant.eMail = Console.ReadLine();

        }
    }
}
