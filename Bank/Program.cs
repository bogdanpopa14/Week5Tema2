using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer c1 = new Companies("Companie");
            ICustomer c2 = new Individual("Bgd", 23);
            
            

            //Account l1 = new Loan(c1, 2000, 2);
            //l1.DepositMoney(200);
            //l1.CalculateInterest();
            //l1.AccountSituation();
            
            Console.WriteLine();

            Account d1 = new Deposit(c1, 3000, 12);
            d1.CalculateInterest();
            d1.AccountSituation();
            
            
            //Account l2 = new Loan(c2, 5000, 6);
            //l2.DepositMoney(100);
            //l2.CalculateInterest();
            //l2.AccountSituation();
            Console.ReadLine();
        }
        
    }
}
