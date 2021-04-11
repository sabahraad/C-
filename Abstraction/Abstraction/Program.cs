using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Account A1 = new Saving("Raad", "18-38242-2", 173000.00, 1000);
            Account B1 = new Saving("Saad", "18-38242-1", 73000.00, 1000);

            Account C1 = new OverDraft("Rudmila", "18-3000-3", 3000.00, 1000);
            Account D1 = new OverDraft("fuad", "18-38112-2", 17000.00, 1000);
            A1.Showinfo();
            A1.Deposit(5000);
            B1.Showinfo();
            B1.Deposit(500);
            B1.Withdraw(200);
            B1.Transfer(A1, 20);

            C1.Showinfo();
            C1.Deposit(2000);
            C1.Withdraw(50);
            C1.Transfer(D1, 100);
            A1.Showinfo();
        }
    }
}
