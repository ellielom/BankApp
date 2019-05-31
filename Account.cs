using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_ElizabethLombardi
{
    class Account
    {
        private double balance = 0;

        public double depositFunds(double deposit)
        {
            if (deposit < 0)
                throw new Exception("Cannot deposit a negative amount");

            balance += deposit;
            return balance;
        }

        public double withdrawFunds(double withdraw)
        {
            if (withdraw < 0)
                throw new Exception("Cannot withdraw a negative amount");

            if (balance < withdraw)
                throw new Exception("Cannot withdraw more than current balance amount");

            balance -= withdraw;

            return balance;
        }

        public double calcInterest(double interestAmt)
        {
            if (interestAmt < 0)
                throw new Exception("Cannot have negative interest");
            if (balance == 0 || balance < 0)
                throw new Exception("Cannot give interest on an empty account");

            interestAmt /= 100;

            return balance += balance*(interestAmt);
        }

    }
}
