using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Account
    {
        public string AccName { get; set; }
        public string AccId { get; set; }
        public double Balance { get; set; }

        public  Account(){}
        public Account(string accName,string accid,double balance)
        {
            AccName = accName;
            AccId = accid;
            Balance = balance;
        }
        abstract public void Showinfo();
        abstract public void Deposit(double amount);
        abstract public void Withdraw(double amount);
        abstract public void Transfer(Account a,double amount);

    }
}
