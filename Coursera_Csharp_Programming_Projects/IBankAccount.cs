using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Coursera_Csharp_Programming_Projects
{

    interface IManagedBank
    {
        void openAccount();
        void closeAccount();
    }
    internal interface IBankAccount
    {
        void deposit();
        void withdraw();
        void balance();
    }

    public class SavingAcc : IBankAccount,IManagedBank
    {
        public void balance()
        {
            Console.WriteLine("Balance in Saving Account.");
        }

        public void closeAccount()
        {

            Console.WriteLine("Closing in Saving Account");
        }


        public void deposit()
        {
            Console.WriteLine("Deposit in Saving Account.");
        }

        public void openAccount()
        {
             
            Console.WriteLine("Opening in Saving Account");
        }


        public void withdraw()
        {
            Console.WriteLine("Withdraw in Saving Account.");
        }
    }
}
