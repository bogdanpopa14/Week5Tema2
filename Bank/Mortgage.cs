using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Mortgage:Account
    {
        private double mortgage_money;
        private int Nr_mounths;
        private double dobanda;

        public Mortgage(ICustomer c, double mortgagemoney, int nrmounths) : base(c, 0, 20)
        {
            this.mortgage_money = mortgagemoney;
            this.Nr_mounths = nrmounths;
            this.dobanda = 0;
        }

        public override void CalculateInterest()
        {
            if (client is Companies)
            {
                if (Nr_mounths <= 12)
                {
                    dobanda = (interestRate / 100)/2 * mortgage_money * (Nr_mounths - 2);
                }
                if (Nr_mounths > 12)
                {
                    dobanda = (interestRate / 100) * mortgage_money * (Nr_mounths - 2);
                }
                Console.WriteLine($"La ipoteca de: {mortgage_money}$ pe {Nr_mounths} luni aveti de platit o rata de: {dobanda}");
            }
            if (client is Individual)
            {

                if (Nr_mounths <= 6)
                {
                    dobanda = 0;
                }
                if (Nr_mounths > 6)
                {
                    dobanda = (interestRate / 100) * mortgage_money * (Nr_mounths - 6);
                }
                Console.WriteLine($"La ipoteca de: {mortgage_money}$ pe {Nr_mounths} luni aveti de platit o rata de: {dobanda}");
            }
        }
        public override void AccountSituation()
        {
            Console.WriteLine($"La ipoteca de {mortgage_money}$ pe {Nr_mounths} luni cu o dobanda de {dobanda}$ ati achitat {balance}$");
        }
    }
}
