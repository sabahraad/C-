using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Saving : Account
    {
        public double Openingbalance { get; set; }
        public Saving(){}
        public Saving(string accname,string accid,double balance,double openingbalance) : base(accname, accid, balance)
        {
            Openingbalance = openingbalance;
        }
        public override void Deposit(double amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("Deposit Amount:" + amount );
            Console.WriteLine("NEW BALANCE: " + Balance);
        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 20 * Openingbalance / 100)
            {
                Balance -= amount;
                Console.WriteLine("Withdraw Amount: " + amount + "BALANCE: " + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance maximum amount you can withdraw is:" + (Balance - (20 * Openingbalance / 100)));
            }     
        }
        public override void Transfer(Account a, double amount)
        {
            if (Balance - amount >= 20 * Openingbalance / 100)
            {
                Balance -= amount;
                a.Balance += amount;
                Console.WriteLine("Transfer Amount: {0} New Balance: {1} Transfered to {2} ", amount, Balance, a.AccName);
            }
            else
            {
                Console.WriteLine("Insufficient Balance, maximum amount you can Transfer is:" + (Balance - (20 * Openingbalance / 100)));
            }
        }
        public override void Showinfo()
        {
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            Console.WriteLine("Account Name:{0}  Account NO: {1}   Balance: {2}", AccName, AccId,Balance);
        }




    }
}
