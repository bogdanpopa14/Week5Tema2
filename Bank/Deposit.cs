using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Deposit:Account, IWithdraw
    {
        private int Nr_mounths;
        private double dobanda;
        
        public Deposit(ICustomer c,double b,int mounths) : base(c, b, 10) 
        {
            this.Nr_mounths = mounths;
           
        }
        public override void CalculateInterest()
        {
            
            if(balance>0&&balance<1000)
            {
                dobanda = 0;
            }
            if(balance>1000)
            {
                
                dobanda = interestRate/100 * balance * Nr_mounths;
                
            }
            
            Console.WriteLine($"Pentru {Nr_mounths} luni aveti o dobanda de {dobanda}$");
            balance += dobanda;
            
        }

        



        public void WithdrawMoney(double nr)
        {
            balance -= nr;
        }

        public override void AccountSituation()
        
           
        
        {
            Console.WriteLine($"Mai aveti in cont: {balance} la depozitul creat pe {Nr_mounths} luni");
        }

        public void St()
        {
            throw new NotImplementedException();
        }
    }
}
