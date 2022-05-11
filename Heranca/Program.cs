using System;
using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Sammy", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Samuel", 0.0, 0.01);

            //DOWNCASTING (obs: é uma operação insegura, tem que testar antes)

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);


            //BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan Success!");
            }
            if (acc3 is SavingsAccount)
            {
               // SavingsAccount acc5 = (SavingsAccount)acc3;
               SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update has made!");
            }

            

        }
    }
}
