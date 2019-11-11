using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account
    {
        protected ICustomer client;
        protected double balance;
        protected double interestRate;
        public Account(ICustomer c,double b,double i)
        {
            this.client = c;
            this.balance = b;
            this.interestRate = i;
        }
        public  void DepositMoney(double nr)
        {
            balance += nr;
        }
        public abstract void CalculateInterest();
        
        public abstract void AccountSituation();
        
            
    }
}
