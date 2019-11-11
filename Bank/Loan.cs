using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Loan:Account
    {
        private double loan_money;
        private int Nr_mounths;
        private double dobanda;

        public Loan(ICustomer c, double loanmoney,int nrmounths) : base(c, 0, 20)
        {
            this.loan_money = loanmoney;
            this.Nr_mounths = nrmounths;
            
        }
       
        public override void CalculateInterest()
        {
            if(client is Companies)
            {
                if (Nr_mounths <= 2)
                {
                    dobanda = 0;
                }
                if (Nr_mounths > 2)
                {
                    dobanda = (interestRate / 100) * loan_money * (Nr_mounths - 2);
                }
                Console.WriteLine($"La imprumutul de: {loan_money}$ pe {Nr_mounths} luni aveti de platit la dobanda {interestRate}% o rata de: {dobanda}");
            }
            if(client is Individual)
            {
                
                if(Nr_mounths <= 3)
                {
                    dobanda = 0;
                }
                if(Nr_mounths > 3)
                {
                    dobanda = (interestRate / 100) * loan_money * (Nr_mounths - 3);
                }
                Console.WriteLine($"La imprumutul de: {loan_money}$ pe {Nr_mounths} luni aveti de platit la dobanda {interestRate}% o rata de: {dobanda}$");
            }
        }
        public override void AccountSituation()
        {
            Console.WriteLine($"La imprumutul de {loan_money}$ pe {Nr_mounths} luni cu o rata de {dobanda}$ la dobanda {interestRate}% ati achitat {balance}$");
        }
    }
}
