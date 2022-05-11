using System.Collections.Generic;


namespace Heranca.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit):base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

        public override string ToString()
        {
            return "|Account Number: "
                + Number
                + "| |Name: "
                + Holder
                + "| |Balance:U$ "
                + Balance
                + "| |LoanLimit:U$ "
                + LoanLimit
                + "|";
        }
    }
}
