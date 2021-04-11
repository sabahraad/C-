using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class OverDraft:Account
    {
        public int Limit { get; set; }
        public OverDraft() { }
        public OverDraft(string accname,string accid,double balance,int limit):base (accname,accid,balance)
        {
            Limit = limit;

        }
        public override void Deposit(double amount)
        {
            Balance = Balance + Limit + amount;
            Console.WriteLine("Deposit Amount : {0} NEW BALANCE: {1}",amount,Balance);
        }
        public override void Withdraw(double amount)
        {
            if (amount <= Balance + Limit)
            {
                Balance -= amount;
                Console.WriteLine("Withdraw Amount:{0} NEW BALANCE: {1}", amount, Balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance,maximum amount you can withdraw is:" + (Balance + Limit));
            }
        }
        public override void Transfer(Account a, double amount)
        {
            if (amount <= Balance + Limit)
            {
                Balance -= amount;
                a.Balance += amount;
                Console.WriteLine("Withdraw Amount:{0} NEW BALANCE: {1} Transfered to :{2} Transfered Account No:{3}", amount, Balance,a.AccName,a.AccId);
            }
            else
            {
                Console.WriteLine("Insufficient Balance,maximum amount you can Transfer is:" + (Balance + Limit));
            }
        }
        public override void Showinfo()
        {
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            Console.WriteLine("Account Name:{0} Account ID:{1}", AccName, AccId);
        }

    }
}
